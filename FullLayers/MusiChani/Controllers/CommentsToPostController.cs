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
    public class CommentsToPostController : ControllerBase
    {
        ICommentsToPostService service;

        public CommentsToPostController(ICommentsToPostService service)
        {
            this.service = service;
        }

        [HttpPut]
        public IActionResult AddCommentToPost([FromBody] CommentsToPostViewModel commentsToPostViewModel)
        {
            service.AddCommentsToPost(commentsToPostViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteCommentToPost/{id}")]
        public IActionResult DeleteCommentToPost(int id)
        {
            service.DeleteCommentsToPost(id);
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
