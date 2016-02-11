using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organic_Launch.Controllers
{
    public class FarmController : Controller
    {
        private FarmSaleDBEntities1 db = new FarmSaleDBEntities1();
        // GET: Farmer

        [Authorize(Roles ="Admin, Buyer, Farm")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Buyer, Farm")]
        public ActionResult List()
        {
            return View(db.Products.ToList());
        }

        [Authorize(Roles = "Farm")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Farm")]
        public ActionResult Edit(int id)
        {
            return View(db.Farms.Where(i => i.farmID == id).FirstOrDefault());
        }

        [Authorize(Roles = "Farm")]
        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }

        [Authorize(Roles = "Farm")]
        public ActionResult Delete()
        {
            return View();
        }

        [Authorize(Roles = "Farm")]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Farms.Remove(db.Farms.Where(i => i.farmID == id).FirstOrDefault());
            return View();
        }
    }
}