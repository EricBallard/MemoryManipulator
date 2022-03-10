using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MemoryManipulator
{
    internal struct Flags
    {
        public const int PROCESS_QUERY_INFORMATION = 0x0400;
        public const int PROCESS_VM_OPERATION = 0x0008;
        public const int PROCESS_VM_READ = 0x0010;
        public const int PROCESS_VM_WRITE = 0x0020;
        public const int MEM_MAPPED = 0x40000;
    }

    // Finds a series of pre-defined bytes actively contained within a process' memory, aka signature scanning
    class ByteSignature
    {

        // Generated on a successful Find() - cached signature details for manipulation
        public Manipulation manipulation;

        // Confirmed series of bytes, read from memory, that match desired signature
        private MatchSeries match;

        // Cached bytes refrences target signature
        private int[] sigBytes;

        // Cached refrence of hex value of the byte to write to offset address of found signature`
        private string manipulatedByte;

        // Total bytes to manipulate
        private int totalBytes;

        // Compare a byte in refrence to a byte in target signature index
        private bool CompareBytes(byte b, int index)
        {
            int value = sigBytes[index];
            return value.Equals(-1) ? true : ((byte)value).Equals(b);
        }

        // Defined series of 2 digit hex bytes to look for in memory - manipulatedByte is the hex value of the byte to write
        public void SetTarget(string signature, string manipulatedByte, int totalBytes)
        {
            this.match = null;
            this.totalBytes = totalBytes;

            this.sigBytes = Signature.ToBytes(signature);
            this.manipulatedByte = manipulatedByte;
        }

        public bool Find(bool deepScan)
        {
            // Extract info about target process
            Win32.SYSTEM_INFO systemInfo = new Win32.SYSTEM_INFO();
            Win32.GetSystemInfo(out systemInfo);

            // Extract the bounds of memory that the target process has access to
            IntPtr minAddr = systemInfo.minimumApplicationAddress;
            IntPtr maxAddr = systemInfo.maximumApplicationAddress;

            // Open the process with desired access level
            // https://docs.microsoft.com/en-us/windows/win32/procthread/process-security-and-access-rights
            IntPtr processHandle = Win32.OpenProcess(0x0400 | 0x0008 | 0x0010 | 0x0020, false, Program.targetProcess.Id);

            if (processHandle == IntPtr.Zero)
            {
                Debug.WriteLine("FAIED TO OPEN HANDEL!");
                return false;
            }


            // This will store information we get from VirtualQueryEx()
            Win32.MEMORY_BASIC_INFORMATION memoryChunk = new Win32.MEMORY_BASIC_INFORMATION();

            while (minAddr.ToInt32() < maxAddr.ToInt32())
            {
                // Extract information about this memory chunk, is it readable, size, base address, etc
                Win32.VirtualQueryEx(processHandle, minAddr, out memoryChunk, (uint)Marshal.SizeOf(memoryChunk));

                int access = memoryChunk.Protect;

                // Is this memory chunk accessible
                if (access.Equals(64) || (deepScan && access.Equals(4)))
                {
                    int byteRead = 0;
                    byte[] buffer = new byte[memoryChunk.RegionSize];

                    // Read memory to buffer
                    Win32.ReadProcessMemory((int)processHandle, memoryChunk.BaseAddress, buffer, buffer.Length, ref byteRead);

                    // Process memory buffer
                    int offset = analyze(buffer);

                    // Calculate results - if found offset return true
                    if (offset != -1)
                    {
                        // Deep scan is only on first iteration (looking for player base) we need to splice this a bit to get exact start of player base
                         if (deepScan)
                             offset -= 4;

                        // Cache details
                        this.manipulation = new Manipulation((int)processHandle, memoryChunk.BaseAddress + offset, totalBytes, manipulatedByte);
                        return true;
                    }
                }

                // Move to next memory chunk
                minAddr = IntPtr.Add(minAddr, memoryChunk.RegionSize);
            }

            // No matches
            return false;
        }

        // Returns index of byte in buffer that starts a found match, -1 = no match found
        private int analyze(byte[] buffer)
        {
            int bufferSize = buffer.Length;

            for (int index = 0; index < bufferSize; index++)
            {
                byte b = buffer[index];

                // Do we have a current match
                if (match != null)
                {
                    // Does this byte match the next byte in sig sequence
                    if (CompareBytes(b, match.series))
                    {
                        // Continue series
                        match.add(b);

                        // Check if complete match
                        if (match.series == sigBytes.Length)
                        {
                            // WE FOUND A MATCH :')
                            // Returns the offset of the first byte in series, relative to page base address
                            return index - match.series + 1;
                        }
                    }
                    else
                    {

                        // Series broken... is a containing match a potential lead?
                        int backstep = getPotentialStart();

                        if (backstep != -1)
                        {
                            // Yes

                            // Start record of match
                            b = match.matches[backstep];
                            match = new MatchSeries(b, sigBytes.Length);

                            // Rewind buffer loop
                            index -= backstep;
                        }
                        else
                        {
                            // No
                            match = null;
                        }
                    }
                }
                else
                {
                    // Does this byte match the first byte in our signature
                    if (sigBytes[0].Equals(b))
                    {
                        // Start record of match
                        match = new MatchSeries(b, sigBytes.Length);
                    }
                }
            }

            return -1;
        }


        // Checks if a contained bytes matches the start of target signature
        private int getPotentialStart()
        {
            // Start at 2nd entry, first will obviously be a match :)
            for (int index = 1; index < match.series; index++)
            {
                // Does byte match start
                if (CompareBytes(match.matches[index], 0))
                {
                    // Yes - Return the index, we will back-step the buffer by this offset
                    return index;
                }
            }

            // No matches
            return -1;
        }
    }
}