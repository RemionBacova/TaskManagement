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
        [HttpPost("{uid_sup}/{elcat}/{code}/{nomination}")]
        public async Task<IEnumerable<SelectError_Model>> spi_Tip(int? uid_sup, bool? elcat, string? code, string? codeend, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
        {
           return await _repository.spi_Tipi(tableName,uid_sup,elcat,code,codeend,nomination,description,description1,description2,user_uid);
        }

        [HttpPut("{uid}/{elcat}/{code}/{nomination}")]
        public async Task<IEnumerable<SelectError_Model>> spu_Tip(int? uid, int? uid_sup, bool? elcat, string? code,  string? codeend, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
        {
          return await _repository.spu_tipi(tableName,uid, uid_sup, elcat, code,codeend, nomination, description, description1, description2, user_uid);
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
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectActiveRecByParameters( string? uid_sup, string? nomination, string? description)
        {
            return await _repository.SelectActiveRecByParameters(tableName, uid_sup, nomination, description);

        }

    }
}
