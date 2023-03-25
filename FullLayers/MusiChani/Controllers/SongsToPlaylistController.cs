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
    public class SongsToPlaylistController : ControllerBase
    {
        ISongsToPlaylistService service;

        public SongsToPlaylistController(ISongsToPlaylistService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddSongToPlaylist")]
        public IActionResult AddSongToPlaylist([FromBody] SongsToPlaylistViewModel songsToPlaylistViewModel)
        {
            service.AddSongToPlaylist(songsToPlaylistViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteSongToPlaylist/{id}")]
        public IActionResult DeleteSongToPlaylist(int id)
        {
            service.DeleteSongToPlaylist(id);
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
            //var songsViewModel = service.GetPlaylistSongs(playlistId);
            //if (songsViewModel == null)
            //    return NotFound();
            //return Ok(songsViewModel);
            return Ok(service.GetPlaylistSongs(playlistId));
        }

        //[HttpGet("{playlistId}/songs")]
        //public ActionResult<List<SongsDTO>> GetSongsByPlaylistId(int playlistId)
        //{
        //    var songsDTO = service.GetSongsByPlaylistId(playlistId);

        //    if (songsDTO == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(songsDTO);
        //}
    }
}
