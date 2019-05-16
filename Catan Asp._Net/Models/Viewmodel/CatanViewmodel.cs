using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catan_Asp._Net.Models;
using Models.Models;

namespace Catan_Asp._Net.Models.Viewmodel
{
    public class CatanViewmodel
    {
        public List<Save> Saves { get; set; }
        public List<HexagonTile> Hexagons { get; set; }
        public List<DockLines> DockLines { get; set; }
        public List<Toppunt> topDrie { get; set; }
    }
}