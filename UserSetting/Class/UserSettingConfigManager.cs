using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using UserSetting.Model;

namespace UserSetting.Class
{
    internal class UserSettingConfigManager
    {
        private static readonly string ConfigPath = Path.Combine(
            Directory.GetCurrentDirectory(), "Config", "UserSettingConfig.json"
        );

        public List<UserSettingModel> LoadConfig()
        {
            if (File.Exists(ConfigPath))
            {
                var json = File.ReadAllText(ConfigPath);
                return JsonSerializer.Deserialize<List<UserSettingModel>>(json) ?? new List<UserSettingModel>();
            }

            return new List<UserSettingModel>();
        }

        public void SaveConfig(List<UserSettingModel> config)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.HangulSyllables),
                WriteIndented = true,
            };

            var json = JsonSerializer.Serialize(config, options);
            File.WriteAllText(ConfigPath, json, Encoding.Default);
        }
    }
}
