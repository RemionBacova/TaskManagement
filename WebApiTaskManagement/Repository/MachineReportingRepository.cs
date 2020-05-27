using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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


        public async Task spi_tbl_MachineReporting(MachineReporting machinerep)
        {

            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spi_tbl_MachineReporting", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ProcessName", machinerep.ProcessName));
                    cmd.Parameters.Add(new SqlParameter("@ApplicationName", machinerep.ApplicationName));
                    cmd.Parameters.Add(new SqlParameter("@TotalSecond", machinerep.TotalSeconds));
                    cmd.Parameters.Add(new SqlParameter("@MachineHash", machinerep.MachineHash));
                    cmd.Parameters.Add(new SqlParameter("@SessionID", machinerep.GUID));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }



        }
    }
}

