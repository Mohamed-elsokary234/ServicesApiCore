using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesApi.Controllers
{
    public class SpecialistsController : Controller
    {



        // GET: SpecialistsController
        [HttpGet("GetSpecialists")]
        public IActionResult Get()
        {
            return Ok();
        }

        // post: SpecialistsController/CreateSpecialist
        [HttpPost("CreateSpecialist")]
        public IActionResult Create()
        {
            return Ok();
        }

        // put: SpecialistsController/UpdateSpecialist
        [HttpPut("UpdateSpecialist")]
        public IActionResult Update()
        {
            return Ok();
        }

        // delete: SpecialistsController/deleteSpecialist
        [HttpDelete("deleteSpecialist")]
        public IActionResult delete()
        {
            return Ok();
        }
    }
}
