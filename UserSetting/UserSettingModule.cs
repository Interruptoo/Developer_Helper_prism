using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Diagnostics;
using UserSetting.Interface;
using UserSetting.Model;
using UserSetting.ViewModels;
using UserSetting.Views;

namespace UserSetting
{
    public class UserSettingModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<RegionManager>();

            regionManager.RegisterViewWithRegion("SettingMenuRegion", nameof(SettingMenuView));;
            regionManager.RegisterViewWithRegion("SettingContentRegion", nameof(CommonSettingView));;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<UserSettingLayOutView>();
            containerRegistry.RegisterForNavigation<SettingMenuView>();
            containerRegistry.RegisterForNavigation<CommonSettingView>();

            containerRegistry.Register<ISettingMenuModel, SettingMenuModel>();
        }
    }
}