using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            for (int i = 0; i < 100; i++)
            {
                var count = mywebDbcontext.rooms.Count();
                var roomname = $"room{count + 1}"; var username = $"username{count + 1}";
                var room = new Room() { RoomName = roomname, users = new List<User>() { new User() { UserName = username } } };
                mywebDbcontext.rooms.Add(room);
            }
            mywebDbcontext.SaveChanges();
            return View();
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
}
