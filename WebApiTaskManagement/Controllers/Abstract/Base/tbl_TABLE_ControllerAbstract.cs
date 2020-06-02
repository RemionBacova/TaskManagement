﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public async Task spi_tbl_table([FromBody] tbl_TABLE_Model modelName)
        {
            await _repository.spi_tbl_table(modelName, tableName);
        }

        [HttpPut]
        public async Task spu_tbl_table([FromBody] tbl_TABLE_Model modelName)
        {
            await _repository.spu_tbl_table(modelName, tableName);
        }

        [HttpGet("{tableName}")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectAllActiveRec()
        {
            return await _repository.SelectAllActiveRec(tableName);

        }

        [HttpGet("{UID}")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByUID(string UID)
        {
            return await _repository.SelectActiveRecByUID(tableName, UID);

        }

        [HttpGet("GetByType")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByTYPE(string TYPE_UID)
        {
            return await _repository.SelectActiveRecByTYPE(tableName, TYPE_UID);

        }

        [HttpDelete("{UID}")]
        public async Task<Boolean> DeleteRow(tbl_TABLE_Model modelName, string UID)
        {
            return await _repository.DeleteRow(tableName, UID);

        }

        [HttpGet("GetByParameters")]
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByParameters(string? uid_sup, string? active, string? nomination, string? description)
        {
            return await _repository.SelectActiveRecByParameters(tableName, uid_sup,active,nomination,description);

        }


    }
}
