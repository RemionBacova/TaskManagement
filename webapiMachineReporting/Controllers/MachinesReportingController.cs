using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapiMachineReporting.Models;
using webapiMachineReporting.Repository;

namespace webapiMachineReporting.Controllers
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

        [HttpGet("GetAll_MachineRecordingByUID")]
        public async Task<IEnumerable<MachineReporting2>> SelectMachineReportingByUID(string uid, string dateBegin, string dateEnd)
        {
            return await _repository.SelectMachineReportingByUID(uid, dateBegin, dateEnd);
        }
    }
}
