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
    public class tbl_INTER_TABLE_TABLEController : ControllerBase
    {
        private sp_tbl_INTER_TABLE_TABLE_Repository _repository;

        public tbl_INTER_TABLE_TABLEController(sp_tbl_INTER_TABLE_TABLE_Repository repository)
        {
            this._repository = repository;

        }

        [HttpPost]
        public async Task spi_nder_table_table(string? table1_name, string? table2_name, int? table1_uid,
            int? table2_uid, int? users_uid)
        {
            await _repository.spi_nder_table_table(table1_name, table2_name, table1_uid, table2_uid, users_uid);
        }


        [HttpDelete("{tableName1}/{tableName2}/{UID}")]
        public async Task<Boolean> DeleteRow(string UID, string? tableName1, string? tableName2)
        {
            return await _repository.DeleteRow(tableName1, tableName2, UID);

        }

        [HttpGet("{table1}/{table2}")]
        public async Task<IEnumerable<tbl_INTER_TABLE_TABLE>> SelectConnections(string? table1, string? table2)
        {
            return await _repository.SelectConnections(table1, table2);
        }


        [HttpGet("{table1}/{table2}/{table1_uid}")]
        public async Task<IEnumerable<tbl_INTER_TABLE_TABLE>> SelectAllActiveConnections_TABLE1_TABLE2_Table1_UID(string? table1, string? table2, int? table1_uid)
        {
            return await _repository.SelectAllActiveConnections_TABLE1_TABLE2_Table1_UID(table1, table2, table1_uid);
        }

        [HttpGet("{table1}/{table2}/{table2_uid}")]
        public async Task<IEnumerable<tbl_INTER_TABLE_TABLE>> SelectAllActiveConnections_TABLE1_TABLE2_Table2_UID(string? table1, string? table2, int? table2_uid)
        {
            return await _repository.SelectAllActiveConnections_TABLE1_TABLE2_Table2_UID(table1, table2, table2_uid);
        }
    
    }
}

