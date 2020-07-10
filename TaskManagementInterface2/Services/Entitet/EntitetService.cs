using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;

namespace TaskManagementInterface.Services.Entitet
{
    public class EntitetService
    {
        public HttpClient http = new HttpClient();

        public async Task<List<tbl_TABLE_Model>> SelectEntities()
        {
          return  await http.GetJsonAsync<List<tbl_TABLE_Model>>("http://192.168.1.109/GetAll_Entities");
        }
    }
}
