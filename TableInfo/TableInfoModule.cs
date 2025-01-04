using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TableInfo.ViewModels;
using TableInfo.Views;

namespace TableInfo
{
    public class TableInfoModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TableInfoView>();
        }
    }
}