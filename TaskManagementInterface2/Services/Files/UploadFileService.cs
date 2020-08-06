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
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TaskManagementInterface.Data;

namespace TaskManagementInterface.Services.Files
{
    public class UploadFileService
    {
        public HttpClient http = new HttpClient();

        public async Task AddInfoAsync([FromForm(Name = "files")] List<Syncfusion.Blazor.Inputs.Internal.UploadFiles> files, string Entity, string ElementID, string TypeInfoID)
        {
            string urla = "http://192.168.1.109:81/api/File/upload?entity=" + Entity + "&elementID=" + ElementID + "&typeinfoID=" + TypeInfoID;
            try
            {
                var file = files[0];
                var ms = file.Stream;

                var content = new MultipartFormDataContent {
                { new ByteArrayContent(ms.GetBuffer()), "\"upload\"", file.FileInfo.Name }
            };
                await http.PostAsync(urla, content);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
