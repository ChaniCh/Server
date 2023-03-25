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
    public class FavoriteSongsController : ControllerBase
    {
        IFavoriteSongsService service;

        public FavoriteSongsController(IFavoriteSongsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddFavoriteSongs")]
        public IActionResult AddFavoriteSongs([FromBody] FavoriteSongsViewModel favoriteSongsViewModel)
        {
            //favoriteSongsViewModel.Date = DateTime.Now;
            service.AddFavoriteSong(favoriteSongsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteFavoriteSong/{id}")]
        public IActionResult DeleteFavoriteSong(int id)
        {
            service.DeleteFavoriteSong(id);
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
