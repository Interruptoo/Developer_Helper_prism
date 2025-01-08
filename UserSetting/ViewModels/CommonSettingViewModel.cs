using Core.Themes;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSetting.ViewModels
{
    internal class CommonSettingViewModel : BindableBase
    {
        #region [Property]
        private string _selectedTheme = "2";
        public string SelectedTheme
        {
            get { return _selectedTheme; }
            set { SetProperty(ref _selectedTheme, value);
                ChangeTheme();
            }
        }
        #endregion

        #region [Constructor]
        public CommonSettingViewModel() 
        { 
        
        }
        #endregion

        #region [Command]

        #endregion

        #region [Method]
        private void ChangeTheme()
        {
            switch (SelectedTheme)
            {
                case "0":
                    ThemesController.SetTheme(ThemeType.DeepDark);
                    break;
                case "1":
                    ThemesController.SetTheme(ThemeType.SoftDark);
                    break;
                case "2":
                    ThemesController.SetTheme(ThemeType.DarkGreyTheme);
                    break;
                case "3":
                    ThemesController.SetTheme(ThemeType.GreyTheme);
                    break;
                case "4":
                    ThemesController.SetTheme(ThemeType.LightTheme);
                    break;
                case "5":
                    ThemesController.SetTheme(ThemeType.RedBlackTheme);
                    break;
            }
        }
        #endregion

    }
}
