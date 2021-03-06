﻿using System;
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

            [HttpPost("{element_uid}/{type_info_uid}/{nomination}")]
            public async Task<IEnumerable<SelectError_Model>> spi_Info(int? uid_sup, int? element_uid, int? type_info_uid, string? nomination, string? description
            , string? description2, string? description3, int? user_uid)
            {
               return await _repository.spi_Info( tableName,uid_sup,element_uid,type_info_uid,nomination,description,description2,description3,user_uid);
            }

            [HttpPut("{uid}/{element_uid}/{type_info_uid}/{nomination}")]
            public async Task<IEnumerable<SelectError_Model>> spu_Info(int?uid,int? uid_sup, int? element_uid, int? type_info_uid, string? nomination, string? description
            , string? description2, string? description3, int? user_uid)
            {
               return await _repository.spu_Info(tableName,uid, uid_sup, element_uid, type_info_uid, nomination, description, description2, description3, user_uid);
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


        [HttpGet("SelectAllActiveRecWith_Element_TypeInfo")]
        public async Task<IEnumerable<tbl_TABLE_INFO_Model1>> SelectAllActiveRecWith_Element_TypeInfo(string elementUid, string typeinfoUid)
        {
            return await _repository.SelectAllActiveRecWith_Element_TypeInfo(tableName,elementUid,typeinfoUid);

        }



    }
}
