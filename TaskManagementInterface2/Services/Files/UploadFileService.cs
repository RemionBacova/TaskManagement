using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;

namespace TaskManagementInterface.Services.Files
{
    public class UploadFileService
    {
        public HttpClient http = new HttpClient();

        public async Task AddInfoAsync([FromForm(Name = "files")] List<Syncfusion.Blazor.Inputs.Internal.UploadFiles> files, string Entity, string ElementID, string TypeInfoID)
        {

            string url = "http://192.168.1.109:81/api/File/upload?entity="+Entity+ "&elementID=" + ElementID + "&typeinfoID="+TypeInfoID;

            
           await http.PostJsonAsync(url,"");

            //try
            //{
            //    List<Error> list = await http.PostJsonAsync<List<Error>>(url, "");
            //    return list.FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    Error error = new Error();
            //    error.ERRORDESCRIPTION = ex.ToString();
            //    return error;
            //}
            
        }
    }
}
