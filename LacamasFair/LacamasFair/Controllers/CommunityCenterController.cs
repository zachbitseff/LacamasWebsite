using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LacamasFair.Controllers
{
    public class CommunityCenterController : Controller
    {

        // GET: CommunityCenter
        public ActionResult Index()
        {
            return View();
        }

        


        // GET: Bingo
        public ActionResult Bingo()
        {
            return View();
        }

        // GET: CommunityClub
        public ActionResult CommunityClub()
        {
            return View();
        }

        // GET: FacilityRental
        public ActionResult FacilityRental()
        {
            return View();
        }

        // GET: HarvestFest
        public ActionResult HarvestFest()
        {
            ViewBag.Dates = "5th,";
            ViewBag.Times = "10:00 AM to 4:00 PM";
            return View();
        }

        // GET: HolidayBazaar
        public ActionResult HolidayBazaar()
        {
            ViewBag.Dates = "7th & 8th,";
            ViewBag.Times = "10:00 AM to 4:00 PM";

            return View();
        }
    }
}