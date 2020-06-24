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
    public abstract class tbl_TABLE_TYPE_INFO_CH_ControllerAbstract : ControllerBase
    {
        private sp_tbl_TABLE_TYPE_INFO_CH_Repository _repository;
        private string tableName = "";
        public tbl_TABLE_TYPE_INFO_CH_ControllerAbstract(sp_tbl_TABLE_TYPE_INFO_CH_Repository repository, string tableName)
        {
            this._repository = repository;
            this.tableName = tableName;

        }

        [HttpPost("{uid_sup}/{type_info_uid}/{nomination}")]
        public async Task<IEnumerable<SelectError_Model>> spi_Info(int? uid_sup, int? type_info_uid, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
        {
           return await _repository.spi_Tip_Info_Ch( tableName,uid_sup,type_info_uid,nomination,description,description1,description2,user_uid);
        }

        [HttpPut("{uid}/{uid_sup}/{type_info_uid}/{nomination}")]
        public async Task<IEnumerable<SelectError_Model>> spu_Info(int? uid, int? uid_sup, int? type_info_uid, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
        {
           return await _repository.spu_Tip_Info_Ch( tableName,  uid,  uid_sup,  type_info_uid,  nomination, description
            ,  description1,  description2,  user_uid);
        }

        [HttpGet]
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_CH_Model>> SelectAllActiveRec()
        {
            return await _repository.SelectAllActiveRec(tableName);

        }

        [HttpGet("{UID}")]
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_CH_Model>> SelectActiveRecByUID(string UID)
        {
            return await _repository.SelectActiveRecByUID(tableName, UID);

        }

        [HttpDelete("{UID}")]
        public async Task<Boolean> DeleteRow(string UID)
        {
            return await _repository.DeleteRow(tableName, UID);

        }

        [HttpGet("GetByParameters")]
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_CH_Model>> SelectActiveRecByParameters(string? uid_sup, string? nomination, string? description)
        {
            return await _repository.SelectActiveRecByParameters(tableName, uid_sup, nomination, description);

        }


    }
}
