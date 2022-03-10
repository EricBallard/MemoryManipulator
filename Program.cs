using MemoryManipulator.Util;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace MemoryManipulator
{
    static class Program
    {
        // Cached references of found signatures and related info
        internal static Manipulation[] manipulations = new Manipulation[5];

        // Hook window management events to hide/show/scale overlay
        internal static WindowEvents winHook = new WindowEvents();

        // Keyboard hook events for dis/enabling manipulations
        internal static KeyboardEvents keyHook = new KeyboardEvents();


        // Cached references of window form - overlay
        internal static Overlay overlay;

        // Cached references of game process and window handle
        internal static Process targetProcess;

        internal static IntPtr targetHandle;

        internal static bool IsLoaded;

        [STAThread]
        static void Main()
        {
            /* STARTING */

            // Load item data file so we can display item names in our overlay
            GameData.Load(@"..\..\..\..\Util\items.json", true);
            GameData.Load(@"..\..\..\..\Util\npcs.json", false);

            // Find game process + window handle
            Process[] processes = Process.GetProcessesByName("Terraria");

            if (processes.Length < 1)
            {
                // Game is not running?
                MessageBox.Show("Please start Terraria and try again.", "MemoryManipulator (1.0)");
                return;
            }

            // Found process - cache window handle
            targetHandle = (targetProcess = processes[0]).MainWindowHandle;

            // Define targets and scan memory
            new Thread(() =>
            {
                // Memory byte signatures; set, scan, manipulate!
                ByteSignature memory = new ByteSignature();

                for (int i = 0; i <= 2; i++)
                {
                    string targetSignature = null, manipulatedByte = null;
                    int totalBytes = 1;

                    switch (i)
                    {
                        case 0:
                            // Find base player
                            targetSignature = Signature.basePlayer;
                            totalBytes = 24;
                            break;
                        case 1:
                            // Load base manipulation for inv as filler
                            Manipulation basePlayer = manipulations[0];
                            manipulations[1] = new Manipulation(basePlayer.authorizedProcess, basePlayer.baseAddress, 4, null);

                            // Progress UI loading bar
                            overlay.Invoke(new Action(() => overlay.loadProgress.Value += 20));
                            continue;
                        case 2:
                            // Find base entity list
                            targetSignature = Signature.drawNpcs;
                            totalBytes = 5;
                            break;
                            /*
                        case 2:
                            // Find player damage func
                            targetSignature = Signature.playerHurt;
                            manipulatedByte = "C3"; // ret
                            totalBytes = 1;
                            break;
                            /*
                        case 3:
                            // Find npc damage func
                            targetSignature = Signature.npcHurt;
                            manipulatedByte = "C78600010000000000009090909090"; // mov [esi+00000100], 0
                            totalBytes = 15;
                            break;
                        case 4:
                            // Find item use func
                            targetSignature = Signature.itemUse;
                            manipulatedByte = "5A"; // nop
                            totalBytes = 6;
                            break;
                            */
                    }

                    // Register our defined signature as target for scanner
                    memory.SetTarget(targetSignature, manipulatedByte, totalBytes);

                    // Need to deep scan to find the base player.. this is only neccesary to find this address, deep = slow
                    bool deepScan = (i == 0);

                    // Scan and handle result
                    if (!memory.Find(deepScan))
                    {
                        string msg = (deepScan ? "Unable to start!\n\nPlease select a Player and join a World." :
                            "Failed to find signature!\n\nThis application targets Terraria 1.4.2.3\n" +
                            "Please verify your game version and try again.");

                        // Failed to find signature - user is running different version? updated?
                        // Show message on UI thread - Setting 'Overlay' form as parent ensures messagebox is inherited topmost
                        waitForOverlay();
                        overlay.Invoke(new Action(() => MessageBox.Show(overlay, msg, "MemoryManipulator (1.0)")));

                        // Shutdown all threads
                        Application.Exit();
                        return;
                    }

                    Debug.WriteLine("FOUND MANIP: " + i + "   = " + memory.manipulation.baseAddress.ToString("X"));

                    // Found signature in memory - nice - cache signature details for manipulation
                    manipulations[i] = memory.manipulation;

                    if (i == 0)
                        waitForOverlay();
                    else
                    if (i == 2)
                    {
                        manipulations[2].SetToEntityList();
                        Debug.WriteLine("LIST: " + manipulations[2].baseAddress.ToString("X"));
                    }

                    // Advance loading bar
                    overlay.Invoke(new Action(() => overlay.loadProgress.Value += 20));
                }

                // Finished - Did we find all our manipulations?
                if (manipulations[2] != null)
                {
                    // Hide loading stuff
                    overlay.Invoke(new Action(() => overlay.Loaded()));

                    // Adjust window title
                    Win32.SetWindowText(Program.targetHandle, "Terraria: Manipulated!");

                    IsLoaded = true;
                }
                else
                {
                    Debug.Write("FAILED TO FIND LAT MANIP?");
                }
            }).Start();

            // While memory scanner is running we'll start the GUI

            // Start overlay GUI (BLOCKING)
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(overlay = new Overlay());

            /* STOPPING */

            winHook.Stop();
            keyHook.Stop();
        }

        private static void waitForOverlay()
        {
            bool overlayStarted;

            while (!(overlayStarted = overlay != null))
            {
                Debug.WriteLine("Waiting for GUI to initialize...");
                Thread.Sleep(200);
            }
        }
    }
}
