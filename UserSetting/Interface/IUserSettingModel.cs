using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSetting.Interface
{
    internal interface IUserSettingModel
    {
        string Code { get; set; }
        string Property { get; set; }
        string Value { get; set; }
        string Remark { get; set; }
    }
}
