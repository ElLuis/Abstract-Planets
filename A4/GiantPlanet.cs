using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    public interface IHasMoons
    {
        bool HasMoons();
    }

    public interface IHasRings
    {
        bool HasRings();
    }

    public interface IHabitable
    {
        bool Habitable();
    }

    class GiantPlanet : Planet, IHasMoons,IHasRings
    {
        private string _type; //either Gas or Ice
        public string Type { get { return _type; } set { _type = value; } }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
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
