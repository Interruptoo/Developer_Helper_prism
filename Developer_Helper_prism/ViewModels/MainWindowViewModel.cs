using Developer_Helper_prism.Themes;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
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
        #endregion

        #region [Command]

        public DelegateCommand<string> NavigateCommand { get; private set; }
        #endregion

        #region [Constructor]
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        #endregion

        #region [Method]
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
