﻿using Microsoft.AspNetCore.Mvc;

namespace demo.Controller
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}