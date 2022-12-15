using Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Home Page";
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Name)
        {
            ViewBag.Name = Name;
            List<string> candidates = new List<string>();
            candidates.Add("sajanand");
            candidates.Add("kandgule");
            candidates.Add("anand");
            candidates.Add("taj");
            candidates.Add("gyansys");
            ViewBag.candidates = candidates;
            ViewBag.Message = "Saved Successfully";
            return View();
        }
        [Route("me")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Skills()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Eduction()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Hobby()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ListCandidates()
        {
          
            List<string> candidates = new List<string>();
            candidates.Add("sajanand");
            candidates.Add("kandgule");
            candidates.Add("anand");
            candidates.Add("taj");
            candidates.Add("gyansys");
            ViewBag.candidates = candidates;
            return View();
        }

        [Route("Inform")]
      
        public ActionResult Register()
        {
                    return View();
        }

        public ActionResult BasicDetails()
        {
            return View();
        }
    }
}