using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Models;

namespace Catan.Models.Viewmodel
{
    public class CatanViewmodel
    {
        public List<Save> Saves { get; set; }
        public List<HexagonTile> Hexagons { get; set; }
        public List<DockLines> DockLines { get; set; }
        public List<BestPoint> BestPositions { get; set; }
    }
}