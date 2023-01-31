using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesApi.Controllers
{
    public class DepartmentsController : Controller
    {



        // GET: DepartmentsController
        [HttpGet("GetDepartments")]
        public IActionResult Get()
        {
            return Ok();
        }

        // post: DepartmentsController/CreateDepartment
        [HttpPost("CreateDepartment")]
        public IActionResult Create()
        {
            return Ok();
        }

        // put: DepartmentsController/UpdateDepartment
        [HttpPut("UpdateDepartment")]
        public IActionResult Update()
        {
            return Ok();
        }

        // delete: DepartmentsController/deleteDepartment
        [HttpDelete("deleteDepartment")]
        public IActionResult delete()
        {
            return Ok();
        }
    }
}
