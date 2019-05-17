using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catan_Asp._Net.Models.Viewmodel;
using Models.Models;
using DataLayer;
using HexagonLogic.Logic;

namespace Catan_Asp._Net.Controllers
{
    public class CatanController : Controller
    {
        // GET: Catan
        public ActionResult Index()
        {
            GetMap getmap = new GetMap();
            CatanViewmodel viewmodel = new CatanViewmodel
            {
                Hexagons = getmap.GetHexagons(),
                DockLines = getmap.GetDockLines(),
                BestPositions = getmap.GetTopPositions()
            };
            //RetrieveSavesData Retrievedata = new RetrieveSavesData();
            //List<Save> saves = Retrievedata.GetSavesInfo();
            //viewmodel.Saves = saves;
            return View(viewmodel);         
        }
    }
}