using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http;
using DevExtremeAsp.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;

namespace DevExtremeAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DevExtremeAspDBContext _dbContext;
        public HomeController(DevExtremeAspDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int? current_page)
        {
            if (current_page is null){current_page=1;}
            ViewData["current_page"]=current_page;
            ViewData["Init"]=1;

            var queryma = (from ma in _dbContext.TMaterials
                //orderby ma.MatDescr
                 select ma).ToList();
            ViewBag.ListMat=queryma;

            var querype = from p in _dbContext.TPersons 
                        orderby p.PerName,p.PerName1
                        select p;
            var qListpe = querype.ToList();
            ViewBag.ListPerson=qListpe;
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View();
        }
    }
}
