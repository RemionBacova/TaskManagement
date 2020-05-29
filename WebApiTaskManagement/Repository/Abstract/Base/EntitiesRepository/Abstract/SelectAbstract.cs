using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository.Abstract
{
    public abstract class SelectAbstract 
    {

        private readonly string _constring;
        public SelectAbstract(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        
        public  async Task sps_SelectAllActiveRec()
        {

        }
    }
}
