

using System;

namespace MemoryManipulator
{
    class Memory
    {

        public static bool GetAsBool(int authorizedProcess, int address)
        {
            // Read 4 bytes at offset and convert to int32
            int bytesRead = 0;
            byte[] buffer = new byte[1];
            Win32.ReadProcessMemory(authorizedProcess, address, buffer, 1, ref bytesRead);

            return BitConverter.ToBoolean(buffer);
        }

        // Reads the first 4 bytes at address and converts those bytes
        // to an int32 (32bit integer is 4 bytes, 16bit is 2 bytes, etc..)
        // which represents an address located in RAM
        public static int GetAsInt(int authorizedProcess, int address, bool isFloat)
        {
            // Read 4 bytes at offset and convert to int32
            int bytesRead = 0;
            byte[] buffer = new byte[4];
            Win32.ReadProcessMemory(authorizedProcess, address, buffer, 4, ref bytesRead);

            return isFloat ? (int)BitConverter.ToSingle(buffer) : BitConverter.ToInt32(buffer);
        }

        public static bool SetAsInt(int authorizedProcess, int address, int value)
        {
            // Read 4 bytes at offset and convert to int32
            int bytesWritten = 0;
            byte[] buffer = BitConverter.GetBytes(value);
            Win32.WriteProcessMemory(authorizedProcess, address, buffer, 4, ref bytesWritten);

            return bytesWritten == 4;
        }

        public static bool SetAsFloat(int authorizedProcess, int address, float value)
        {
            int bytesWritten = 0;
            byte[] buffer = BitConverter.GetBytes(value);
            Win32.WriteProcessMemory(authorizedProcess, address, buffer, 4, ref bytesWritten);

            return bytesWritten == 4;
        }
    }
}
