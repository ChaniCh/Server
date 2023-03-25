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
    public class CommentsToSongController : ControllerBase
    {
        ICommentsToSongService service;

        public CommentsToSongController(ICommentsToSongService service)
        {
            this.service = service;
        }

        [HttpPut]
        public IActionResult AddCommentToSong([FromBody] CommentsToSongViewModel commentsToSongViewModel)
        {
            service.AddCommentsToSong(commentsToSongViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteCommentToSong/{id}")]
        public IActionResult DeleteCommentToSong(int id)
        {
            service.DeleteCommentsToSong(id);
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
