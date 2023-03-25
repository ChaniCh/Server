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
    public class AlbumToSingerController : ControllerBase
    {
        IAlbumToSingerService service;

        public AlbumToSingerController(IAlbumToSingerService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddAlbumToSinger")]
        public IActionResult AddAlbumToSinger([FromBody] AlbumToSingerViewModel albumToSingerViewModel)
        {
            service.AddAlbumToSinger(albumToSingerViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteAlbumToSinger/{id}")]
        public IActionResult DeleteAlbumToSinger(int id)
        {
            service.DeleteAlbumToSinger(id);
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
