using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using WebApiTaskManagement.Models;


namespace WebApiTaskManagement.Repository
{

    public class MachinesRepository
    { 
        private readonly string  _constring;
        public MachinesRepository(IConfiguration configuration)
        {
            _constring= configuration.GetConnectionString("defaultConnection");
        }


        public async Task spi_tbl_Machines(Machines machines)
        {
            using ( SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spi_tbl_Machines", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter ("@MachineName",machines.MachineName));
                    cmd.Parameters.Add(new SqlParameter("@OsVersion", machines.Osversion));
                    cmd.Parameters.Add(new SqlParameter("@UserDomainName", machines.UserDomainName));
                    cmd.Parameters.Add(new SqlParameter("@UserName", machines.UserName));
                    cmd.Parameters.Add(new SqlParameter("@Version", machines.Version));
                    cmd.Parameters.Add(new SqlParameter("@MachineHash", machines.MachineHash));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
       


        }
    }
}
