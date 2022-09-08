using System;
namespace Galactica
{
    public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    internal class Planet : SpaceObject
    {

       public string? Type { get; set; }
        public double Diameter { get; set; }
        public double RotationPeriod { get; set; }
        public double RevolutionPeriod { get; set; }
        public List<Moon> moonList = new List<Moon>();
        public double Distance(Position first, Position second)
          
            
         
        {

            double distance = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));
         
            return distance;

        }
       
    }
    
}


    