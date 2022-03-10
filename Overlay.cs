
using MemoryManipulator.Util;
using System;

using System.Linq;
using System.Collections.Generic;

using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using static MemoryManipulator.Offsets;

namespace MemoryManipulator
{
    public partial class Overlay : Form
    {

        // Overlay is actively being shown
        public bool visible = false;

        // Track when target window is mini/max
        public WindowState windowState;

        public Overlay()
        {
            InitializeComponent();
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            // Configure overlay window style
            this.StyleWindow();

            // Start system hooks - allows overlay to track moves,etc
            Program.winHook.Start();
            Program.keyHook.Start();

            // Unminize target window
            if (WindowStates.Get(Program.targetHandle) == MemoryManipulator.WindowState.MINIMIZED)
                Win32.ShowWindow(Program.targetHandle, 1);

            // Focus target window
            Win32.SetForegroundWindow(Program.targetHandle);
        }

        // Toggles item group visibility for item/player attributes
        internal void ToggleGroup(int index)
        {
            bool visible;

            switch (index)
            {

                default:
                case 0:
                    visible = playerGroup.Visible;
                    visible = (playerGroup.Visible = !visible);
                    break;
                case 1:
                    visible = itemGroup.Visible;
                    visible = (itemGroup.Visible = !visible);
                    break;
                case 2:
                    visible = npcGroup.Visible;
                    visible = (npcGroup.Visible = !visible);
                    break;
            }

            Win32.SetWindowLong(this.Handle, -20, visible ? Win32.GetWindowLong(Program.targetHandle, -20) : modifiedStyle);

            if (visible)
            {
                // If we are opening the item group we need to reset this overlays window style to regain mouse events
                // As such after we reset the style we need to reconfigure transparency, etc
                //(Mouse events are re-disabled when group is closed)
                StyleWindow();

                Manipulation manipulation = Program.manipulations[index];

                if (index == 1)
                {
                    // Update address
                    manipulation.SetToCurrentItem();

                    // Get name, manually set label text
                    int id = Memory.GetAsInt(manipulation.authorizedProcess, manipulation.baseAddress + Offsets.ItemAttributes.TYPE.offset, false);
                    editItemLbl.Text = GameData.GetName(id, true);

                    // Read offsets and apply to form controls
                    ReadAttributes(Offsets.Attribute.ToList(typeof(Offsets.ItemAttributes)), manipulation.authorizedProcess, manipulation.baseAddress);
                }
            }
            else
            {
                // Focus game window, when interacting with item group overlay handle has focus
                // Doing this prevents the user from having to click the game again to get focus
                Win32.SetForegroundWindow(Program.targetHandle);
            }
        }

        // Toggles overlay visibility
        public void Toggle()
        {
            if (visible = !visible)
            {
                // Show - fade in
                Timer timer = new Timer();
                timer.Interval = 10;

                timer.Tick += new EventHandler((object sender, EventArgs e) =>
                {
                    if (this.Opacity >= 1)
                        timer.Stop();
                    else
                        this.Opacity += 0.05;
                });

                timer.Start();

                this.SizeToTarget();
                this.BringToFront();
                this.Activate();
                this.Show();
            }
            else
            {
                // Hide
                this.Opacity = 0;
                this.Hide();
            }
        }

        // Cached window attributes
        private int barHeight = -1, windowStyle, modifiedStyle;

        public void SizeToTarget()
        {
            // Extract game window dimensions
            Win32.RECT rect = new Win32.RECT();
            Win32.GetWindowRect(Program.targetHandle, out rect);

            // Get client area
            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
            barHeight = barHeight != -1 ? barHeight : screenRectangle.Top - this.Top;

            // Offset window form position by title bar height
            rect.top = rect.top + barHeight;

            // Apply game dimensions to window form
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Left = rect.left;
            this.Top = rect.top;

            // Position labels in bottom right corner of form (local coordinates)
            ldLbl.Location = new Point(this.Size.Width / 2 - 125, this.Size.Height / 2);
            loadProgress.Location = new Point(ldLbl.Location.X, ldLbl.Location.Y + 50);

            int lblX = this.Size.Width - 150;

            playerLbl.Location = new Point(lblX, this.Size.Height - 200);
            itemLbl.Location = new Point(lblX, this.Size.Height - 175);
            npcLbl.Location = new Point(lblX, this.Size.Height - 150);

            // Position 'Edit Item' group above labels
            playerGroup.Location = new Point(0, this.Size.Height - 300);
            itemGroup.Location = new Point(10, this.Size.Height - 820);
            npcGroup.Location = new Point(200, this.Size.Height - 820);

            // Disable input events for overlay form (allows game to receive events instead)
            windowStyle = Win32.GetWindowLong(this.Handle, -20);
            modifiedStyle = (windowStyle | 0x80000 | 0x20);

            Win32.SetWindowLong(this.Handle, -20, modifiedStyle);
        }

        public void ColorLabel(Color color, int choice)
        {
            switch (choice)
            {
                case 0:
                    playerLbl.ForeColor = color;
                    break;
                case 1:
                    itemLbl.ForeColor = color;
                    break;
                case 2:
                    npcLbl.ForeColor = color;
                    break;
            }
        }

        public void Loaded()
        {
            // Hide loading label
            ldLbl.Visible = false;
            loadProgress.Visible = false;

            // Show control labels
            itemLbl.Visible = true;
            playerLbl.Visible = true;
            npcLbl.Visible = true;

            this.BringToFront();
            this.Activate();
        }

        private void StyleWindow()
        {
            // Set form to transparent + remove borders
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Color.Wheat;
            this.BackColor = Color.Wheat;
            this.TopMost = true;
        }

        private void ReadAttributes(List<Offsets.Attribute> attributes, int authorizedProcess, int baseAddress)
        {
            foreach (Offsets.Attribute att in attributes)
            {
                Control node = att.node;

                // NetID has no UI control
                if (node == null)
                    continue;

                // Read offset embedded in object and update referenced form control
                // Get control node - update value
                if (att.type == ObjectType.BOOL)
                {
                    CheckBox checkbox = (CheckBox)node;
                    checkbox.Checked = Memory.GetAsBool(authorizedProcess, baseAddress + att.offset);
                    Debug.WriteLine($"Name: {att.node.Name} | Base: {baseAddress.ToString("X")}  |  Offset: {att.offset}  Value: {checkbox.Checked}");
                }
                else
                {
                    NumericUpDown scroller = (NumericUpDown)node;
                    scroller.Value = Memory.GetAsInt(authorizedProcess, baseAddress + att.offset, att.type == ObjectType.FLOAT);
                    Debug.WriteLine($"Name: {att.node.Name} | Base: {baseAddress.ToString("X")}  |  Offset: {att.offset}  Value: {scroller.Value}");
                }
            }
        }

        /* EVENTS */

        const string itemListURL = "https://terraria.fandom.com/wiki/Item_IDs",
            npcListURL = "https://terraria.fandom.com/wiki/NPC_IDs";

        // Open item type Id list in web browser when "linked list" is clicked
        private void LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = sender.Equals(this.itemList) ? itemListURL : npcListURL;
            Process.Start(psi);
        }

        private void npcSpeed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void editItemLbl_Click(object sender, EventArgs e)
        {

        }

        private void itemPage1_Enter(object sender, EventArgs e)
        {

        }

        private void nxtPage_Click(object sender, EventArgs e)
        {
            if (itemPage1.Visible)
            {
                // Show Page 2
                itemPage1.Visible = false;
                itemPage2.Visible = true;

                // Update labels
                curPage.Text = "2/2";
                nxtPage.Text = "<<";
            }
            else
            {
                // Show Page 1
                itemPage2.Visible = false;
                itemPage1.Visible = true;

                // Update labels
                curPage.Text = "1/2";
                nxtPage.Text = ">>";
            }
        }


        // Select NPC from list
        private void npcList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshList_Click(object sender, EventArgs e)
        {
            Manipulation manipulation = Program.manipulations[2];

            npcList.ClearSelected();
            npcList.Items.Clear();


            // Get player pos
            Manipulation basePlayer = Program.manipulations[0];

            int playerX = Memory.GetAsInt(basePlayer.authorizedProcess, basePlayer.baseAddress + 40, true),
                        playerY = Memory.GetAsInt(basePlayer.authorizedProcess, basePlayer.baseAddress + 44, true);

            Dictionary<string, int> nearbyNpcs = new Dictionary<string, int>();

            // Data is Pointer[]
            // Loops through array, first entry is 8 (4 = size, etc)
            // Hard-limit of 50 entries (256 bytes) to scan, each pointer is 4 bytes
            for (int offset = 8; offset <= 256; offset += 4)
            {
                // Get entity base addr
                int entityPtr = manipulation.baseAddress + offset;
                int entityBase = Memory.GetAsInt(manipulation.authorizedProcess, entityPtr, false);

                // Check if this is a valid entity
                // (The array size is much larger than what is actually populated)
                // (Type == 0 basically means null npc, no need to continue scan)
                int active = Memory.GetAsInt(manipulation.authorizedProcess, entityBase + 32, false);

                if (active != 1)
                    continue;

                // Valid npc - get its current position to compare distance to player
                int type = Memory.GetAsInt(manipulation.authorizedProcess, entityBase + 220, false),
                    health = Memory.GetAsInt(manipulation.authorizedProcess, entityBase + 256, false),
                    posX = Memory.GetAsInt(manipulation.authorizedProcess, entityBase + 40, true),
                    posY = Memory.GetAsInt(manipulation.authorizedProcess, entityBase + 44, true);

                int xDis = Math.Abs(posX - playerX),
                    yDis = Math.Abs(posY - playerY);

                int disFromPlayer = (xDis < yDis ? yDis : xDis) / 20;
                string name = GameData.GetName(type, false);

                string indent = disFromPlayer < 10 ? "    " : disFromPlayer < 100 ? "  " : "";

                // Store info to be sorted after poll
                string toString = $"{indent + disFromPlayer} | {name} ({health}hp)";
                nearbyNpcs[toString] = disFromPlayer;
            }

            // Add sorted items to list
            foreach (KeyValuePair<string, int> item in nearbyNpcs.OrderBy(key => key.Value))
            {
                npcList.Items.Add(item.Key);
            }
        }

        // Apply configured attributes to item
        private void applyItem_Click(Object sender, EventArgs e)
        {
            /*
            // Pack ui input values into dictionary
            Dictionary<ItemAttribute, int> attributes = new Dictionary<ItemAttribute, int>();

            attributes[ItemAttribute.TYPE] = (int)typeValue.Value;
            attributes[ItemAttribute.USETIME] = (int)knockValue.Value;
            attributes[ItemAttribute.PICK] = isPickaxe.Checked ? 1 : 0;
            attributes[ItemAttribute.AXE] = isAxe.Checked ? 1 : 0;
            attributes[ItemAttribute.HAMMER] = isHammer.Checked ? 1 : 0;
            attributes[ItemAttribute.DAMAGE] = (int)damageValue.Value;
            attributes[ItemAttribute.KNOCKBACK] = (int)useValue.Value;
            attributes[ItemAttribute.SCALE] = (int)scaleValue.Value;
            attributes[ItemAttribute.SHOOTABLE] = isShootable.Checked ? 1 : 0;
            attributes[ItemAttribute.AMMOSPEED] = (int)ammoSpeedValue.Value;
            attributes[ItemAttribute.AMMOTYPE] = (int)ammoValue.Value;
            attributes[ItemAttribute.NETID] = (int)typeValue.Value;
            attributes[ItemAttribute.REUSEDELA] = (int)delayValue.Value;

            // Write to memory
            Program.manipulations[1].SetItemAttributes(attributes);


           // var list = new ItemAttributes().GetType().GetFields().ToList();

            */
        }
    }
}