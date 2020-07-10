using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;


namespace WebApiTaskManagement.Models
{
    public partial class Machines
    {
        public string MachineName { get; set; }
        public string Osversion { get; set; }
        public string UserDomainName { get; set; }
        public string UserName { get; set; }
        public string Version { get; set; }
        public string MachineHash { get; set; }
    }

    public partial class Machines1
    {
        public int UID { get; set; }
        public string MachineName { get; set; }
       
    }

}
