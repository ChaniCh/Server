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
    public class JobToUserController : ControllerBase
    {
        IJobToUserService service;

        public JobToUserController(IJobToUserService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddJobToUser")]
        public IActionResult AddJobToUser([FromBody] JobToUserViewModel jobToUserViewModel)
        {
            service.AddJobToUser(jobToUserViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteJobToUser/{id}")]
        public IActionResult DeleteJobToUser(int id)
        {
            service.DeleteJobToUser(id);
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
