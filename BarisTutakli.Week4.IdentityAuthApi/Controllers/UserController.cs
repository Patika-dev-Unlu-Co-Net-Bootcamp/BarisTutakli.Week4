using BarisTutakli.Week4.IdentityAuthApi.Application.Abstract;
using BarisTutakli.Week4.IdentityAuthApi.Application.ViewModels;
using BarisTutakli.Week4.IdentityAuthApi.Common.InMemory;

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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public ActionResult GetUsers()
        {
            var result = _userService.GetAll();
            return Ok(result.Result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            return Ok(result.Result);
        }

        [HttpPost]
        public ActionResult CreateUser([FromBody] LoginViewModel loginView)
        {
            _userService.Create(loginView);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUSerById(int id,[FromBody] DeleteViewModel deleteViewModel)
        {
            deleteViewModel.Id = id;
            var result = _userService.Delete(deleteViewModel);
            if (result.Result>0)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, [FromBody] UpdateViewModel updateViewModel)
        {
         
            var result = _userService.Update(id, updateViewModel);
            return Ok(result.Result);
        }


    }
}
