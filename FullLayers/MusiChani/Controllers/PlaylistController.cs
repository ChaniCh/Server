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
    public class PlaylistController : ControllerBase
    {
        IPlaylistService service;

        public PlaylistController(IPlaylistService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddPlaylist")]
        public IActionResult AddPlaylist([FromBody] PlaylistViewModel playlistViewModel)
        {
            service.AddPlaylist(playlistViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeletePlaylist/{id}")]
        public IActionResult DeletePlaylist(int id)
        {
            service.DeletePlaylist(id);
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
        [Route("GetPlaylistSongs/{playlistId}")]
        public IActionResult GetPlaylistSongs(int playlistId)
        {
            return Ok(service.GetPlaylistSongs(playlistId));
        }

    }
}
