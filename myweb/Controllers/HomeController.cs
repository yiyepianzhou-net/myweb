﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using myweb.Models;

namespace myweb.Controllers
{
    public class HomeController : Controller
    {

        private readonly MywebDbcontext mywebDbcontext;
       
        public HomeController(MywebDbcontext mywebDbcontext)
        {
           this.mywebDbcontext = mywebDbcontext;
        }

        public IActionResult Index()
        {
            var sql = mywebDbcontext.users.Where(c =>EF.Functions.Like(c.UserName,"user2")).ToList();
            return View(new List<demo>() { new demo() { Name = "ace", Salary = 0 }, new demo() { Name = "ace", Salary = 0 } });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class demo {
        public string Name { get; set; }

        public decimal Salary { get; set; }
    }
}
