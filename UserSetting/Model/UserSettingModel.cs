using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSetting.Interface;

namespace UserSetting.Model
{
    internal class UserSettingModel : BindableBase, IUserSettingModel
    {
        public string Code { get; set; }
        public string Property {  get; set; }
        public string Value { get; set; }
        public string Remark { get; set; }

    }
}
