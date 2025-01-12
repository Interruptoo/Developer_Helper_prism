using Markdig.Wpf;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper_prism.ViewModels
{
    internal class HomeViewModel : BindableBase
    {
        #region [Property]
        private string _markdownContent;
        public string MarkdownContent
        {
            get { return _markdownContent; }
            set { SetProperty(ref _markdownContent, value); }
        }

        #endregion

        #region [Constructor]
        public HomeViewModel() 
        {
            try
            {
                MarkdownContent = File.ReadAllText("README.md");


            }
            catch(Exception ex)
            {
                MarkdownContent = "파일을 찾을 수 없습니다.";
            }
            
        }
        #endregion

        #region [Command]

        #endregion

        #region [Method]

        #endregion
    }
}
