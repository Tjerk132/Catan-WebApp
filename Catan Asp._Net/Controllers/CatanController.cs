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
            const string connectionString = @"Server=mssql.fhict.local;Database=dbi386599;User Id=dbi386599;Password=12345;";
            SqlConnection conn = new SqlConnection(connectionString);
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

            List<int> HarborPositions = new List<int>();
            HarborPositions.AddRange(harborhexes);

            List<int> PlaygroundHexes = new List<int>();
            PlaygroundHexes.AddRange(playgroundhexes);

            Random r = new Random();
            int ChooseBestPositions = r.Next(1, 5);
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

                        hexagon.Number = drawnumber.MakeNumber(i, ChooseBestPositions);
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