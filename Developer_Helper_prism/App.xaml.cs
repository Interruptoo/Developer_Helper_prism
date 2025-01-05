using Developer_Helper_prism.Interface;
using Developer_Helper_prism.Model;
using Developer_Helper_prism.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using TableInfo;

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

        //protected override void OnInitialized()
        //{
        //    base.OnInitialized();

        //    var regionManager = Container.Resolve<IRegionManager>();
        //    regionManager.RequestNavigate("ContentRegion", "TableInfoView");
        //}

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<TableInfoModule>();
        }
    }
}
