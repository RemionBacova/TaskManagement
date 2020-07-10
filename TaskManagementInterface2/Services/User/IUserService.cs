using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementInterface.Data;

namespace TaskManagementInterface.Data
{
    interface IUserService
    {
        public Task LoginAsync(Users_Model user);
        public Task ChangePassAsync(ChangePass pass);

    }
}
