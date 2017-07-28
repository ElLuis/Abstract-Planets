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

    class GiantPlanet : Planet
    {
        private string _type; //either Gas or Ice
        public string Type { get { return _type; } set { _type = value; } }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
        }
    }
}
