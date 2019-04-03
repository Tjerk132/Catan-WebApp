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

            CatanViewmodel viewmodel = new CatanViewmodel
            {
                Saves = new List<Save>(),
                Hexagons = new List<HexagonTile>()
            };

            SqlConnection conn = new SqlConnection(
                @"Server=mssql.fhict.local;
                Database=dbi386599;
                User Id=dbi386599;
                Password=12345;"
            );
            using (conn)
            {
                conn.Open();
                string query =  "SELECT * FROM [Saves]";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                conn.Close();
                foreach (DataRow dr in dtResult.Rows)
                {
                    Save save = new Save();

                    save.Name = dr[1].ToString();

                    DateTime.TryParse(dr[2].ToString(), out DateTime Time);
                    save.Time = Time;

                    viewmodel.Saves.Add(save);
                }
            }

            int[] harborhexes = new int[] { 0, 2, 8, 9, 21, 22, 32, 33, 35 };
            List<int> HarborPositions = new List<int>();
            HarborPositions.AddRange(harborhexes);

            int[] playgroundhexes = new int[] { 5, 6, 7, 10, 11, 12, 13, 16, 17, 18, 19, 20, 23, 24, 25, 26, 29, 30, 31 };
            List<int> PlaygroundHexes = new List<int>();
            PlaygroundHexes.AddRange(playgroundhexes);


            Random r = new Random();
            int ChooseBestPositions = r.Next(1, 5);

            int[] positions = new int[] { };
            // int[] to choose the numbers 6 & 8
            switch (ChooseBestPositions)
            {
                case 1:
                    positions = new int[] { 5, 7, 16, 18 };
                    break;
                case 2:
                    positions = new int[] { 6, 10, 13, 18 };
                    break;
                case 3:
                    positions = new int[] { 18, 20, 29, 31 };
                    break;
                case 4:
                    positions = new int[] { 18, 23, 26, 30 };
                    break;
            }
            //List int that contains the hexes for 6 & 8
            List<int> SixAndEightPositions = new List<int>();
            SixAndEightPositions.AddRange(positions);

            for(int i = 0; i < 37; i++)
            {
                if (playgroundhexes.Contains(i))
                {

                    int MaterialChooser = r.Next(1, 7);
                    string HexagonId = materialchooser.HexagonMaterial(MaterialChooser, i, SixAndEightPositions);

                    int RandomNumber = r.Next(2, 13);
                    HexagonTile hexagon = drawnumber.MakeHexagon(RandomNumber, i, HexagonId, SixAndEightPositions);

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
                     if (harborhexes.Contains(i))
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