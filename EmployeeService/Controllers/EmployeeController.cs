using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeService.Models;
using Microsoft.AspNetCore.Http;
using EmployeeService.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository _repo = new EmployeeRepository();

        //public EmployeeController(EmployeeRepository repo)
        //{
        //    _repo = repo;
        //}

        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetAllEmployees());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

        // GET api/<EmployeeController>/5
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

        // POST api/<EmployeeController>
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Post(Employee e)
        {
            try
            {
                _repo.AddEmployee(e);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message + "\n" + ex.InnerException.Message);

            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        [Route("UpdateEmployee")]
        public IActionResult Put(Employee e)
        {
            try
            {
                _repo.UpdateEmployee(e);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repo.DeleteEmployee(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
    }
}
