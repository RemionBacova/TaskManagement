using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Repository;
using WebApiTaskManagement.Models;

namespace WebApiTaskManagement.Controllers
{
    public class tbl_ENTITIESController
    {
        private tbl_ENTITIES_Repository _repository;

        public tbl_ENTITIESController(tbl_ENTITIES_Repository repository)
        {
            this._repository = repository;

        }

        [HttpGet("GetAll_Entities")]
        public async Task<IEnumerable<tbl_Entities_Model>> SelectConnections()
        {
            return await _repository.SelectEntitites();
        }
    }
}
