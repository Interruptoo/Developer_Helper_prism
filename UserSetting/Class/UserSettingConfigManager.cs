using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows;
using UserSetting.Model;



namespace UserSetting.Class
{
    public class UserSettingConfigManager
    {

        //private static readonly string ConfigPath = Path.Combine(
        //    Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName
        //    , "Config"
        //    , "UserSettingConfig.json"
        //    );
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


            try
            {
                var json = JsonSerializer.Serialize(config, options);
                File.WriteAllText(ConfigPath, json, Encoding.Default);

                MessageBox.Show("저장완료", "사용자정보 저장", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "사용자정보 저장", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }

        }
    }
}
