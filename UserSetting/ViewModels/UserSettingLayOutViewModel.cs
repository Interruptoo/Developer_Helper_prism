using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UserSetting.Views;

namespace UserSetting.ViewModels
{
    internal class UserSettingLayOutViewModel : BindableBase
    {
        #region [Property]
        protected readonly IRegionManager _regionManager;
        #endregion

        #region [Constructor]
        public UserSettingLayOutViewModel(IRegionManager regionManager)
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
            

            
        }

        #endregion
    }
}
