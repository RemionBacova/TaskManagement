﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers.Project_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_TABSController : Abstract.Base.tbl_TABLE_ControllerAbstract
    {
        public tbl_TABSController(sp_tbl_TABLE_Repository repository) : base(repository, "TABS")
        {

        }
    }
}
