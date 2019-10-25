using System;

namespace NugetLab01
{
    public class Lutar
    {
        public Lutar()
        {
            this.Place = "Local projeto";
        }

        public string Place { get; set; }

        public string Golpear { get; private set; }

        public string Defender { get; private set; }

        public string GolpearAction(string action)
        {
            return this.Golpear = action;
        }

        public string DefenderAction(string action)
        {
            return this.Golpear = action;
        }


    }
}
