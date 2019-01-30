using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BotView.Models;
using Newtonsoft.Json;

namespace BotView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PostQuery(string query)
        {
            /*
             *  Todo:
             *  
             *  Do the bot stuffs here
             *  parameter query is the user input to be evaluated
             *  replace "Query successful" with bot response
             */


            var result = JsonConvert.SerializeObject(new
            {
                Message = "Query successful",
                Query = query
            });

            return Ok(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
