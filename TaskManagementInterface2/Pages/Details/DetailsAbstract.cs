using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementInterface.Data;
using TaskManagementInterface.Data.Models.Info;
using TaskManagementInterface.Services.Info;

namespace TaskManagementInterface.Pages.Details
{
    public abstract class DetailsAbstract : ComponentBase,DetailsInterface
    {
        public string stringValue = "";
        InfoServices _infoServices = new InfoServices();
        List<SelectInfo_Model> dataInfo = new List<SelectInfo_Model>();
        List<tbl_TABLE_INFO> saveInfo = new List<tbl_TABLE_INFO>();
        public  async Task<SelectInfo_Model> GetValue(string Entity, string ElementID, string TypeInfoID)
        {
        
            dataInfo = await _infoServices.SelectEntitiesInfo(Entity, ElementID, TypeInfoID);
            return dataInfo.FirstOrDefault();

        }

        public async Task<Error> Save(string Entity, string ElementID, string TypeID, string Value)
        {
            return await _infoServices.AddInfo(Entity, ElementID, TypeID, stringValue);
        }
    }
}
