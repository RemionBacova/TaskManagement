using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.LoginModels
{
    public class ChangePassword
    {
        public string username { get; set; }
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
