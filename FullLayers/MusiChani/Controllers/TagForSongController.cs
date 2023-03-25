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
    public class TagForSongController : ControllerBase
    {
        ITagForSongService service;

        public TagForSongController(ITagForSongService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddTagForSong")]
        public IActionResult AddTagForSong([FromBody] TagForSongViewModel tagForSongViewModel)
        {
            service.AddTagForSong(tagForSongViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteTagForSong/{id}")]
        public IActionResult DeleteTagForSong(int id)
        {
            service.DeleteTagForSong(id);
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
