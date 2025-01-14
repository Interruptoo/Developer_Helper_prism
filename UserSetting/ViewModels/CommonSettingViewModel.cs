using Core.Class;
using Core.Themes;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using UserSetting.Class;
using UserSetting.Model;
using static System.Net.Mime.MediaTypeNames;

namespace UserSetting.ViewModels
{
    public class CommonSettingViewModel : BindableBase
    {
        #region [Property]
        private string _selectedTheme;
        public string SelectedTheme
        {
            get { return _selectedTheme; }
            set
            {
                SetProperty(ref _selectedTheme, value);
                SelectTheme(SelectedTheme);
            }
        }


        private ObservableCollection<UserSettingModel> _userSettingList;
        public ObservableCollection<UserSettingModel> UserSettingList
        {
            get { return this._userSettingList; }
            set { SetProperty(ref  this._userSettingList, value); }
        }

        private UserSettingConfigManager _configManager;
        private string themeNamet;
        #endregion

        #region [Constructor]
        public CommonSettingViewModel()
        {
            
            init();
        }
        #endregion

        #region [Command]
        public DelegateCommand UserSettingSaveCommand { get; private set; }
        #endregion

        #region [Method]
        private void init()
        {
            _configManager = new UserSettingConfigManager();

            UserSettingSaveCommand = new DelegateCommand(UserSettingSave);

            UserSettingList =
                [
                    new UserSettingModel {Code = "UserName", Property = "사용자이름", Value = "", Remark = "작업자" },
                    new UserSettingModel {Code = "MetaConnectionString",  Property = "Meta# Connection String", Value = "", Remark = "Meta#정보 연동을 위해 필요" },
                    new UserSettingModel {Code = "BESTCareDevPath", Property = "BestCare Dev경로", Value = "", Remark = "EAM탭에서 화면보기시 사용" },
                    new UserSettingModel {Code = "BESTCareStgPath", Property = "BestCare STG경로", Value = "", Remark = "EAM탭에서 화면보기시 사용" },
                    new UserSettingModel {Code = "BESTCareProdPath", Property = "BestCare Prod경로", Value = "", Remark = "EAM탭에서 화면보기시 사용" },
                    new UserSettingModel {Code = "GoldenPath", Property = "Golden 경로", Value = "", Remark = "EQS/DB Object 소스보기시 사용" },
                    new UserSettingModel {Code = "PLEditPath", Property = "PLEdit 경로", Value = "", Remark = "EQS/DB Object 소스보기시 사용" },
                    new UserSettingModel {Code = "ExcludeOwner", Property = "제외할 Table Owner", Value = "", Remark = "" },
                    new UserSettingModel {Code = "TFSServer", Property = "TFS Server URL", Value = "", Remark = "TFS Server URL" },
                    new UserSettingModel {Code = "TFSUserID", Property = "TFS User", Value = "", Remark = "TFS 사용자" },
                    new UserSettingModel {Code = "TFSPassword", Property = "TFS Password", Value = "", Remark = "TFS 비밀번호" },
                ];

            SelectedTheme = ConfigHelper.LoadConfig("ThemeName");
        }

        private void SelectTheme(string themeName)
        {
            ChangeTheme(themeName);

            SaveThemeConfig(themeName);
        }

        /// <summary>
        /// 테마값 Config 저장
        /// </summary>
        private void SaveThemeConfig(string p)
        {
            ConfigHelper.SaveConfig("ThemeName", p);
        }

        /// <summary>
        /// 테마변경
        /// </summary>
        public void ChangeTheme(string p)
        {
            switch (p)
            {
                case "DeepDark":
                    ThemesController.SetTheme(ThemeType.DeepDark);
                    break;
                case "SoftDark":
                    ThemesController.SetTheme(ThemeType.SoftDark);
                    break;
                case "DarkGrey":
                    ThemesController.SetTheme(ThemeType.DarkGreyTheme);
                    break;
                case "Grey":
                    ThemesController.SetTheme(ThemeType.GreyTheme);
                    break;
                case "Light":
                    ThemesController.SetTheme(ThemeType.LightTheme);
                    break;
                case "RedBlack":
                    ThemesController.SetTheme(ThemeType.RedBlackTheme);
                    break;
            }
        }

        private void UserSettingSave()
        {
            _configManager.SaveConfig(UserSettingList.ToList());
        }
        #endregion

    }
}
