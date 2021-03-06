﻿using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;
using TaskManagementInterface.Data.Models;
using TaskManagementInterface.Pages;

namespace TaskManagementInterface.Services.Types
{

    public class TypeServices
    {
        public HttpClient http = new HttpClient();

        //
        public async Task<List<tbl_TABLE_TYPE>> GetPossibleParents(string tableName,string uid)
        {
            return await http.GetJsonAsync<List<tbl_TABLE_TYPE>>("http://192.168.1.109/api/" + tableName + "/GetPossibleParents?uid=" + uid);
        }

        public async Task<List<tbl_TABLE_TYPE>> SelectAllActiveTypesByCategory(string _tablename,string uid)
        {
            string url = "http://192.168.1.109/api/" + _tablename + "/GetTypeByCategory?category_uid=" + uid;
            return await http.GetJsonAsync<List<tbl_TABLE_TYPE>>(url); 
        }

        public async Task<tbl_TABLE_TYPE> SelectRecById(string _tablename,string uid)
        {
            return (await http.GetJsonAsync<List<tbl_TABLE_TYPE>>("http://192.168.1.109/api/" + _tablename + "/" + uid)).FirstOrDefault();
        }

        public async Task<List<tbl_TABLE_CATEGORY>> SelectAllActiveRec(string _tablename)
        {
            return await http.GetJsonAsync<List<tbl_TABLE_CATEGORY>>("http://192.168.1.109/api/" + _tablename);
        }

      
        public async Task<tbl_TABLE_CATEGORY> SelectCurrentCageory(string table, string id)
        {
        http://192.168.1.109/api/tbl_EMPLOYEES_TYPE/GetTypeByCategory?category_uid=14

            return (await http.GetJsonAsync<List<tbl_TABLE_CATEGORY>>("http://192.168.1.109/api/"+table+"/" + id)).FirstOrDefault();
        }
        public async Task<Error> Add(tbl_TABLE_TYPE TypeModel, string tableName,string categoryId, string parameters)
        {

            string url = "http://192.168.1.109/api/" + tableName+"/Spi_TYPE2" +  "/" + TypeModel.code + "/" + TypeModel.nomination + "/" + categoryId + parameters;
            try
            {
              List<Error> list= await http.PostJsonAsync<List<Error>>(url,"");
                return list.FirstOrDefault();
            }
            catch (Exception ex)
            {
               Error error = new Error();
                error.ERRORDESCRIPTION = ex.ToString();
                return error;
            }
        }

        public async Task<Error> Update(tbl_TABLE_TYPE kategoriModel, string tableName, string parameters)
        {
            string url = "http://192.168.1.109/api/" + tableName + "/" + kategoriModel.uid + "/" + kategoriModel.elcat + "/" + kategoriModel.code + "/" + kategoriModel.nomination + parameters;
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
    }
}
