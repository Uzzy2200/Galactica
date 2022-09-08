using System;
using static Galactica.SpaceObject;

namespace Galactica
{
    //  Star nedarver fra Spaceobject
    internal class Star : SpaceObject
    {
        //Properties
        public string Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> planetList = new List<Planet>();
        public new Position position { get; set; }
        public Star()
        {
            //Solens udgangspunkt
            this.position = new Position(0, 0);

        }
        public void Distance(Position first, Position second)



        {

            double distance = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));


        }
    }
}
