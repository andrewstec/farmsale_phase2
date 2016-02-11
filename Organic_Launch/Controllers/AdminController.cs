using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organic_Launch.Controllers
{
    public class AdminController : Controller
    {
        private FarmSaleDBEntities1 db = new FarmSaleDBEntities1();
        // GET: Admin

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}