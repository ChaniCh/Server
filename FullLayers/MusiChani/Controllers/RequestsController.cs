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
    public class RequestsController : ControllerBase
    {
        IRequestsService service;

        public RequestsController(IRequestsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddRequest")]
        public IActionResult AddRequest([FromBody] RequestsViewModel requestsViewModel)
        {
            service.AddRequest(requestsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteRequest/{id}")]
        public IActionResult DeleteRequest(int id)
        {
            service.DeleteRequest(id);
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
        [Route("UpdateStatus/{requestId}")]
        public IActionResult UpdateStatus(int requestId)
        {
            try
            {
                service.UpdateStatus(requestId);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
