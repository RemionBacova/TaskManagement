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
    public class tbl_MENUSController : ControllerBase
    {
        private tbl_MENU_Repository _repository;

        public tbl_MENUSController(tbl_MENU_Repository repository)
        {
            this._repository = repository;

        }

        [HttpGet("GetAll_Menus")]
        public async Task<IEnumerable<tbl_Menu_Model>> GetAllMenus()
        {
            return await _repository.SelectMenus();
        }
        [HttpGet("GetAll_MenusByIdSup")]
        public async Task<IEnumerable<tbl_Menu_Model>> GetMenuByIdSup(string uid)
        {
            return await _repository.SelectMenuByparentUid(uid);
        }
        [HttpGet("GetAll_MenusByUserId")]
        public async Task<IEnumerable<tbl_Menu_Model>> GetMenuByUserId(string uid)
        {
            return await _repository.SelectMenuByUserId(uid);
        }
    }
}
