using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;
using TaskManagementInterface.Pages;

namespace TaskManagementInterface.Services.Categories
{

    public class CategoryServices
    {
        public HttpClient http = new HttpClient();

        //
        public async Task<List<tbl_TABLE_CATEGORY>> GetPossibleParents(string tableName,string uid)
        {
            return await http.GetJsonAsync<List<tbl_TABLE_CATEGORY>>("http://192.168.1.109/api/" + tableName + "/GetPossibleParents?uid=" + uid);
        }

        public async Task<List<tbl_TABLE_CATEGORY>> SelectAllActiveRecById(string _tablename,string uid)
        {
            return await http.GetJsonAsync<List<tbl_TABLE_CATEGORY>>("http://192.168.1.109/api/" + _tablename + "/" + uid); 
        }

        public async Task<List<tbl_TABLE_CATEGORY>> SelectAllActiveRec(string _tablename)
        {
            return await http.GetJsonAsync<List<tbl_TABLE_CATEGORY>>("http://192.168.1.109/api/" + _tablename);
        }
        public async Task<Error> Add(tbl_TABLE_CATEGORY kategoriModel, string tableName, string parameters)
        {

            string url = "http://192.168.1.109/api/" + tableName +   "/"  + kategoriModel.code + "/" + kategoriModel.nomination + parameters;
            try
            {
              List<Error> list= await http.PostJsonAsync<List<Error>>(url,"");
                return list.FirstOrDefault();
            }
            catch (Exception ex)
            {
               Error error = new Error();
                error.ERRORNAME = ex.ToString();
                return error;
            }
        }

        public async Task<Error> Update(tbl_TABLE_CATEGORY kategoriModel, string tableName, string parameters)
        {
            string url = "http://192.168.1.109/api/" + tableName + "/" + kategoriModel.uid + "/" + kategoriModel.code + "/" + kategoriModel.nomination + parameters;
            try
            {
                List<Error> list = await http.PutJsonAsync<List<Error>>(url, "");
                return list.FirstOrDefault();

            }
            catch (Exception ex)
            {
                Error error = new Error();
                error.ERRORNAME = ex.ToString();
                return error;

            }

        }
        public async Task<Error> DeleteCategory(string uid, string tableName)
        {
            Error errorMessage = new Error();
            string url = "http://192.168.1.109/api/" + tableName + "/" + uid;
            try
            {
                var message= await http.DeleteAsync(url);
                List<Error> error = JsonConvert.DeserializeObject<List<Error>>(message.Content.ReadAsStringAsync().Result);
                return error.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Error error = new Error();
                error.ERRORNAME = ex.ToString();
                return error;
            }
        }
    }
}
