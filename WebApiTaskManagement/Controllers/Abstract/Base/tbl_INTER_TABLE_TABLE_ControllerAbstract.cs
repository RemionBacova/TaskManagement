using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers.Abstract
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_INTER_TABLE_TABLE_Controller : ControllerBase
    {
        private sp_tbl_INTER_TABLE_TABLE_Repository _repository;
        private string tableName1 = "";
        private string tableName2 = "";
        public tbl_INTER_TABLE_TABLE_Controller(sp_tbl_INTER_TABLE_TABLE_Repository repository, string tableName1,string tableName2)
        {
            this._repository = repository;
            this.tableName1 = tableName1;
            this.tableName2 = tableName2;
        }

        [HttpPost]
        public async Task spi_nder_table_table(tbl_INTER_TABLE_TABLE m)
        {
            await _repository.spi_nder_table_table(m);
        }
    }
}
