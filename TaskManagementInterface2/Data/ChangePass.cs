using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementInterface.Data
{
    public class ChangePass
    {
        public string username { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
