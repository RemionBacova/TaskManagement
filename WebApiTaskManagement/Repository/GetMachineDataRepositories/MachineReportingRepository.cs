using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models;

namespace WebApiTaskManagement.Repository
{

    //MachineReportingRepository
    public class MachineReportingRepository
    {
        private readonly string _constring;
        public MachineReportingRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }


        public async Task<IEnumerable<MachineReporting>> spi_tbl_MachineReporting(MachineReporting machinerep)
        {

            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spi_tbl_MachineReporting";
                var queryParameters = new DynamicParameters();

                
                    queryParameters.Add("@ProcessName", machinerep.ProcessName);
                    queryParameters.Add("@ApplicationName", machinerep.ApplicationName);
                    queryParameters.Add("@TotalSecond", machinerep.TotalSeconds);
                    queryParameters.Add("@MachineHash", machinerep.MachineHash);
                    queryParameters.Add("@SessionID", machinerep.GUID);

                return await sql.QueryAsync<MachineReporting>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }

            }



        }
    }


