﻿using jwt_core_proje_kampi.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwt_core_proje_kampi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Login()
        {
            return Created("", new BuildToken().CretateToken());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Page1()
        {
            return Ok("Sayfa 1 için girişiniz başarılı.");
        }
    }
}
