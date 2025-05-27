using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace networkDeviceApp
{
   public static class JsonManager
    {
        private static readonly string FileJson = "devices.json";

        public static void SaveToJson(List<Device> devices)
        {
            string json = JsonSerializer.Serialize(devices, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FileJson, json);
        }

        public static List<Device> LoadFromJson()
        {
            if (!File.Exists(FileJson)) return new List<Device>();

            string json = File.ReadAllText(FileJson);
            return JsonSerializer.Deserialize<List<Device>>(json) ?? new List<Device>();
        }

    }
}
