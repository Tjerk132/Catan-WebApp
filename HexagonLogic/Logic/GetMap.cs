using HexagonLogic.CreateHexagons;
using HexagonLogic.CreateDocks;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonLogic.Logic
{
    public class GetMap
    {
        HexagonPosition HexagonPosition = new HexagonPosition();
        Materials materialchooser = new Materials();
        MakeHexagon createhexagon = new MakeHexagon();
        Docks docks = new Docks();
        Docktype docktype = new Docktype();
        Positions positions = new Positions();

        public List<HexagonTile> GetHexagons()
        {
            List<int> HarborPositions =  positions.Harborhexes();

            List<int> PlaygroundPositions = positions.Playgroundhexes();

            List<int> SixAndEightPositions = positions.SixandEightPositions();

            Random r = new Random();

            List<HexagonTile> hexagons = new List<HexagonTile>();
            List<DockLines> dockLines = new List<DockLines>();
            for (int i = 0; i < 37; i++)
            {
                if (PlaygroundPositions.Contains(i))
                {
                    int MaterialChooser = r.Next(1, 7);
                    string HexagonId = materialchooser.HexagonMaterial(MaterialChooser, i, SixAndEightPositions);

                    int RandomNumber = r.Next(2, 13);
                    HexagonTile hexagon = createhexagon.CreateHexagon(RandomNumber, i, HexagonId, SixAndEightPositions);

                    hexagon.Margin_left = HexagonPosition.Margin_Left(i);
                    hexagon.Margin_top = HexagonPosition.Margin_Top(i);
                    hexagon.Margin_leftNumbers = hexagon.Margin_left + 20;

                    hexagons.Add(hexagon);
                }
                else
                {
                    HexagonTile hexagon = new HexagonTile
                    {
                        Margin_left = HexagonPosition.Margin_Left(i),
                        Margin_top = HexagonPosition.Margin_Top(i),
                        Id = "hexagonblue",
                    };

                    if (HarborPositions.Contains(i))
                    {
                        hexagon.Image = docktype.DockType();
                        hexagon.Image_Margin_left = hexagon.Margin_left + 20;
                    }
                    hexagons.Add(hexagon);
                }
            }
            return hexagons;
        }
        public List<BestPoint> GetTopPositions()
        {
            return createhexagon.TopDrie();
        }
        public List<DockLines> GetDockLines()
        {
            List<DockLines> dockLines = new List<DockLines>();

            for (int i = 1; i < 19; i++)
            {
                DockLines dockLine = docks.DockLine(i);
                dockLines.Add(dockLine);
            }
            return dockLines;
        }
    }
}
