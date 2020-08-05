using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Models.Abstract.Base;
using webapiUploadFile.Models;
using webapiUploadFile.Repository;

namespace webapiUploadFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_FILETYPE_Controller : ControllerBase
    {
        private tbl_FileTypeRepository _repository;

        public tbl_FILETYPE_Controller(tbl_FileTypeRepository repository)
        {
            this._repository = repository;

        }

        //Post api/machine
        [HttpPost]
        public async Task<IEnumerable<SelectError_Model>> spi_FileType(string nomination)
        {
            return await _repository.spi_FilesTypes(nomination);

        }

        [HttpGet]

        public async Task<IEnumerable<tbl_FileType_Model>> SelectFileByUID(int uid)
        {
            return await _repository.SelectFileType(uid);
        }

        [HttpDelete("{UID}")]
        public async Task<IEnumerable<SelectError_Model>> DeleteRow(string tableName, int UID)
        {
            return await _repository.DeleteRow(tableName, UID);

        }
    }
}
