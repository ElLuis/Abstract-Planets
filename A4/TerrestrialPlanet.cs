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
    //This class is a child of Planet .It has oxygen as a more specific feature. It represents habitable planets.

    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public bool Oxygen { get { return _oxygen; } set { _oxygen = value; } }

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }

        public override string ToString() //A more suitable ToString() method for this subclass
        {
            return string.Format("{0} - diameter = {1} | mass = {2} | oxygen: {3}", Name, Diameter, Mass, Oxygen ? "Yes" : "No");
        }

        public bool Habitable()
        {
            if (_oxygen == true)
                return true;
            else
                return false;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }
    }
}
