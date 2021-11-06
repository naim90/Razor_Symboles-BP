using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class ExpendidureController : Controller
    {
        // GET: Expendidure
        public ActionResult Index()
        {
            List<Expendidure> depense = new List<Expendidure>
            {
                new Expendidure("iphone",new DateTime(2021,10,10),800),
                new Expendidure("four",new DateTime(2018,09,10),200),
                new Expendidure("pc",new DateTime(2021,10,06),500),
            };

            String conclusion = String.Empty;

            double sum = depense.Sum(m => m.Price);

            if (sum > 1000)
            {
                conclusion = "You earn too much money";
            }
            else
            {
                conclusion = "You should ask for a salary raise";
            }

            ViewData["conclusion"] = conclusion;
            ViewData["sum"] = sum;

            return View("index",depense);
        }
    }
}