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
    public class AlbumsController : ControllerBase
    {
        IAlbumsService service;

        public AlbumsController(IAlbumsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddAlbum")]
        public IActionResult AddAlbum([FromBody] AlbumsViewModel albumsViewModel)
        {
            service.AddAlbum(albumsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteAlbum/{id}")]
        public IActionResult DeleteAlbum(int id)
        {
            service.DeleteAlbum(id);
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
        [Route("GetSongs/{albumId}")]
        public IActionResult GetSongs(int albumId)
        {
            return Ok(service.GetSongs(albumId));
        }

        public IActionResult SetStatus(int albumId, bool status)
        {
           service.SetStatus(albumId, status);
            return Ok(service.GetList());
        }

        [HttpGet]
        [Route("GetAlbumsBySingerId/{singerId}")]
        public IActionResult GetAlbumsBySingerId(int singerId)
        {
            //List<AlbumsViewModel> albums = service.GetAlbumsBySingerId(singerId);
            return Ok(service.GetAlbumsBySingerId(singerId));
        }
    }
}
