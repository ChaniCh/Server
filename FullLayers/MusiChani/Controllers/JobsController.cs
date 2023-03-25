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
    public class JobsController : ControllerBase
    {
        IJobsService service;

        public JobsController(IJobsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddJob")]
        public IActionResult AddJob([FromBody] JobsViewModel jobsViewModel)
        {
            service.AddJob(jobsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteJob/{id}")]
        public IActionResult DeleteJob(int id)
        {
            service.DeleteJob(id);
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
