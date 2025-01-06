using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSetting.Interface;

namespace UserSetting.Model
{
    internal class SettingMenuModel : BindableBase, ISettingMenuModel
    {
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public string MenuIcon { get; set; }
        public string MenuTitle { get; set; }
        public string MenuTooltip { get; set; }
    }
}
