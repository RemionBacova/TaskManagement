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
    public abstract class tbl_TABLE_INFO_ControllerAbstract : ControllerBase
    {
       
            private sp_tbl_TABLE_INFO_Repository _repository;
            private string tableName = "";
            public tbl_TABLE_INFO_ControllerAbstract(sp_tbl_TABLE_INFO_Repository repository, string tableName)
            {
                this._repository = repository;
                this.tableName = tableName;

            }

            [HttpPost("{uid_sup}/{element_uid}/{type_info_uid}/{nomination}")]
            public async Task spi_Info(int? uid_sup, int? element_uid, int? type_info_uid, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
            {
                await _repository.spi_Info( tableName,uid_sup,element_uid,type_info_uid,nomination,description,description1,description2,user_uid);
            }

            [HttpPut("{uid}/{uid_sup}/{element_uid}/{type_info_uid}/{nomination}")]
            public async Task spu_Info(int?uid,int? uid_sup, int? element_uid, int? type_info_uid, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
            {
                await _repository.spu_Info(tableName,uid, uid_sup, element_uid, type_info_uid, nomination, description, description1, description2, user_uid);
            }

            [HttpGet]
            public async Task<IEnumerable<tbl_TABLE_INFO_Model>> SelectAllActiveRec()
            {
                return await _repository.SelectAllActiveRec(tableName);

            }


            [HttpGet("{UID}")]
            public async Task<IEnumerable<tbl_TABLE_INFO_Model>> SelectActiveRecByUID(string UID)
            {
                return await _repository.SelectActiveRecByUID(tableName, UID);

            }

         
             [HttpDelete("{UID}")]
            public async Task<Boolean> DeleteRow(string UID)
            {
                return await _repository.DeleteRow(tableName, UID);

            }

            [HttpGet("GetByParameters")]
            public async Task<IEnumerable<tbl_TABLE_INFO_Model>> SelectActiveRecByParameters(string? uid_sup, string? nomination, string? description)
            {
            return await _repository.SelectActiveRecByParameters(tableName, uid_sup, nomination, description);

        }


        
    }
}
