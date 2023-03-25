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
    public class CopyrightReportingController : ControllerBase
    {
        ICopyrightReportingService service;

        public CopyrightReportingController(ICopyrightReportingService service)
        {
            this.service = service;
        }

        [HttpPut]
        public IActionResult AddCopyrightReporting([FromBody] CopyrightReportingViewModel copyrightReportingViewModel)
        {
            service.AddCopyrightReporting(copyrightReportingViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteCopyrightReporting/{id}")]
        public IActionResult DeleteCopyrightReporting(int id)
        {
            service.DeleteCopyrightReporting(id);
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
