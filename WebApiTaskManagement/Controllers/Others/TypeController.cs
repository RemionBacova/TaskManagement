using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Concrete;
using WebApiTaskManagement.Repository.Concrete;

namespace WebApiTaskManagement.Controllers.Others
{
    public class TypeController
    {
        private Type_Repository _repository;

        public TypeController(Type_Repository repository)
        {
            this._repository = repository;

        }

        [HttpGet("GetAll_Types")]
        public async Task<IEnumerable<Type_Model>> SelectConnections()
        {
            return await _repository.SelectEntitites();
        }
    }
}
