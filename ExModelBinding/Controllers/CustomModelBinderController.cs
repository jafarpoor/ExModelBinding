using ExModelBinding.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExModelBinding.Controllers
{
    public class CustomModelBinderController : Controller
    {
      
        public IActionResult Index(string Name)
        {
            return View();
        }

        //chang fromat to xml
        //setting to startup
        [Consumes("applicaion/xml")]
        [HttpGet]
        public IActionResult GetUser(string Name)
        {
            return View();
        }

         // customModelBinding
        //dar url Ex=>contoller/NewUser?UserInfo=faezeh|20
        //Id =>neverBind
        public IActionResult NewUser([ModelBinder(binderType: typeof(UserCustomModelBinder))] UserInfo newUser)
        {

            return View();
        }
    }
}
