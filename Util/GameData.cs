

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using static System.Text.Json.JsonElement;

namespace MemoryManipulator.Util
{
    class GameData
    {

        // Cached data from file
        private static Dictionary<int, string> itemTypeNames = new Dictionary<int, string>();

        private static Dictionary<int, string> npcTypeNames = new Dictionary<int, string>();

        // Get name from cache by type id
        public static string GetName(int typeID, bool item)
        {
            try
            {
                return item ? itemTypeNames[typeID] : npcTypeNames[typeID];
            }
            catch (KeyNotFoundException)
            {
                return "NULL";
            }
        }

        // Parse file into memory
        public static void Load(string path, bool items)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            string dir = Directory.GetCurrentDirectory();

            string jsonFilePath = dir + path;
            string jsonAsText = File.ReadAllText(jsonFilePath);

            JsonDocument doc = JsonDocument.Parse(jsonAsText);
            JsonElement root = doc.RootElement;

            ArrayEnumerator iterator = root.EnumerateArray();

            while (iterator.MoveNext())
            {
                ObjectEnumerator props = iterator.Current.EnumerateObject();
                int typeID = -1;

                while (props.MoveNext())
                {
                    JsonProperty prop = props.Current;
                    string name = prop.Name.Trim(), value = prop.Value.ToString();

                    if (name.Equals("id"))
                    {
                        // First prop is id - cache for next loop to read name
                        int.TryParse(value, out typeID);
                        continue;
                    }
                    else if (name.Equals("name"))
                    {
                        // Second prop, is item name - that's all we need cache and move on
                        if (items)
                            itemTypeNames.Add(typeID, value);
                        else
                            npcTypeNames.Add(typeID, value);
                    }
                    break;
                }
            }
        }

    }
}
