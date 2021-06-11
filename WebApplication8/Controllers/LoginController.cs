using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Next(SignUpModel signUpModel)
        {

            if(signUpModel.firstName == null || signUpModel.lasttName == null) return View(nameof(SignUp));
            return View("setPass", signUpModel);
        }

        [HttpPost]
        public IActionResult WriteCode(SignUpModel signUpModel)
        {
            return View("RestoreCode", signUpModel);
        }

        [HttpPost]
        public IActionResult Result(SignUpModel signUpModel)
        {
            if (signUpModel.email == null) return View("setPass", signUpModel);
            try
            {
                var addr = new System.Net.Mail.MailAddress(signUpModel.email);
            }
            catch
            {
                return View("setPass", signUpModel);
            }


            if (signUpModel.password != signUpModel.confirm) return View("setPass", signUpModel);
            return View("SingUpResult", signUpModel);
        }
    }
}
