using Developer_Helper_prism.Themes;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;

namespace Developer_Helper_prism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region [Const]

        #endregion

        #region [Property]
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _themeSelect;
        public bool ThemeSelect
        {
            get { return _themeSelect; }
            set { SetProperty(ref _themeSelect, value); }
        }
        #endregion

        #region [Command]
        public DelegateCommand ThemeClickCommand { get;}
        #endregion

        #region [Constructor]
        public MainWindowViewModel()
        {
            ThemeClickCommand = new DelegateCommand(ChangeTheme);
        }

        #endregion

        #region [Method]
        private void ChangeTheme()
        {
            //switch (Mode)
            //{
            //    case "0":
            //        ThemesController.SetTheme(ThemeType.DeepDark);
            //        break;
            //    case "1":
            //        ThemesController.SetTheme(ThemeType.SoftDark);
            //        break;
            //    case "2":
            //        ThemesController.SetTheme(ThemeType.DarkGreyTheme);
            //        break;
            //    case "3":
            //        ThemesController.SetTheme(ThemeType.GreyTheme);
            //        break;
            //    case "4":
            //        ThemesController.SetTheme(ThemeType.LightTheme);
            //        break;
            //    case "5":
            //        ThemesController.SetTheme(ThemeType.RedBlackTheme);
            //        break;
            //}

            if(ThemeSelect)
                ThemesController.SetTheme(ThemeType.LightTheme);
            else
                ThemesController.SetTheme(ThemeType.DeepDark);
        }
        #endregion
    }
}
