using HelloLayouts.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloLayouts.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            RegistrationModel registrationModel = new RegistrationModel();
            return View(registrationModel);
        }

        [HttpPost]
        public IActionResult Submit(RegistrationModel registrationModel)
        {
            if (ModelState.IsValid)
            {
                return View("RegistrationSuccess");
            }
            else{
                return View("Index");
            }
        }
    }
}
