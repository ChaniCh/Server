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
    public class PostsController : ControllerBase
    {
        IPostsService service;

        public PostsController(IPostsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddPost")]
        public IActionResult AddPost([FromBody] PostsViewModel postsViewModel)
        {
            service.AddPost(postsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeletePost/{id}")]
        public IActionResult DeletePost(int id)
        {
            service.DeletePost(id);
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
