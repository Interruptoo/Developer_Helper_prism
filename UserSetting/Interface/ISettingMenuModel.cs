using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSetting.Interface
{
    internal interface ISettingMenuModel
    {
        string MenuName { get; set; }
        string MenuDescription { get; set; }
        string MenuIcon { get; set; }
        string MenuTitle { get; set; }
        string MenuTooltip { get; set; }
    }
}
