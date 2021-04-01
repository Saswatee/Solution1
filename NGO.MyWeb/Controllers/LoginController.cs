using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO.MyWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return View();
        }
    
    public ActionResult Success()
    {

        return View();
    }
        public ActionResult Failure()
        {

            return View();

        } 
        
       }
}