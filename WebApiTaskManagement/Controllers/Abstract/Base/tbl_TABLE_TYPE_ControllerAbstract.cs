using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Repository.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers.Abstract.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class tbl_TABLE_TYPE_ControllerAbstract : ControllerBase
    {
        private sp_tbl_TABLE_TYPE_Repository _repository;
        private string tableName="";

        public tbl_TABLE_TYPE_ControllerAbstract(sp_tbl_TABLE_TYPE_Repository repository, string tableName)
        {
            _repository = repository;
            this.tableName = tableName;
        }
        [HttpPost]
        public async Task spi_Tip([FromBody] tbl_TABLE_TYPE_Model modelName)
        {
            await _repository.spi_Tipi(modelName, tableName);
        }

        [HttpPut]
        public async Task spu_Tip([FromBody] tbl_TABLE_TYPE_Model modelName)
        {
            await _repository.spu_tipi(modelName, tableName);
        }

        [HttpGet]
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectAllActiveRec()
        {
            return await _repository.SelectAllActiveRec(tableName);

        }

        [HttpGet("{UID}")]
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectActiveRecByUID(string UID)
        {
            return await _repository.SelectActiveRecByUID(tableName, UID);

        }

        [HttpDelete("{UID}")]
        public async Task<Boolean> DeleteRow(string UID)
        {
            return await _repository.DeleteRow(tableName, UID);

        }

        [HttpGet("GetByParameters")]
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectActiveRecByParameters(string tableName, string? uid_sup, string? nomination, string? description)
        {
            return await _repository.SelectActiveRecByParameters(tableName, uid_sup, nomination, description);

        }

    }
}
