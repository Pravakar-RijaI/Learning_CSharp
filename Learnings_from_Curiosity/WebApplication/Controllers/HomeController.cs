﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is Fricking Awesome.";
        }
    }
}
