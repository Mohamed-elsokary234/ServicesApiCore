using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesApi.Controllers
{
    public class usersController : Controller
    {



        // GET: usersController
        [HttpGet("Getusers")]
        public IActionResult Get()
        {
            return Ok();
        }

        // post: usersController/Createuser
        [HttpPost("Createuser")]
        public IActionResult Create()
        {
            return Ok();
        }

        // put: usersController/Updateuser
        [HttpPut("Updateuser")]
        public IActionResult Update()
        {
            return Ok();
        }

        // delete: usersController/deleteuser
        [HttpDelete("deleteuser")]
        public IActionResult delete()
        {
            return Ok();
        }
    }
}
