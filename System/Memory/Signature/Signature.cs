
using System;
using System.Globalization;

namespace MemoryManipulator
{

    // A unique sequence of identifying bytes written to RAM by an active process
    class Signature
    {
        // X = Wild Card
        public static string basePlayer { get { return "0000000000000000000000000100000001000000140000002A0000000100000000000000"; } }
        //"0000000000000000000000000100000001000000140000002A0000000100000000000000"; } }
        //"9459xxxx000000000000000000000000xxxxxxxxxxxxxxxx140000002A0000000100000000000000"; } }

        public static string playerHurt { get { return "558BEC57xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxB9xxxxxxxx33xxF3xx8Bxx89xxxxxxxxxx89xxxxxxxxxx8Bxxxxxxxxxx80xxxxxxxxxxxx74xxD9EE"; } }

        public static string itemUse { get { return "FF88B00000008B85E0FCFFFF83B8B000"; } }

        public static string manaUse { get { return "2986DC030000EB3B80BE8707000000742B8BCEFF15E8"; } }

        public static string ammoUse { get { return "FF88B00000008B45E083B8B0000000007F0F8B45E0"; } }

        public static string npcHurt { get { return "F20F1045E8F20F2CC0298600010000D94518D9EEDFF1DDD8"; } }

        public static string drawNpcs { get { return "A1xxxxxxxx3B58040F8325340000xx4C98083909"; } }

        // todo - 6bytes nop
        public static string emitLight { get { return "0F85EE0200008B85F0FCFFFF80B842060000000F85DB"; } }

        // Convert string to byte array where 2 char = 1 byte
        public static int[] ToBytes(string pattern)
        {
            // 2 digit = 1 hex byte (558Bxx = 55, 8B, 00, ...)
            char[] chars = pattern.ToCharArray();
            int charBytes = chars.Length;

            int[] bytes = new int[charBytes / 2];
            int index = 0;

            // Iterate string characters, cache every 2 chars 
            for (int subIndex = 0; subIndex < charBytes; subIndex += 2)
            {
                char[] subChars = { chars[subIndex], chars[subIndex + 1] };
                string subSig = new string(subChars);

                if (subSig == null)
                    continue;

                // Cache byte by index
                if (subSig.Equals("xx"))
                {
                    // Wild card
                    // C# uses unsigned bytes (0-255)
                    // So, to identify a wild card we'll use -1
                    bytes[index] = -1;
                }
                else
                {
                    // Convert 2 digit hex to int value 
                    bytes[index] = (byte)Int32.Parse(subSig, NumberStyles.HexNumber);
                }

                index++;
            }

            return bytes;
        }
    }
}
