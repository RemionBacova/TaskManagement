using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;
using webapiUploadFile.Models;

namespace webapiUploadFile.Repository
{
    public class tbl_FileTypeRepository
    {
        private readonly string _constring;
        public tbl_FileTypeRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }


        public async Task<IEnumerable<SelectError_Model>> spi_FilesTypes(string nomination)
        {


            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spi_tbl_FILETYPE";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@nomination", nomination);
                return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }

        }

        public async Task<IEnumerable<tbl_FileType_Model>> SelectFileType(int uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRecFileType";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@uid", uid);
                return await db.QueryAsync<tbl_FileType_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<SelectError_Model>> DeleteRow(string tableName, int UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName);
                queryParameters.Add("@UID", UID);
                return await db.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                ;
            }
        }
    }
}
