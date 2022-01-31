using BarisTutakli.Week4.IdentityAuthApi.Application.Abstract;
using BarisTutakli.Week4.IdentityAuthApi.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }


        [HttpGet]
        public ActionResult GetRoles()
        {
            var result = _roleService.GetAll();
            return Ok(result.Result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var result = _roleService.GetById(id);
            return Ok(result.Result);
        }

        [HttpPost]
        public ActionResult CreateRole([FromBody] CreateRoleViewModel createRoleViewModel)
        {
            _roleService.Create(createRoleViewModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRoleById(int id)
        {
            DeleteRoleViewModel deleteViewModel = new DeleteRoleViewModel();
            deleteViewModel.Id = id;
            var result = _roleService.Delete(deleteViewModel);
            if (result.Result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public ActionResult UpdateRole(int id, [FromBody] UpdateRoleViewModel updateRoleViewModel)
        {

            var result = _roleService.Update(id, updateRoleViewModel);
            return Ok(result.Result);
        }


    }
}
