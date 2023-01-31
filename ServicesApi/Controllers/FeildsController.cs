using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesApi.Controllers
{
    public class FeildsController : Controller
    {



        // GET: FeildsController
        [HttpGet("GetFeilds")]
        public IActionResult Get()
        {
            return Ok();
        }

        // post: FeildsController/CreateFeild
        [HttpPost("CreateFeild")]
        public IActionResult Create()
        {
            return Ok();
        }

        // put: FeildsController/UpdateFeild
        [HttpPut("UpdateFeild")]
        public IActionResult Update()
        {
            return Ok();
        }

        // delete: FeildsController/deleteFeild
        [HttpDelete("deleteFeild")]
        public IActionResult delete()
        {
            return Ok();
        }
    }
}
