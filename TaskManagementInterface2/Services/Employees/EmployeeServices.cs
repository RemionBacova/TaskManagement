using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data.EMPLOYEES;

namespace TaskManagementInterface.Services.Employees
{
    public class EmployeeServices
    {
        public HttpClient http = new HttpClient();
        public async Task<List<tbl_Employee>> SelectAllActiveRec()
        {
            return await http.GetJsonAsync<List<tbl_Employee>>("http://192.168.1.109/api/tbl_EMPLOYEES");
        }
    }
}
