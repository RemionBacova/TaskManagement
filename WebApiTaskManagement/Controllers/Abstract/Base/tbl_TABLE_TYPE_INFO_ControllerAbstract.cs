using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers.Abstract.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class tbl_TABLE_TYPE_INFO_ControllerAbstract : ControllerBase
    {
        private sp_tbl_TABLE_TYPE_INFO_Repository _repository;
        private string tableName;

        public tbl_TABLE_TYPE_INFO_ControllerAbstract(sp_tbl_TABLE_TYPE_INFO_Repository repository, string tableName)
        {
            _repository = repository;
            this.tableName = tableName;
        }

        [HttpPost("{uid_sup}/{nomination}/{property}")]
        public async Task<IEnumerable<SelectError_Model>> spi_Tip_Info(int? uid_sup, int? type_uid, string? nomination, string? description
            , string? description1, string? description2, int? property, bool? mandatory, int? db, bool? file, int? user_uid)
        {
          return  await _repository.spi_Tip_Info( tableName, uid_sup,  type_uid,  nomination,  description
            , description1,  description2,  property,  mandatory,  db,  file,  user_uid);
        }

        [HttpPut("{uid}/{uid_sup}/{type_uid}/{nomination}/{property}")]
        public async Task<IEnumerable<SelectError_Model>> spu_Tip_Info( int? uid, int? uid_sup, int? type_uid, string? nomination, string? description
            , string? description1, string? description2, int? property, bool? mandatory, float? queue, bool? file, int? user_uid)
        {
           return await _repository.spu_Tip_Info( tableName,uid, uid_sup, type_uid, nomination, description
            , description1, description2, property, mandatory, queue, file, user_uid);
        }

        [HttpGet]
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> SelectAllActiveRec()
        {
            return await _repository.SelectAllActiveRec(tableName);

        }

        [HttpGet("{UID}")]
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> SelectActiveRecByUID(string UID)
        {
            return await _repository.SelectActiveRecByUID(tableName, UID);

        }

        [HttpDelete("{UID}")]
        public async Task<Boolean> DeleteRow(string UID)
        {
            return await _repository.DeleteRow(tableName, UID);

        }

     

        [HttpGet("GetByParameters")]
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> SelectActiveRecByParameters(string? uid_sup, string? nomination, string? description)
        {
            return await _repository.SelectActiveRecByParameters(tableName, uid_sup, nomination, description);

        }

        [HttpGet("GetByType")]
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> SelectActiveRecByTYPE(string TYPE_UID)
        {
            return await _repository.SelectActiveRecByTYPE(tableName, TYPE_UID);

        }




    }
}
