using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using ServiceStack.DataAnnotations;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;


namespace WebApiTaskManagement.Controllers.Abstract.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class tbl_TABLE_ControllerAbstract : ControllerBase
    {
        private sp_tbl_TABLE_Repository _repository;

        private string tableName = "";
       

        public tbl_TABLE_ControllerAbstract(sp_tbl_TABLE_Repository repository, string tableName)
        {
            this._repository = repository;
            this.tableName = tableName;

        }

        [HttpPost("{uid_sup}/{type_uid}/{code}/{nomination}/{category}/{complex}")]
        public async Task<IEnumerable<SelectError_Model>> spi_tbl_table(int? uid_sup, int? type_uid, string? code, string? nomination, string? description
            , string? description1, string? description2, int? user_uid, int? category, bool? complex
        )
        {
           
               return  await _repository.spi_tbl_table(tableName, uid_sup, type_uid, code, nomination, description, description1, description2, user_uid, category, complex);

        }

       

        [HttpPut("{uid}/{uid_sup}/{type_uid}/{code}/{nomination}")]
        public async Task<IEnumerable<SelectError_Model>> spu_tbl_table( int? uid, int? uid_sup, int? type_uid, string? code, string? nomination, string? description
            , string? description1, string? description2, int? user_uid, int? category, bool? complex)
        {
           return await _repository.spu_tbl_table(tableName,uid,uid_sup,type_uid,code,nomination,description,description1,description2,user_uid,category,complex);
        }

        [HttpGet]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectAllActiveRec()
        {
            return await _repository.SelectAllActiveRec(tableName);

        }
      

        [HttpGet("{uid}")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByUID(string uid)
        {
            return await _repository.SelectActiveRecByUID(tableName, uid);

        }

        [HttpDelete("{UID}")]
        public async Task<Boolean> DeleteRow(tbl_TABLE_Model modelName, string UID)
        {
            return await _repository.DeleteRow(tableName, UID);

        }

        [HttpGet("{nomination}/Property")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByProperty(string? typeID, string? nomination)
        {
            return await _repository.SelectActiveRecByProperty(tableName, typeID,nomination);

        }

        [HttpGet("GetByType")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByTYPE(string TYPE_UID)
        {
            return await _repository.SelectActiveRecByTYPE(tableName, TYPE_UID);

        }

        [HttpGet("GetByParameters")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByParameters(string? uid_sup,string? nomination, string? description)
        {
            return await _repository.SelectActiveRecByParameters(tableName, uid_sup,nomination,description);

        }

        [HttpGet("GetByCategory")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectByCategory(string? category_uid)
        {
            return await _repository.SelectByCategory(tableName, category_uid);

        }

        [HttpGet("GetByCategoryType")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByCategoryAndType(string? category_uid,string?type_uid)
        {
            return await _repository.SelectActiveRecByCategoryAndType(tableName, category_uid,type_uid);

        }

        [HttpGet("{error_id}/getError")]
        public async Task<IEnumerable<SelectError_Model>> SelectErrors(int? error_id)
        {
            return await _repository.SelectErrors(error_id);

        }



    }
}
