using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    //Luis Sanchez - Assignment 4 - 28/07/2017
    //300796405
    //Inheritance - Ch.10 | worth 10%
    //This class is a subclass of Planet and represents the biggest planets. It includes two types of planets
    //"Ice" and "Gas"

    class GiantPlanet : Planet, IHasMoons,IHasRings
    {
        private string _type; //either Gas or Ice
        public string Type { get { return _type; } set { _type = value; } }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
        }

        public override string ToString() //A more suitable ToString() method for this subclass
        {
            return string.Format("{0} - diameter = {1} | mass = {2} | type: {3}", Name, Diameter, Mass,Type);
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }

        public bool HasRings()
        {
            if (RingCount > 0)
                return true;
            else
                return false;
        }
    }
}
