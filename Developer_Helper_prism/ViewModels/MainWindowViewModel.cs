using Developer_Helper_prism.Interface;
using Developer_Helper_prism.Model;
using Developer_Helper_prism.Themes;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;
using System.Windows.Input;

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

        #region [Command]

        public DelegateCommand<string> NavigateCommand { get; private set; }
        #endregion

        #region [Constructor]
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);


            init();
        }

        #endregion

        #region [Method]
        /// <summary>
        /// 초기화
        /// </summary>
        private void init()
        {
            MenuCollection =
            [
                new MenuModel { MenuName = "TableInfoView", MenuTitle = "Table", MenuDescription = "", MenuIcon = "/Developer_Helper_prism;component/Image/Icon/DBTable.png" },
                new MenuModel { MenuName = "SQLExcuteView", MenuTitle = "SQL", MenuDescription = "", MenuIcon = "" },
                new MenuModel { MenuName = "SourceGeneratorView", MenuTitle = "SourceGenerator", MenuDescription = "", MenuIcon = "" },
                new MenuModel { MenuName = "DBSourceView", MenuTitle = "EQS/DBSource", MenuDescription = "", MenuIcon = "" },
                new MenuModel { MenuName = "EAMInfoView", MenuTitle = "EAM", MenuDescription = "", MenuIcon = "" },
                new MenuModel { MenuName = "SettingView", MenuTitle = "Setting", MenuDescription = "", MenuIcon = "/Developer_Helper_prism;component/Image/Icon/gnome-run.ico" },
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
