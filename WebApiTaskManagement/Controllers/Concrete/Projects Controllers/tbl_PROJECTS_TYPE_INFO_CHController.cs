﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_PROJECTS_TYPE_INFO_CHController : Abstract.tbl_TABLE_TYPE_INFO_CH_ControllerAbstract
    {
        public tbl_PROJECTS_TYPE_INFO_CHController(sp_tbl_TABLE_TYPE_INFO_CH_Repository repository):base(repository, "PROJECTS")
        {

        }
    }
}
