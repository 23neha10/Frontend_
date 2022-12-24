using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserAuthenication.Models;

namespace UserAuthenication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }

        [HttpPost]
       public ActionResult Login(LoginModel loginModel)
        {
           LoginModelManager loginModelManager = new LoginModelManager();
            loginModel = loginModelManager.UserAuth(loginModel);
            return null;
        }
       
    }
}