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
    public class SongsController : ControllerBase
    {
        ISongsService service;

        public SongsController(ISongsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddSong")]
        public IActionResult AddSong([FromBody] SongsViewModel songsViewModel)
        {
            service.AddSong(songsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteSong/{id}")]
        public IActionResult DeleteSong(int id)
        {
            service.DeleteSong(id);
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

        [HttpGet]
        [Route("PlaySong/{songId}")]
        public IActionResult PlaySong(int songId)
        {
            return Ok(service.GetSongUrl(songId));
        }

        [HttpGet]
        [Route("GetSongsByTag/{tagId}")]
        public async Task<IActionResult> GetSongsByTagAsync(int tagId)
        {
            //var songs = await service.GetSongsByTagAsync(tagId);
            return Ok(await service.GetSongsByTagAsync(tagId));
        }

    }
}
