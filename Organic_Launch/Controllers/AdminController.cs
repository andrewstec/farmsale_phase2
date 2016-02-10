using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organic_Launch.Controllers
{
    public class AdminController : Controller
    {
        private FarmSaleDBEntities db = new FarmSaleDBEntities();
        // GET: Admin
        public ActionResult Admin()
        {
            
            return View(db.Products.ToList());
        }
    }
}