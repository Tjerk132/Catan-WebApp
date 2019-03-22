using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catan_Asp._Net.Views.Catan;

namespace Catan_Asp._Net.Controllers
{
    public class CatanController : Controller
    {
        // GET: Catan
        public ActionResult Index()
        {
            return View();
        }
    }
}