using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppServices.IServices;
using Common.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusiChani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowersController : ControllerBase
    {
        IFollowersService service;

        public FollowersController(IFollowersService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddFollower")]
        public IActionResult AddFollower([FromBody] FollowersViewModel followersViewModel)
        {
            service.AddFollower(followersViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteFollower/{id}")]
        public IActionResult DeleteFollower(int id)
        {
            service.DeleteFollower(id);
            return Ok(service.GetList());
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetList());
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(service.GetById(id));
        }
    }
}
