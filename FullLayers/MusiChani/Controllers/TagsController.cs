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
    public class TagsController : ControllerBase
    {
        ITagsService service;

        public TagsController(ITagsService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddTag")]
        public IActionResult AddTag([FromBody] TagsViewModel tagsViewModel)
        {
            service.AddTag(tagsViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteTag/{id}")]
        public IActionResult DeleteTag(int id)
        {
            service.DeleteTag(id);
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
        [Route("CheckTagExists")]
        public async Task<IActionResult> CheckTagExistsAsync(string tag)
        {
            //bool tagExists = await service.CheckTagExistsAsync(tag);
            return Ok(await service.CheckTagExistsAsync(tag));
        }
    }
}
