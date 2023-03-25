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
    public class ConnectionController : ControllerBase
    {
        IConnectionService service;

        public ConnectionController(IConnectionService service)
        {
            this.service = service;
        }

        [HttpPut]
        public IActionResult AddConnection([FromBody] ConnectionViewModel connectionViewModel)
        {
            service.AddConnection(connectionViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteConnection/{id}")]
        public IActionResult DeleteConnection(int id)
        {
            service.DeleteConnection(id);
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
        [Route("Login")]
        public IActionResult Login(string email, string password)
        {
            return Ok(service.Login(email, password));
        }


    }
}
