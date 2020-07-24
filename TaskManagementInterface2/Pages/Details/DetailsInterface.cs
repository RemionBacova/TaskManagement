using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementInterface.Data.Models.Info;

namespace TaskManagementInterface.Pages.Details
{
     interface DetailsInterface
    {
        public bool Save(string Entity, string ElementID, string TypeID, string Value);

        public Task<string> GetValue(string Entity, string ElementID, string TypeInfoID);
    }
}
