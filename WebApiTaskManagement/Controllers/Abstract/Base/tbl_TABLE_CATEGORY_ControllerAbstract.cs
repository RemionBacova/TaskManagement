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

        [HttpPost("{code}/{nomination}")]
        public async Task<IEnumerable<SelectError_Model>> spi_Kateogria(/*[FromBody] tbl_TABLE_CATEGORY_Model modelName, */int? uid_sup, bool? elcat, string? code, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
        {
           return await _repository.spi_Kateogria( tableName,uid_sup,elcat,code,nomination,description,description1,description2,user_uid);
        }

        [HttpPut("{uid}/{code}/{nomination}")]


        public async Task<IEnumerable<SelectError_Model>> spu_Kateogria(/*[FromBody] tbl_TABLE_CATEGORY_Model modelName*/int?uid, int? uid_sup, bool? elcat, string? code, string? nomination, string? description
            , string? description1, string? description2 ,int? user_uid)
        {
          
           return await _repository.spu_Kateogria(tableName,uid, uid_sup, elcat, code, nomination, description, description1, description2, user_uid);
        }

        [HttpGet]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectAllActiveRec()
        { 
            
            return await _repository.SelectAllActiveRec(tableName);

        }

        [HttpGet("{UID}")]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectActiveRecByUID(string UID)
        {
            return await _repository.SelectActiveRecByUID(tableName, UID);

        }

        [HttpDelete("{UID}")]
        public async Task<IEnumerable<SelectError_Model>> DeleteRow(string UID)
        {
            return await _repository.DeleteRow(tableName, UID);

        }

        [HttpGet("GetByParameters")]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectActiveRecByParameters(string? uid_sup, string? nomination, string? description)
        {
            return await _repository.SelectActiveRecByParameters(tableName, uid_sup, nomination, description);

        }

        [HttpGet("SelectAllActiveRecWithParent")]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model1>> SelectAllActiveRecWithParent()
        {

            return await _repository.SelectAllActiveRecWithParent(tableName);

        }

        [HttpGet("GetTREE")]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> GetTREE( string UID)
        {
            return await _repository.spGetTree(tableName, UID);
        }

        [HttpGet("GetPossibleParents")]
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> GetParents( string UID)
        {
            return await _repository.GetPossibleParents(tableName, UID);
        }


    }
}

