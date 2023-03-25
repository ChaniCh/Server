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
    public class TagForPostController : ControllerBase
    {
        ITagForPostService service;

        public TagForPostController(ITagForPostService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddTagForPost")]
        public IActionResult AddTagForPost([FromBody] TagForPostViewModel tagForPostViewModel)
        {
            service.AddTagForPost(tagForPostViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteTagForPost/{id}")]
        public IActionResult DeleteTagForPost(int id)
        {
            service.DeleteTagForPost(id);
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
