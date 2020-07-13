using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Concrete
{
    public class Type
    {
        [PrimaryKey]
        [AutoIncrement]
        public int UID { get; set; }
        public string? Name { get; set; }
        public bool? Bit { get; set; }
    }
}
