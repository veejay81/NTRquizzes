using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NTRsearch.web.Classes;

namespace NTRsearch.web.Controllers
{
    public class HomeController : Controller
    {
        // ****************************************************************
        // HINT: Dependences should be injected in the constructor
        // HINT: Don't forget to register dependences in global.asax.cs
        // ****************************************************************

        //private readonly IGoogleSearch googleSearch;
        //private readonly IQueryService queryService;

        //public HomeController(IGoogleSearch googleSearch, IQueryService queryService)
        public HomeController()
        {
            //this.googleSearch = googleSearch;
            //this.queryService = queryService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
