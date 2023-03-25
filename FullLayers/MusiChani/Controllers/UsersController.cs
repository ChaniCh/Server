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
    public class UsersController : ControllerBase
    {
        IUsersService service;

        public UsersController(IUsersService service)
        {
            this.service = service;
        }

        [HttpPut]
        [Route("AddUser")]
        public IActionResult AddUser([FromBody] UsersViewModel usersViewModel)
        {
            service.AddUser(usersViewModel);
            return Ok(service.GetList());
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            service.DeleteUser(id);
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
        [Route("GetByPassword")]
        public IActionResult GetByPassword(string email, string password)
        {
            return Ok(service.GetByPassword(email, password));
        }

        [HttpGet]
        [Route("GetNumberOfUsers")]
        public IActionResult GetNumberOfUsers()
        {
            return Ok(service.GetNumberOfUsers());
        }

        [HttpGet]
        [Route("CheckEmailExists")]
        public async Task<IActionResult> CheckEmailExistsAsync(string email)
        {
            bool emailExists = await service.CheckEmailExistsAsync(email);
            return Ok(emailExists);
        }

        [HttpGet]
        [Route("GetArtists")]
        public async Task<IActionResult> GetListArtistAsync()
        {
            return Ok(await service.GetArtistAsync());
        }

        //[HttpGet]
        //[Route("GetByPassword")]
        //public IActionResult GetByPassword(string name, string email, string password)
        //{
        //    return Ok(service.GetByPassword(name, email, password));
        //}

        //public IActionResult SubscribeNewsletter()
    }
}
