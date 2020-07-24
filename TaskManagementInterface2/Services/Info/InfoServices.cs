using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;
using TaskManagementInterface.Data.Models.Info;

namespace TaskManagementInterface.Services.Info
{
    public class InfoServices
    {

        public HttpClient http = new HttpClient();

        public async Task<List<SelectInfo_Model>> SelectEntitiesInfo(string Entity, string ElementID, string TypeInfoID)
        {
            return await http.GetJsonAsync<List<SelectInfo_Model>>("http://192.168.1.109/api/tbl_"+ Entity + "_INFO/SelectAllActiveRecWith_Element_TypeInfo?elementUid="+ ElementID + "&typeinfoUid="+ TypeInfoID);
        }
    }
}
