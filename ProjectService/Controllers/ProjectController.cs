using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectService.Models;
using ProjectService.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        ProjectRepository _repo = new ProjectRepository();
        // GET: api/<ProductController>
        [HttpGet]
        [Route("GetProjects")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetAll());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

        // GET api/<ProductController>/5
        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_repo.GetById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        [Route("AddProject")]
        public IActionResult Post(Project p)
        {
            try
            {
                _repo.AddProject(p);
                return Ok("Added");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message + "\n" + ex.InnerException.Message);

            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Project p)
        {
            try
            {
                _repo.UpdateProject(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repo.DeleteProject(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
    }
}
