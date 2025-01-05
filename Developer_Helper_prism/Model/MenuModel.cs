using Developer_Helper_prism.Interface;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Developer_Helper_prism.Model
{
    internal class MenuModel : BindableBase, IMenuModel
    {
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public string MenuIcon { get; set; }
        public string MenuTitle { get; set; }
        public string MenuTooltip { get; set; }
    }
}
