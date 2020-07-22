using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Models.Concrete;
using WebApiTaskManagement.Repository.Concrete;

namespace WebApiTaskManagement.Controllers.Others
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_INTER_EMP_T_C_Controller : ControllerBase
    {
        private tbl_INTER_EMP_TYPE_CAT_Repository _repository;

        public tbl_INTER_EMP_T_C_Controller(tbl_INTER_EMP_TYPE_CAT_Repository repository)
        {
            this._repository = repository;

        }

        [HttpGet("SelectAllActiveRecInter")]
        public async Task<IEnumerable<tbl_INTER_EMPLOYE_C_T>> SelectAllActiveRec(int? empuid, int? calType_uid, int? calCat_uid)
        {
            return await _repository.SelectAllActiveRec(empuid, calType_uid, calCat_uid);
        }

        [HttpPost("{empuid}/{calType_uid}/{calCat_uid}")]
        public async Task<IEnumerable<SelectError_Model>> spi_inter_emp_type_cat(int? empuid, int? calType_uid, int? calCat_uid, int? user_uid)
        {
            return await _repository.spi_inter_emp_type_cat(empuid, calType_uid, calCat_uid, user_uid);
        }

        [HttpDelete("{empUID}")]
        public async Task<IEnumerable<SelectError_Model>> DeleteRow(string empUID)
        {
            return await _repository.DeleteRow(empUID);

        }

    }
}
