using System;
using System.Collections.Generic;

namespace WebApiTaskManagement.Models
{
    public partial class MachineReporting
    {

        public string ProcessName { get; set; }
        public string ApplicationName { get; set; }
        public int TotalSeconds { get; set; }
        
        public string MachineHash { get; set; }
    }
}
