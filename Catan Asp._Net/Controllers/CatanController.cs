﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catan_Asp._Net.Models.Viewmodel;
using Catan_Asp._Net.Models;
using System.Data.SqlClient;
using System.Data;
using Catan_Asp._Net.Controllers.CreateHexagons;
using DataLayer;

namespace Catan_Asp._Net.Controllers
{
    public class CatanController : Controller
    {
        HexagonPosition position = new HexagonPosition();
        CreateHexagon createhexagon = new CreateHexagon();
        Materials materialchooser = new Materials();
        Docks docks = new Docks();

        // GET: Catan
        public ActionResult Index()
        {
            CatanViewmodel viewmodel = new CatanViewmodel
            {
                Saves = new List<Save>(),
                Hexagons = new List<HexagonTile>()
            };
            RetrieveSavesData Retrievedata = new RetrieveSavesData();
            List<Save> saves = Retrievedata.GetSavesInfo();
            viewmodel.Saves = saves;


            List<int> HarborPositions = docks.Harborhexes();

            List<int> PlaygroundPositions = createhexagon.Playgroundhexes();

            List<int> SixAndEightPositions = createhexagon.ChooseBestPositions();

            Random r = new Random();


            for (int i = 0; i < 37; i++)
            {
                if (PlaygroundPositions.Contains(i))
                {

                    int MaterialChooser = r.Next(1, 7);
                    string HexagonId = materialchooser.HexagonMaterial(MaterialChooser, i, SixAndEightPositions);

                    int RandomNumber = r.Next(2, 13);
                    HexagonTile hexagon = createhexagon.MakeHexagon(RandomNumber, i, HexagonId, SixAndEightPositions);

                    hexagon.Margin_left = position.Margin_Left(i);
                    hexagon.Margin_top = position.Margin_Top(i);
                    hexagon.Margin_leftNumbers = hexagon.Margin_left + 20;

                    viewmodel.Hexagons.Add(hexagon);
                }
                else
                {
                    HexagonTile hexagon = new HexagonTile
                    {
                        Margin_left = position.Margin_Left(i),
                        Margin_top = position.Margin_Top(i),
                        Id = "hexagonblue",
                    };
                     if (HarborPositions.Contains(i))
                     {
                        hexagon.Image = docks.DockType();
                        hexagon.Image_Margin_left = hexagon.Margin_left + 20;
                     }

                    viewmodel.Hexagons.Add(hexagon);
                }
            }
            return View(viewmodel);         
        }
    }
}