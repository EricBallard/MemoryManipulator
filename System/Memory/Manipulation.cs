
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace MemoryManipulator
{
    /*
     * Model of memory manipulation, contains base address,
     * original bytes, and required bytes to write to achieve desired affect
     */
    class Manipulation
    {

        // Address to modify bytes
        public int baseAddress { get; set; }

        // Number of bytes to manipulate
        int totalBytes { get; set; }

        // Cached reference of OEM bytes
        byte[] originalBytes { get; set; }

        // Cached reference of byte for manipulation
        byte manipulatedByte { get; set; }
        int[] manipulatedBytes { get; set; }

        // Enabled = true if manipulated byte is written to base address
        public bool enabled { get; set; }

        // A handle to the authorized process with access to read/write memory
        public int authorizedProcess { get; set; }

        public Manipulation(int authorizedProcess, int baseAddress, int totalBytes, string manipulatedByte)
        {
            this.authorizedProcess = authorizedProcess;
            this.baseAddress = baseAddress;
            this.totalBytes = totalBytes;
            this.enabled = false;

            // Do not manipulate bytes when finding player base and inventory
            if (manipulatedByte != null)
            {
                // Convert manipulated byte from hex to decimal
                if (manipulatedByte.Length > 2)
                    this.manipulatedBytes = Signature.ToBytes(manipulatedByte);
                else
                    this.manipulatedByte = (byte)Int32.Parse(manipulatedByte, NumberStyles.HexNumber);
            }

            // Cache original byte at address
            int bytesRead = 0;
            byte[] buffer = new byte[totalBytes];

            Win32.ReadProcessMemory(this.authorizedProcess, baseAddress, buffer, totalBytes, ref bytesRead);
            this.originalBytes = buffer;

            Debug.WriteLine(this.totalBytes + " | OG BYTE: " + this.originalBytes[0].ToString("X2"));
        }

        // Toggle enabled byte manipulation
        public bool Toggle()
        {
            // Edit item/player menu toggle
            if (Array.IndexOf(Program.manipulations, this) <= 2)
            {
                this.enabled = !this.enabled;
                Program.overlay.ToggleGroup(Array.IndexOf(Program.manipulations, this));
                return true;
            }


            int bytesWritten = 0;

            // Select byte to write at address
            byte[] buffer;

            if (this.enabled)
            {
                // Disable
                buffer = this.originalBytes;
            }
            else
            {
                // Enable
                if (this.manipulatedBytes != null)
                {
                    int size = this.manipulatedBytes.Length;
                    buffer = new byte[size];

                    for (int index = 0; index < size; index++)
                    {
                        int value = this.manipulatedBytes[index];
                        buffer[index] = (byte)(value == -1 ? 00 : value);
                    }
                }
                else
                {
                    buffer = new byte[this.totalBytes];

                    for (int i = 0; i < this.totalBytes; i++)
                        buffer[i] = this.manipulatedByte;
                }
            }

            // Write to memory
            Win32.WriteProcessMemory(this.authorizedProcess, baseAddress, buffer, this.totalBytes, ref bytesWritten);

            // Validate
            if (bytesWritten > 0)
            {
                this.enabled = !this.enabled;
                Debug.WriteLine(bytesWritten + " | Toggled... " + this.enabled);

                return true;
            }

            return false;
        }

        /* EDIT PLAYER GROUP */

        /* EDIT ITEM GROUP */

        // Sets base address to first item inventory 
        public void SetToCurrentItem()
        {
            int playerBase = Program.manipulations[0].baseAddress;

            // We can find this one by offsetting from the previous, no need to scan :P
            // The offset here hosts a pointer to the inventory base address
            int baseInventory = Memory.GetAsInt(this.authorizedProcess, playerBase + Offsets.PlayerAttributes.INVENTORY.offset, false);

            // We're only going to modify the first item slot which is another pointer, hosted in inv offset by 8 bytes 
            int selected = Memory.GetAsInt(this.authorizedProcess, playerBase + Offsets.PlayerAttributes.SELECTED.offset, false);

            Debug.WriteLine("SELECTED ITEM INDEX: " + selected);
            selected = (selected < 1 ? 0 : selected * 4);

            int baseItem = Memory.GetAsInt(this.authorizedProcess, baseInventory + 8 + selected, false);

            // Create a base manipulation - we want to alter several addresses which can be found by offsetting from inv addr
            this.baseAddress = baseItem;
        }

        /*

        // Returns an array of current values for all item attributes
        public Dictionary<ItemAttribute, int> GetItemAttributes()
        {
            // Set base to current item addresses
            this.SetToCurrentItem();

            // Store memory values - Attribute | Value
            Dictionary<ItemAttribute, int> attributes = new Dictionary<ItemAttribute, int>();

            // Extracts values from memory and cache
            foreach (ItemAttribute attribute in Enum.GetValues(typeof(ItemAttribute)))
            {
                // Offset from base item to obtain this attribute
                int offset = (int)attribute;

                // These values are stored as floats while others are ints
                bool isFloat = (attribute == ItemAttribute.SCALE
                                    || attribute == ItemAttribute.AMMOSPEED
                                        || attribute == ItemAttribute.KNOCKBACK);

                // Read and cache
                attributes[attribute] = Memory.GetAsInt(this.authorizedProcess, this.baseAddress + offset, isFloat);
            }

            return attributes;
        }

        public void SetItemAttributes(Dictionary<ItemAttribute, int> attributes)
        {

            foreach (KeyValuePair<ItemAttribute, int> entry in attributes)
            {
                // Get the offset for attribute
                ItemAttribute key = entry.Key;

                bool isFloat = (key == ItemAttribute.SCALE
                                || key == ItemAttribute.AMMOSPEED
                                || key == ItemAttribute.KNOCKBACK);

                // Write value to addresses 
                if (isFloat ? Memory.SetAsFloat(this.authorizedProcess, this.baseAddress + (int)key, entry.Value)
                    : Memory.SetAsInt(this.authorizedProcess, this.baseAddress + (int)key, entry.Value))

                    Debug.WriteLine($"{entry.Key} = {entry.Value}");
                else
                    Debug.WriteLine($"Failed to Write!!!! {entry.Key}");

            }

            // Update base with new current item
            this.SetToCurrentItem();
        }

        /* EDIT NPC GROUP */
        public void SetToEntityList()
        {
            /*
             * 
            // We can find this one by offsetting from the previous, no need to scan :P
            // The offset here hosts a pointer to the inventory base addr
            int pointerAddr = Memory.GetAsInt(this.authorizedProcess, this.baseAddress + 1, false);

            int entityList = Memory.GetAsInt(this.authorizedProcess, pointerAddr, false);

            // Create a base manipulation - we want to alter several addresses which can be found by offsetting from inv addr
            this.baseAddress = entityList;// + 8;

            */
        }
    }
}
