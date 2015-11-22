using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.WebUI.Code.Managers.Interfaces;
using Todo.WebUI.Models;

namespace Todo.WebUI.Controllers
{
    public class SecurityController : Controller
    {
        private readonly ISecurityManager _securityManager;

        public SecurityController(ISecurityManager securityManager)
        {
            _securityManager = securityManager;
        }

        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
       

        [HttpPost]
        public ActionResult Login(SecurityModel securityModel)
        {
            bool authenticateUser = false;
            authenticateUser = _securityManager.Login(securityModel.Login, securityModel.Password);
            
            if (authenticateUser)
            {
                return RedirectToAction("Index", "Task");
            }
            else
            {
                ViewBag.Mess = "Incorrect user name or password";
                return View();
            }
        }

    }
}
