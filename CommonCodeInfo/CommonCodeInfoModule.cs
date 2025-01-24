using CommonCodeInfo.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace CommonCodeInfo
{
    public class CommonCodeInfoModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SearchCommonCodeView>();
        }
    }
}