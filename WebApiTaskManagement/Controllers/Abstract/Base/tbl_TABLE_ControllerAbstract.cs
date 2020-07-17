using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceStack.DataAnnotations;
using WebApiTaskManagement.Models;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;
using WebApiTaskManagemenk.Repository;

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



        [HttpPost("{type_uid}/{code}/{nomination}/{category}")]
        public async Task<IEnumerable<SelectError_Model>> spi_tbl_table(int? uid_sup, int? type_uid, string? code, string? nomination, string? description
            , string? description1, string? description2, int? user_uid, int? category, bool? complex)
        {
            return await _repository.spi_tbl_table(tableName, uid_sup, type_uid, code, nomination, description, description1, description2, user_uid, category, complex);
        }

        [HttpPut("{uid}/{type_uid}/{code}/{nomination}/{category}")]

        public async Task<IEnumerable<SelectError_Model>> spu_tbl_table(int? uid, int? uid_sup, int? type_uid, string? code, string? nomination, string? description
            , string? description1, string? description2, int? user_uid, int? category, bool? complex)
        {
            return await _repository.spu_tbl_table(tableName, uid, uid_sup, type_uid, code, nomination, description, description1, description2, user_uid, category, complex);
        }

        [HttpGet]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectAllActiveRec()
        {
            return await _repository.SelectAllActiveRec(tableName);

        }

        [HttpGet("SelectAllwithType")]
        public async Task<IEnumerable<tbl_TABLE_Model2>> SelectAllActiveRecPlusType(string category)
        {
            return await _repository.SelectAllActiveRecPlusType(tableName,category);

        }

        [HttpGet("{uid}")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByUID(string uid)
        {
            return await _repository.SelectActiveRecByUID(tableName, uid);

        }

        [HttpDelete("{UID}")]
        public async Task<IEnumerable<SelectError_Model>> DeleteRow(string UID)
        {
            return await _repository.DeleteRow(tableName,UID);

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

       
        [HttpGet("SelectAllActiveRecWithParent")]
        public async Task<IEnumerable<tbl_TABLE_Model1>> SelectAllActiveRecWithParent()
        {

            return await _repository.SelectAllActiveRecWithParent(tableName);

        }

        [HttpGet("GetTREE")]
        public async Task<IEnumerable<tbl_TABLE_Model>> GetTREE(string UID)
        {
            return await _repository.spGetTree(tableName, UID);
        }

        [HttpGet("GetPossibleParents")]
        public async Task<IEnumerable<tbl_TABLE_Model>> GetParents( string UID)
        {
            return await _repository.GetPossibleParents(tableName, UID);
        }


    }
}
