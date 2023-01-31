using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesApi.Controllers
{
    public class ProvidersController : Controller
    {



        // GET: ProvidersController
        [HttpGet("GetProviders")]
        public IActionResult Get()
        {
            return Ok();
        }

        // post: ProvidersController/CreateProvider
        [HttpPost("CreateProvider")]
        public IActionResult Create()
        {
            return Ok();
        }

        // put: ProvidersController/UpdateProvider
        [HttpPut("UpdateProvider")]
        public IActionResult Update()
        {
            return Ok();
        }

        // delete: ProvidersController/deleteProvider
        [HttpDelete("deleteProvider")]
        public IActionResult delete()
        {
            return Ok();
        }
    }
}
