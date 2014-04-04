using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coins4good.Controllers
{
    public class CharitiesController : Controller
    {
        // GET: Charities
        public ActionResult Index()
        {
            return View();
        }
    }
}