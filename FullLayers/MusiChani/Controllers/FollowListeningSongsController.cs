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
    public class FollowListeningSongsController : ControllerBase
    {
        IFollowListeningSongsService service;

        public FollowListeningSongsController(IFollowListeningSongsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddFollowListeningSongs")]
        public IActionResult AddFollowListeningSongs([FromBody] FollowListeningSongsViewModel followListeningSongsViewModel)
        {
            service.AddFollowListeningSongs(followListeningSongsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteFollowListeningSong/{id}")]
        public IActionResult DeleteFollowListeningSong(int id)
        {
            service.DeleteFollowListeningSong(id);
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
        [Route("GetTopTenMostPlayedSongsLastWeek")]
        public IActionResult GetTopTenMostPlayedSongsLastWeek()
        {
            return Ok(service.GetTopTenMostPlayedSongsLastWeek());
        }
    }
}
