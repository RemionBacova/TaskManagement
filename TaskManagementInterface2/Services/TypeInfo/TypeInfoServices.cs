using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;
using TaskManagementInterface.Data.Models;

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

    }
}