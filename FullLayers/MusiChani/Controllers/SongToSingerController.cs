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
    public class SongToSingerController : ControllerBase
    {
        ISongToSingerService service;

        public SongToSingerController(ISongToSingerService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddSongToSinger")]
        public IActionResult AddSongToSinger([FromBody] SongToSingerViewModel songToSingerViewModel)
        {
            service.AddSongToSinger(songToSingerViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteSongToSinger/{id}")]
        public IActionResult DeleteSongToSinger(int id)
        {
            service.DeleteSongToSinger(id);
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
