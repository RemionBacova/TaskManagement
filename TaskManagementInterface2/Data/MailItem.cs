using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementInterface.Data
{
    public class MailItem
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string ElementName { get; set; }
        public bool Expanded { get; set; }
        public bool HasSubFolders { get; set; }
    }
}
