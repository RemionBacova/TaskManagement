using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Models;
using WebApiTaskManagement.Repository;

namespace WebApiTaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesReportingController : ControllerBase
    {
        private MachineReportingRepository _repository;

        public MachinesReportingController(MachineReportingRepository repository)
        {
            this._repository = repository; /*?? throw new ArgumentNullException(nameof(repository));*/

        }

        //Post api/machine
        [HttpPost]
        public async Task spi_tbl_MachineReporting([FromBody] MachineReporting machinerep)
        {
            await _repository.spi_tbl_MachineReporting(machinerep);
        }
    }
}
