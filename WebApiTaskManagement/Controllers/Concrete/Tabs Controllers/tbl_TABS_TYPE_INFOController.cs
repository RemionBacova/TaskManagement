﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers.Abstract
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_TABS_TYPE_INFOController : Abstract.Base.tbl_TABLE_TYPE_INFO_ControllerAbstract
    {
        public tbl_TABS_TYPE_INFOController(sp_tbl_TABLE_TYPE_INFO_Repository repository):base(repository, "TABS")
        {

        }
    }
}
