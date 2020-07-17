using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;
using TaskManagementInterface.Data.Models;
using TaskManagementInterface.Data.Models.Type;

namespace TaskManagementInterface.Services.TypeInfo
{
    public class TypeInfoServices
    {
        public HttpClient http = new HttpClient();

        public async Task<List<tbl_TABLE_TYPE>> SelectAllActiveTypesByCategory(string _tablename, string uid)
        {

            return await http.GetJsonAsync<List<tbl_TABLE_TYPE>>("http://192.168.1.109/api/" + _tablename + "/GetTypeByCategory?category_uid=" + uid);
        }
        public async Task<List<tbl_TABLE_TYPE_INFO>> SelectAllActiveRecByType(string tableName,string uid)
        {
            return await http.GetJsonAsync<List<tbl_TABLE_TYPE_INFO>>("http://192.168.1.109/api/" + tableName + "/GetByType?TYPE_UID=" + uid);

        }
        public async Task<tbl_TABLE_TYPE> SelectCurrentType(string table, string id)
        {
            return (await http.GetJsonAsync<List<tbl_TABLE_TYPE>>("http://192.168.1.109/api/" + table + "/" + id)).FirstOrDefault();
        }




        public async Task<Error> Add(tbl_TABLE_TYPE_INFO TypeModel, string tableName, string parameters)
        {
            //Property duhet te plotesohet 
            string url = "http://192.168.1.109/api/" + tableName +  "/" + TypeModel.nomination + "/1"  + parameters;
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

        public async Task<Error> Update(tbl_TABLE_TYPE_INFO kategoriModel, string tableName, string parameters)
        {
            string url = "http://192.168.1.109/api/" + tableName + "/" + kategoriModel.uid+"/"+1 + "/" + kategoriModel.nomination+ "/1"+ parameters;
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
            string url = "http://192.168.1.109/api/" + tableName + "/" + uid;
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


        public async Task<tbl_TABLE_TYPE_INFO> SelectRecById(string _tablename, string uid)
        {
            return (await http.GetJsonAsync<List<tbl_TABLE_TYPE_INFO>>("http://192.168.1.109/api/" + _tablename + "/" + uid)).FirstOrDefault();
        }


        public async Task<List<GetTypes>> SelectTypes()
        {
            return await http.GetJsonAsync<List<GetTypes>>("http://192.168.1.109/GetAll_Types");
        }

    }
}