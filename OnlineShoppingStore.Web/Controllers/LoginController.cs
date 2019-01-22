using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Web.Controllers
{
    public class LoginController : Controller
    {
        ILoginAuthentication loginAuthentication;
        public LoginController(ILoginAuthentication authentication)
        {
            loginAuthentication = authentication;
        }
        // GET: Login
        public ActionResult Display()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckLogin(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                bool authenticate= loginAuthentication.AuthenticateUser(loginViewModel.Name, loginViewModel.Password);
                if (authenticate)
                    return  Content( "True");
                else
                    return Content( "False");
            }
            else
               return Content( "False");
        }

        public ViewResult NewUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewUser(User user)
        {
            if(ModelState.IsValid)
            {
                loginAuthentication.SaveUser(user);
                return Content("Saved");
            }
            else
            return Content("Fail");
        }
    }
}