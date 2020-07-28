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
        tbl_TABLE_INFO infoModel;
        public async Task<List<SelectInfo_Model>> SelectEntitiesInfo(string Entity, string ElementID, string TypeInfoID)
        {
            return await http.GetJsonAsync<List<SelectInfo_Model>>("http://192.168.1.109/api/tbl_"+ Entity + "_INFO/SelectAllActiveRecWith_Element_TypeInfo?elementUid="+ ElementID + "&typeinfoUid="+ TypeInfoID);
        }

        public async Task<Error> AddInfo(string Entity,string ElementID,string TypeInfoID,string Value)
        {
            infoModel.nomination = Value;

            string url = "http://192.168.1.109/api/" + Entity + "_INFO/" + ElementID + "/" + TypeInfoID + "/"+ Value;
            try
            {
                List<Error> list = await http.PostJsonAsync<List<Error>>(url, "");
                return list.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Error error = new Error();
                error.ERRORDESCRIPTION = ex.ToString();
                return error;
            }
        }



    }
}
