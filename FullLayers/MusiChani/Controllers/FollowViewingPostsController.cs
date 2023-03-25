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
    public class FollowViewingPostsController : ControllerBase
    {
        IFollowViewingPostsService service;

        public FollowViewingPostsController(IFollowViewingPostsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddFollowViewingPosts")]
        public IActionResult AddFollowViewingPosts([FromBody] FollowViewingPostsViewModel followViewingPostsViewModel)
        {
            service.AddFollowViewingPosts(followViewingPostsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteFollowViewingPosts/{id}")]
        public IActionResult DeleteFollowViewingPosts(int id)
        {
            service.DeleteFollowViewingPosts(id);
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
