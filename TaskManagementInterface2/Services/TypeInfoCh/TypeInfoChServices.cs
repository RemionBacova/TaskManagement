using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;
using TaskManagementInterface.Data.Models.Type_Info_Ch;

namespace TaskManagementInterface.Services.TypeInfoCh
{
    public class TypeInfoChServices
    {
        public HttpClient http = new HttpClient();
        public async Task<Error> Add(tbl_TABLE_TYPE_INFO_CH TypeModel, string tableName)
        {
            //Property duhet te plotesohet 
            string url = "http://192.168.1.109/api/" + tableName + "_CH/"+TypeModel.type_info_uid+"/" + TypeModel.nomination ;
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

        public async Task<Error> Update(tbl_TABLE_TYPE_INFO_CH Model, string tableName, string parameters)
        {
            string url = "http://192.168.1.109/api/" + tableName + "/" + Model.uid + "/" + 1 + "/" + Model.nomination + "/1" + parameters;
            try
            {
                List<Error> list = await http.PutJsonAsync<List<Error>>(url, "");
                return list.FirstOrDefault();

            }
            catch (Exception ex)
            {
                Error error = new Error();
                error.ERRORDESCRIPTION = ex.ToString();
                return error;

            }

        }
        public async Task<Error> Delete(string uid, string tableName)
        {
            Error errorMessage = new Error();
            string url = "http://192.168.1.109/api/" + tableName + "_CH/" + uid;
            try
            {
                var message = await http.DeleteAsync(url);
                List<Error> error = JsonConvert.DeserializeObject<List<Error>>(message.Content.ReadAsStringAsync().Result);
                return error.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Error error = new Error();
                error.ERRORDESCRIPTION = ex.ToString();
                return error;
            }

           
        }
        public async Task<tbl_TABLE_TYPE_INFO_CH> SelectRecByid(string _tablename, string uid)
        {
            return (await http.GetJsonAsync<List<tbl_TABLE_TYPE_INFO_CH>>("http://192.168.1.109/api/" + _tablename + "_CH/" + uid)).FirstOrDefault();


        }
        public async Task<List<tbl_TABLE_TYPE_INFO_CH>> SelectRecByTypeInfoUid(string _tablename, string uid)
        {
            return await http.GetJsonAsync<List<tbl_TABLE_TYPE_INFO_CH>>("http://192.168.1.109/api/" + _tablename + "_CH/GetByTypeUid?type_info_uid=" + uid);

      
        }
    }
}
