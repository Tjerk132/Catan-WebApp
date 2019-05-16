using System;
using System.Collections.Generic;

namespace HexagonLogic.CreateHexagons
{
    public class Positions
    {
        public List<int> SixandEightPositions()
        {
            // int[] to choose the numbers 6 & 8
            int[] positions = new int[] { };

            Random r = new Random();
            int ChooseBestPositions = r.Next(1, 5);
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

            return SixAndEightPositions;
        }
        public List<int> Playgroundhexes()
        {
            int[] playgroundhexes = new int[] { 5, 6, 7, 10, 11, 12, 13, 16, 17, 18, 19, 20, 23, 24, 25, 26, 29, 30, 31 };
            List<int> PlaygroundHexes = new List<int>();
            PlaygroundHexes.AddRange(playgroundhexes);
            return PlaygroundHexes;
        }
    }
}