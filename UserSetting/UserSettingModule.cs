using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Diagnostics;
using UserSetting.ViewModels;
using UserSetting.Views;

namespace UserSetting
{
    public class UserSettingModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<UserSettingLayOutView>();
            containerRegistry.RegisterForNavigation<SettingMenuView>();
        }
    }
}