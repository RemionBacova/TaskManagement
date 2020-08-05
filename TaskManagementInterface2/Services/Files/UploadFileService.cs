using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;

namespace TaskManagementInterface.Services.Files
{
    public class UploadFileService
    {
        public HttpClient http = new HttpClient();

        public async Task<Error> AddInfo(string Entity, string ElementID, string TypeInfoID)
        {

            string url = "http://192.168.1.109:81/api/File/upload?entity="+Entity+ "&elementID=" + ElementID + "&typeinfoID="+TypeInfoID;

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
