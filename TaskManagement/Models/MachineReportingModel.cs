using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Models
{
    class MachineReportingModel
    {
        public string ProcessName { get; set; }
        public string ApplicationName { get; set; }
        public int TotalSeconds { get; set; }

        public string MachineHash { get; set; }
    }
}
