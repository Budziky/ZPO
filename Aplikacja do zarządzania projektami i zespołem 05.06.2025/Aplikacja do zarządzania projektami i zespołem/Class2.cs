using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    public static class DataManager
    {
        private static string dataFile = "data.json";

        public static void SaveData(AppData appData)
        {
            File.WriteAllText(dataFile, JsonSerializer.Serialize(appData, new JsonSerializerOptions { WriteIndented = true }));
        }

        public static AppData LoadData()
        {
            if (!File.Exists(dataFile)) return new AppData();
            var json = File.ReadAllText(dataFile);
            return JsonSerializer.Deserialize<AppData>(json) ?? new AppData();
        }
    }
}
