using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    public interface HasMoons
    {
        bool CountMoon();
    }

    public interface HasRings
    {
        bool CountRing();
    }

    class GiantPlanet : Planet, HasMoons,HasRings
    {
        private string _type; //either Gas or Ice
        public string Type { get { return _type; } set { _type = value; } }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
        }

        public bool CountMoon()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }

        public bool CountRing()
        {
            if (RingCount > 0)
                return true;
            else
                return false;
        }
    }
}
