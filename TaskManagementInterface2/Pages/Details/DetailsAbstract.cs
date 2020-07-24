using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementInterface.Data.Models.Info;
using TaskManagementInterface.Services.Info;

namespace TaskManagementInterface.Pages.Details
{
    public abstract class DetailsAbstract : DetailsInterface
    {
        InfoServices _infoServices = new InfoServices();
        List<SelectInfo_Model> dataInfo = new List<SelectInfo_Model>();
        public  async Task<string> GetValue(string Entity, string ElementID, string TypeInfoID)
        {
            //ne baze te entity dhe element id dhe type info id do duhet te maresh vleren eshte njesoj per te gjitha 
        
           dataInfo = await _infoServices.SelectEntitiesInfo(Entity, ElementID, TypeInfoID);
           return "";
           
            
            
        }

        public abstract bool Save(string Entity, string ElementID, string TypeID, string Value);
       
    }
}
