using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Repository.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_PROJECTS_TYPEController : Abstract.Base.tbl_TABLE_TYPE_ControllerAbstract
    {
        public tbl_PROJECTS_TYPEController(sp_tbl_TABLE_TYPE_Repository repository) : base(repository, "PROJECTS")
        {

        }
    }
}
