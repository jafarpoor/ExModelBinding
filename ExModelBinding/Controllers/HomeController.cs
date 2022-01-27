using ExModelBinding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //From Header
        //public IActionResult Index([FromHeader]string Name )
        //{
        //    return View();
        //}


        public IActionResult Index(string Name)
        {
            return View();
        }

        //view 
        //contoller/edit?name=faezeh&age=20
        public IActionResult Edit(UserInfo user)
        {
            return View();
        }

        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(UserInfo user)
        {
            return View();
        }


        /// <summary>
        /// type model binding  ==>string , dictionray , Ifromcollection, IfromFile , service ham mitonim 
        /// </summary>
        /// <returns></returns>
        /// 
        public IActionResult SaveCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveCheck(Dictionary<int,string> dic , IFormCollection ch)
        {
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
