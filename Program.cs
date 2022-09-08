using System;
using static Galactica.SpaceObject;
namespace Galactica
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Info om Stjerne, måner og planeter
            Star sun = new Star()
            {
                ID = 1,
                Name = "Sun",
                Type = StarType.YellowDwarf.ToString(),
                Temperature = 5500

            };
            Planet mercury = new Planet()
            {
                ID = 1,
                Name = "Mercury",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 4880000,
                RotationPeriod = 1407,
                RevolutionPeriod = 176,
                

            };
            Planet venus = new Planet()
            {
                ID = 2,
                Name = "Venus",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 6051800,
                RotationPeriod = 5832,
                RevolutionPeriod = 116
            };
            Planet earth = new Planet()
            {
                ID = 3,
                Name = "Earth",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 12742000,
                RotationPeriod = 24,
                RevolutionPeriod = 365
            };
            Planet mars = new Planet()
            {
                ID = 4,
                Name = "Mars",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 6779000,
                RotationPeriod = 25,
                RevolutionPeriod = 687
            };
            Planet uranus = new Planet()
            {
                ID = 5,
                Name = "Uranus",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 50724000,
                RotationPeriod = 17,
                RevolutionPeriod = 30660

            };
            Planet neptune = new Planet()
            {
                ID = 6,
                Name = "Neptune",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Planet jupiter = new Planet()
            {
                ID = 7,
                Name = "Jupiter",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 139820000,
                RotationPeriod = 10,
                RevolutionPeriod = 4300,

            };
            Planet saturn = new Planet()
            {
                ID = 8,
                Name = "Saturn",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 116460000,
                RotationPeriod = 10.2,
                RevolutionPeriod = 11000
            };
            Moon luna = new Moon()
            {
                ID = 1,
                Name = "Luna",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon titan = new Moon()
            {
                ID = 2,
                Name = "Titan",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
                
            };
            Moon phobos = new Moon()
            {
                ID = 3,
                Name = "Phobos",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon europe = new Moon()
            {
                ID = 4,
                Name = "Europe",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon deimos = new Moon()
            {
                ID = 5,
                Name = "Deimos",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon ganymedes = new Moon()
            {
                ID = 6,
                Name = "Ganymedes",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon io = new Moon()
            {
                ID = 7,
                Name = "Io",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon mimas = new Moon()
            {
                ID = 8,
                Name = "Mimas",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial.ToString(),
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };

            //Bliver tilfæjet til Liste
            sun.planetList.Add(mercury);
            sun.planetList.Add(venus);
            sun.planetList.Add(earth);
            sun.planetList.Add(mars);
            sun.planetList.Add(jupiter);
            sun.planetList.Add(saturn);
            sun.planetList.Add(uranus);
            sun.planetList.Add(neptune);
            earth.moonList.Add(luna);
            saturn.moonList.Add(titan);
            saturn.moonList.Add(mimas);
            mars.moonList.Add(phobos);
            mars.moonList.Add(deimos);
            jupiter.moonList.Add(europe);
            jupiter.moonList.Add(ganymedes);
            jupiter.moonList.Add(io);

            //Udskrivning af lister
            foreach (var Planet in sun.planetList)
            {
                Console.WriteLine($"ID: {Planet.ID}\n" + $"Name: {Planet.Name}\n" + $"Type: {Planet.Type}\n" + $"Diameter i meter: {Planet.Diameter}\n" + $"RotationPeriod: {Planet.RotationPeriod}\n" + $"RevolutionPeriod: {Planet.RevolutionPeriod}\n");
                foreach (var Moon in Planet.moonList)
                {
                    Console.WriteLine($"\tID: {Moon.ID}\n" + $"\tName: {Moon.Name}\n" + $"\tType: {Moon.Type}\n" + $"Diameter i meter: {Moon.Diameter}\n" + $"RotationsPeriod: {Moon.RotationPeriod}\n" + $"RevolutionsPeriod {Moon.RevolutionPeriod}\n");
                    Console.WriteLine($"\n Distance from moon to planet: {Planet.Distance(Moon.position, Planet.position)}");
                }
            }
        }
    }
}