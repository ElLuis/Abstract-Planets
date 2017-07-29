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
    //This interface is used by the Planet classes and returns a boolean variable depending on whether or not
    //a planet has Moons.

    public interface IHasMoons
    {
        bool HasMoons();
    }
}
