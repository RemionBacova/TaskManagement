﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Controllers.Abstract.Base;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;

namespace WebApiTaskManagement.Controllers.Abstract
{ 

    [Route("api/[controller]")]
    [ApiController]
    public class tbl_PROJECTSController : Abstract.Base.tbl_TABLE_ControllerAbstract
    {
        

       
        public tbl_PROJECTSController(sp_tbl_TABLE_Repository repository) : base(repository, "PROJECTS") 
        { }
      

    }  
}


