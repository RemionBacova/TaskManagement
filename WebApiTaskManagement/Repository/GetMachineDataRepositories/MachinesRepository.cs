using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
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


        public async Task<IEnumerable<Machines>> spi_tbl_Machines(Machines m)
        {
            
            using ( IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spi_tbl_Machines";
                var queryParameters = new DynamicParameters();

              
                    queryParameters.Add("@MachineName",m.MachineName);
                    queryParameters.Add("@OsVersion",m.Osversion);
                    queryParameters.Add("@UserDomainName",m.UserDomainName);
                    queryParameters.Add("@UserName",m.UserName);
                    queryParameters.Add("@Version",m.Version);
                    queryParameters.Add("@MachineHash",m.MachineHash);

                return await sql.QueryAsync<Machines>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

                }

            }

        public async Task<IEnumerable<Machines1>> SelectActiveMachines()
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveMachines";
                return await db.QueryAsync<Machines1>(readSp, commandType: CommandType.StoredProcedure);
            }
        }



    }
    }

