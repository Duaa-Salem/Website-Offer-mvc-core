using duaaOffer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace duaaOffer.Controllers
{
    public class HomePageController : Controller
    {
        private readonly ILogger<HomePageController> _logger;
        private readonly TestContext _context;
        public HomePageController(ILogger<HomePageController> logger, TestContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index(string City, string category, string Name, bool Sale, DateTime Enddate, DateTime Startdate, DateTime date)
        {

            date = DateTime.Now;
            ViewBag.Startdate = (from r in _context.Offer select r.Startdate).Distinct();
            ViewBag.Enddate = (from r in _context.Offer select r.Enddate).Distinct();
            ViewBag.Sale = (from r in _context.Offer select r.Sale).Distinct();
            ViewBag.City = (from r in _context.Offer select r.City).Distinct();
            ViewBag.category = (from r in _context.Offer select r.Category.Categoryname).Distinct();
            ViewBag.Name = (from r in _context.Offer select r.Name).Distinct();
            ViewBag.minimumPrice = (from r in _context.Offer select r.Sale).Distinct();
            var m = _context.Offer.ToList();
            var modelAsceSale = from r in _context.Offer
                                orderby r.Sale ascending
                                where r.City == City || City == null || City == ""
                                where r.Category.Categoryname == category || category == null
                                where r.Name == Name || Name == null
                                where r.Startdate < date && r.Enddate > date
                                select r;


            var modelDescSale = from r in _context.Offer
                                orderby r.Sale descending
                                where r.City == City || City == null || City == ""
                                where r.Category.Categoryname == category || category == null
                                where r.Name == Name || Name == null
                                where r.Startdate < date && r.Enddate > date

                                select r;
            if (Sale)
            {
                return View(modelAsceSale);
            }
            return View(modelDescSale);
        }
     
    }
}