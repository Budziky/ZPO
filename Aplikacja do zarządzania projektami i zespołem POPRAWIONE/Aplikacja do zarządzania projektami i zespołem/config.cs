using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    public class config
    {
        private static config? _instance;
        private static readonly object _lock = new();
        public string AppName { get; set; } = "Aplikacja do zarządzania projektami i zespołem";

        private config() { }

        public static config Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new config();
                }
            }
        }

        public void SaveConfig(string filePath)
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true }));
        }

        public static void LoadConfig(string filePath)
        {
            if (File.Exists(filePath))
            {
                _instance = JsonSerializer.Deserialize<config>(File.ReadAllText(filePath)) ?? new config();
            }
        }
    }
}
