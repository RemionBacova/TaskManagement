using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagemenk.Repository.Base.EntitiesRepository;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers.Abstract.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class tbl_TABLE_CATEGORY_ControllerAbstract : ControllerBase
    {
        private sp_tbl_TABLE_CATEGORY_Repository _repository;
        private string tableName="";
        public tbl_TABLE_CATEGORY_ControllerAbstract(sp_tbl_TABLE_CATEGORY_Repository repository, string tableName)
        {
            this._repository = repository;
            this.tableName = tableName;

        }

        [HttpPost]
        public async Task spi_Kateogria([FromBody] tbl_TABLE_CATEGORY_Model modelName)
        {
            await _repository.spi_Kateogria(modelName, tableName);
        }

        [HttpPut("{UID}")]
        public async Task spu_Kateogria([FromBody] tbl_TABLE_CATEGORY_Model modelName)
        {
            await _repository.spu_Kateogria(modelName, tableName);
        }

        [HttpGet]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectAllActiveRec()
        {
            return await _repository.SelectAllActiveRec(tableName);

        }

        [HttpGet("{UID}")]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectAllActiveRecByUID( string UID)
        {
            return await _repository.SelectAllActiveRecByUID(tableName, UID);

        }

        [HttpDelete("{UID}")]
        public async Task<Boolean> DeleteRow( string UID)
        {
            return await _repository.DeleteRow(tableName, UID);

        }

        [HttpGet("GetByParameters")]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectAllActiveRecBySup(string? uid_sup, string? active, string? nomination, string? description)
        {
            return await _repository.SelectAllActiveRecBySup(tableName, uid_sup, active, nomination, description);

        }


    }
}

