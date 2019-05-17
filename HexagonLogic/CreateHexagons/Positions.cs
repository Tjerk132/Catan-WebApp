using System;
using System.Collections.Generic;

namespace HexagonLogic.CreateHexagons
{
    public class Positions
    {
        public List<int> SixandEightPositions()
        {
            int[] positions = new int[] { };

            Random r = new Random();
            int ChooseBestPositions = r.Next(1, 7);
            switch (ChooseBestPositions)
            {//0,1,2,3,4,8,9,14,15,21,22,27,28,,32,33,34,35,36
                case 1:
                    positions = new int[] { 5, 13, 16, 26 };//
                    break;
                case 2:
                    positions = new int[] { 6, 16, 25, 29 };
                    break;
                case 3:
                    positions = new int[] { 7, 10, 18, 26 };//
                    break;
                case 4:
                    positions = new int[] { 10, 13, 23, 26 };//
                    break;
                case 5:
                    positions = new int[] { 11, 16, 20, 30 };//
                    break;
                case 6:
                    positions = new int[] { 6, 17, 20, 31 };//
                    break;
            }
            //List int that contains the hexes for 6 & 8
            List<int> SixAndEightPositions = new List<int>();
            SixAndEightPositions.AddRange(positions);

            return SixAndEightPositions;
        }
        public List<int> Playgroundhexes()
        {
            int[] playgroundhexes = new int[] { 5, 6, 7, 10, 11, 12, 13, 16, 17, 18, 19, 20, 23, 24, 25, 26, 29, 30, 31 };
            List<int> PlaygroundHexes = new List<int>();
            PlaygroundHexes.AddRange(playgroundhexes);
            return PlaygroundHexes;
        }

        public List<int> Harborhexes()
        {
            int[] harborhexes = new int[] { 0, 2, 8, 9, 21, 22, 32, 33, 35 };
            List<int> HarborPositions = new List<int>();
            HarborPositions.AddRange(harborhexes);
            return HarborPositions;
        }
    }
}