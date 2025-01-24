using Developer_Helper_prism.Interface;
using Developer_Helper_prism.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper_prism.ViewModels
{
    internal class MenuViewModel : BindableBase
    {

        #region [Property]
        private readonly IRegionManager _regionManager;
        private IMenuModel _menuModel;

        private ObservableCollection<IMenuModel> _menuCollection;
        /// <summary>
        /// menuCollection
        /// </summary>
        public ObservableCollection<IMenuModel> MenuCollection
        {
            get { return _menuCollection; }
            set { SetProperty(ref _menuCollection, value); }
        }

        #endregion

        #region [Constructor]
        public MenuViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            init();
        }

        #endregion

        #region [Command]
        public DelegateCommand<string> NavigateCommand { get; private set; }

        #endregion

        #region [Mathod]
        private void init()
        {
            NavigateCommand = new DelegateCommand<string>(Navigate);

            MenuCollection =
            [
                new MenuModel { MenuName = "HomeView", MenuTitle = "Home", MenuTooltip = "Home", MenuDescription = "", MenuIcon = "/Core;component/Image/Icon/Home_icon.png" },
                new MenuModel { MenuName = "TableInfoView", MenuTitle = "Table", MenuTooltip = "Table", MenuDescription = "", MenuIcon = "/Core;component/Image/Icon/DBTable.png" },
                new MenuModel { MenuName = "SearchCommonCodeView", MenuTitle = "공통코드", MenuTooltip = "CommonCode", MenuDescription = "", MenuIcon = "/Core;component/Image/Icon/DBTable.png" },
                new MenuModel { MenuName = "SQLExcuteView", MenuTitle = "SQL", MenuTooltip = "SQL", MenuDescription = "", MenuIcon = "" },
                new MenuModel { MenuName = "SourceGeneratorView", MenuTitle = "SG", MenuTooltip = "SourceGenerator", MenuDescription = "", MenuIcon = "" },
                new MenuModel { MenuName = "DBSourceView", MenuTitle = "DBSource", MenuTooltip = "DBSource", MenuDescription = "", MenuIcon = "" },
                new MenuModel { MenuName = "EAMInfoView", MenuTitle = "EAM", MenuTooltip = "EAM", MenuDescription = "", MenuIcon = "" },
                new MenuModel { MenuName = "UserSettingLayOutView", MenuTitle = "Setting", MenuTooltip = "Setting", MenuDescription = "", MenuIcon = "/Core;component/Image/Icon/gnome-run.ico" },
            ];
        }

        /// <summary>
        /// menuClick Command Method
        /// </summary>
        /// <param name="menuName"></param>
        private void Navigate(string menuName)
        {
            _regionManager.RequestNavigate("ContentRegion", menuName);
        }
        #endregion
    }
}
