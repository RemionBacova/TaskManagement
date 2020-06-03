﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagemenk.Repository.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers.Entitye_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_USERS_CATEGORYController : Abstract.Base.tbl_TABLE_CATEGORY_ControllerAbstract
    {
        public tbl_USERS_CATEGORYController(sp_tbl_TABLE_CATEGORY_Repository repository) : base(repository,"USERS")
        { }

    }
}
