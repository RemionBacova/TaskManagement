using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Controllers.Abstract.Base;
using WebApiTaskManagement.Models;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Models.LoginModels;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;
using WebApiTaskManagement.Repository.Concrete;

namespace WebApiTaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_USERSController : Abstract.Base.tbl_TABLE_ControllerAbstract
    {
        private Login_Repository _repository;


        public tbl_USERSController(sp_tbl_TABLE_Repository repository) : base(repository, "USERS")
        {
        }


       
    }
}


