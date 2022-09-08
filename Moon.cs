using System;
namespace Galactica
{
    //kan ikke instanieres
    sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }
    }

}