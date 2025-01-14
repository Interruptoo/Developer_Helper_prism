using Core.Class;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UserSetting.ViewModels;

namespace Developer_Helper_prism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region [Const]

        #endregion

        #region [Property]
        private string _title = "Developer_Helper_Prism";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #endregion

        #region [Command]


        #endregion

        #region [Constructor]
        public MainWindowViewModel()
        {
            InitializeTheme();
        }

        #endregion

        #region [Method]
        private void InitializeTheme()
        {
            
        }
        #endregion
    }
}
