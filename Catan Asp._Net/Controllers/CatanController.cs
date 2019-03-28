using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catan_Asp._Net.Models.Viewmodel;
using Catan_Asp._Net.Models;
using System.Data.SqlClient;
using System.Data;
using Catan_Asp._Net.Controllers.CreateHexagons;

namespace Catan_Asp._Net.Controllers
{
    public class CatanController : Controller
    {
        HexagonPosition position = new HexagonPosition();
        Materials materialchooser = new Materials();
        Drawnumber drawnumber = new Drawnumber();
        Docks docks = new Docks();

        // GET: Catan
        public ActionResult Index()
        {
            int[] playgroundhexes = new int[] { 5, 6, 7, 10, 11, 12, 13, 16, 17, 18, 19, 20, 23, 24, 25, 26, 29, 30, 31 };
            int[] harborhexes = new int[] { 0, 2, 8, 9, 21, 22, 32, 33, 35 };

            CatanViewmodel viewmodel = new CatanViewmodel
            {
                Saves = new List<Save>(),
                Hexagons = new List<HexagonTile>()
            };

            List<int> HarborPositions = new List<int>();
            HarborPositions.AddRange(harborhexes);

            List<int> PlaygroundHexes = new List<int>();
            PlaygroundHexes.AddRange(playgroundhexes);

            for(int i = 0; i < 37; i++)
            {
                HexagonTile hexagon = new HexagonTile
                {
                    Margin_left = position.Margin_Left(i),
                    Margin_top = position.Margin_Top(i)
                };
                if (PlaygroundHexes.Contains(i))
                {
                    string HexagonId = materialchooser.ChooseMaterial();
                    hexagon.Margin_leftNumbers = position.Margin_LeftNumbers(hexagon.Margin_left);
                    if (HexagonId != "hexagondesert")
                    {
                        hexagon.Id = HexagonId;
                        hexagon.Number = drawnumber.MakeNumber();
                        drawnumber.MakeHexagon(hexagon);
                    }
                    else
                    {
                        hexagon.Id = HexagonId;
                        hexagon.Class = "rover";
                    }
                }
                //Make Surrounding Hexagons Blue\\
                else
                {
                    hexagon.Id = "hexagonblue";
                    hexagon.Image_Margin_left = hexagon.Margin_left + 20;

                    if (HarborPositions.Contains(i))
                    {       
                        hexagon.Image = docks.DockType();
                    }
                }
                viewmodel.Hexagons.Add(hexagon);
            }
            return View(viewmodel);         
        }
    }
}