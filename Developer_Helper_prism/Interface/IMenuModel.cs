using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper_prism.Interface
{
    public interface IMenuModel
    {
        string MenuName { get; set; }
        string MenuDescription { get; set; }
        string MenuIcon { get; set; }
        string MenuTitle { get; set; }
        string MenuTooltip { get; set; }
    }
}
