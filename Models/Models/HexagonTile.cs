using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Models
{
    public class HexagonTile
    {
        public string Hexagonnumber { get; set; }
        public string Id { get; set; }
        public int Font_size { get; set; }
        public string Color { get; set; }
        public int Margin_left { get; set; }
        public int Margin_top { get; set; }
        public string Class { get; set; }
        public int Margin_leftNumbers { get; set; }
        public int Number { get; set; }
        public string Image { get; set; }
        public int Image_Margin_left { get; set; }
        public int BestNumber { get; set; }
        public int BestNumber_Margin_Top { get; set; }
    }

}