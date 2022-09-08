using System;
namespace Galactica
{
    internal class SpaceObject
    {
        //Oprettelse af Enum
        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }

        public int ID { get; set; }
        public string? Name { get; set; }
        public Position position {get; set; }
        // int x, y;
        public class Position : SpaceObject
        {
            public Position()
            {
            }

            public Position(int v1, int v2)
            {
                V1 = v1;
                V2 = v2;
            }

            public double X { get; set; }
            public double Y { get; set; }
            public int V1 { get; }
            public int V2 { get; }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }

        }

    }
}

