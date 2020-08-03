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

        [HttpGet("SelectAllActiveRecInterParam")]
        public async Task<IEnumerable<tbl_INTER_EMPLOYE_C_T>> SelectAllActiveRecParam(int? empuid, int? calType_uid, int? calCat_uid)
        {
            return await _repository.SelectAllActiveRecParam(empuid, calType_uid, calCat_uid);
        }

        [HttpGet("SelectAllActiveRecInter")]
        public async Task<IEnumerable<tbl_INTER_EMPLOYE_C_T>> SelectAllActiveRec()
        {
            return await _repository.SelectAllActiveRec();
        }

        [HttpPost("{empuid}/{calType_uid}/{calCat_uid}")]
        public async Task<IEnumerable<SelectError_Model>> spi_inter_emp_type_cat(int? empuid, int? calType_uid, int? calCat_uid, int? user_uid)
        {
            return await _repository.spi_inter_emp_type_cat(empuid, calType_uid, calCat_uid, user_uid);
        }


        [HttpGet("SelectEmployeeHolidays/{empuid}")]
        public async Task<IEnumerable<tbl_TABLE_Model>>SelectEmployee_Holidays(int? empuid)
        {
            return await _repository.SelectEmployee_Holidays(empuid);
        }
    }
}
