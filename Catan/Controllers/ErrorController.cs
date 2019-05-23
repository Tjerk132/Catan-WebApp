using Catan.Models.Viewmodel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                ErrorViewModel viewModel = new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                    StatusCode = statusCode
                };
                return View(viewModel);
            }
            else return View();
        }
    }
}