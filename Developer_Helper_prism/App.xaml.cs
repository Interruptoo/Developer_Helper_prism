using Core.Class;
using Core.Themes;
using Developer_Helper_prism.Interface;
using Developer_Helper_prism.Model;
using Developer_Helper_prism.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Configuration;
using System.Windows;
using TableInfo;
using UserSetting;
using UserSetting.ViewModels;

namespace Developer_Helper_prism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", "HomeView");
            regionManager.RequestNavigate("LeftMenuRegion", "MenuView");

            var ThemeName = ConfigurationManager.AppSettings["ThemeName"] ?? "DarkGrey";

            var Theme = new CommonSettingViewModel();

            Theme.ChangeTheme(ThemeName);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MenuView>();
            containerRegistry.RegisterForNavigation<HomeView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<TableInfoModule>();
            moduleCatalog.AddModule<UserSettingModule>();
        }
    }
}
