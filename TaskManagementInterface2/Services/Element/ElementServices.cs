using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;
using TaskManagementInterface.Data.ELEMENT;
using TaskManagementInterface.Data.Models;

namespace TaskManagementInterface.Services.Element
{
    public class ElementServices
    {
        public HttpClient http = new HttpClient();
        public async Task<List<tbl_Element>> SelectAllActiveRec(string categoryUID, string table)
        {
            return await http.GetJsonAsync<List<tbl_Element>>("http://192.168.1.109/api/tbl_" + table + "/SelectAllwithType?category=" + categoryUID);
        }
        //http://192.168.1.109/api/tbl_EMPLOYEES/10
        public async Task<tbl_Element> SelectRecordById(string ElementUid, string table)
        {
            return (await http.GetJsonAsync<List<tbl_Element>>("http://192.168.1.109/api/tbl_" + table + "/" + ElementUid)).FirstOrDefault();
        }
        public async Task<List<tbl_TABLE_CATEGORY>> SelectAllActiveRecCategory(string table)
        {
            return await http.GetJsonAsync<List<tbl_TABLE_CATEGORY>>("http://192.168.1.109/api/tbl_" + table + "_CATEGORY");
        }
        public async Task<List<tbl_TABLE_TYPE>> SelectAllActiveTypesByCategory(string _tablename, string uid)
        {
            string url = "http://192.168.1.109/api/tbl_" + _tablename + "_Type/GetTypeByCategory?category_uid=" + uid;
            return await http.GetJsonAsync<List<tbl_TABLE_TYPE>>(url);
        }
        public async Task<tbl_TABLE_TYPE> SelectTypeById(string _tablename, string uid)
        {
            return (await http.GetJsonAsync<List<tbl_TABLE_TYPE>>("http://192.168.1.109/api/tbl_" + _tablename + "_Type/" + uid)).FirstOrDefault();
        }
        public async Task<Error> Add(tbl_Element Model, string tableName, string parameters)
        {
            string url = "http://192.168.1.109/api/tbl_" + tableName + "/" + Model.type_uid + "/" + Model.nomination + "/" + Model.category + parameters;
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

        public async Task<Error> Update(tbl_Element Model, string tableName, string parameters)
        {
            string url = "http://192.168.1.109/api/tbl_" + tableName + "/" + Model.uid + "/" + Model.type_uid + "/" + Model.nomination + "/" + Model.category + parameters;
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

        public async Task<Error> DeleteElement(string uid, string tableName)
        {
            Error errorMessage = new Error();
            string url = "http://192.168.1.109/api/tbl_" + tableName + "/" + uid;
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

      
    }
}
