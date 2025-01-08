using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UserSetting.Interface;
using UserSetting.Model;

namespace UserSetting.ViewModels
{
    internal class SettingMenuViewModel : BindableBase
    {
        
        #region [Property]
        protected readonly IRegionManager _regionManager;
        private protected readonly ISettingMenuModel _settingMenuModel;

        private ObservableCollection<ISettingMenuModel> _menuCollection;
        /// <summary>
        /// menuCollection
        /// </summary>
        public ObservableCollection<ISettingMenuModel> MenuCollection
        {
            get { return _menuCollection; }
            set { SetProperty(ref _menuCollection, value); }
        }

        #endregion

        #region [Constructor]
        public SettingMenuViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            init();
        }
        #endregion


        #region [Command]

        #endregion


        #region [Mathod]
        private void init()
        {

            MenuCollection =
            [
                new SettingMenuModel() { MenuName = "CommonSettingView", MenuTitle = "Common", MenuDescription = "기본환경설정", MenuTooltip = "", MenuIcon = "/Core;component/Image/Icon/gnome-run.ico" },
                new SettingMenuModel() { MenuName = "DBConnectionView", MenuTitle = "DBConnection", MenuDescription = "DB연결", MenuTooltip = "", MenuIcon = "/Core;component/Image/Icon/DBTable.png" }
            ];

        }
        #endregion

    }
}
