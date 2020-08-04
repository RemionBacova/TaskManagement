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
    public class tbl_FilesController : ControllerBase
    {
        private tbl_FilesRepository _repository;

        public tbl_FilesController(tbl_FilesRepository repository)
        {
            this._repository = repository;

        }

        //Post api/machine
        [HttpPost]
        public async Task<IEnumerable<SelectError_Model>> spi_File(string entity, string elementID, string typeUID, string url, string file, string file_type)
        {
           return await _repository.spi_Files(entity, elementID, typeUID, url, file, file_type);

        }

        [HttpGet]

        public async Task<IEnumerable<tbl_Files>> SelectFileByUID(string Element_UID, string type_info_uid)
        {
            return await _repository.SelectFileByUID(Element_UID, type_info_uid);
        }
    }
}
