# Abstract-Planets
COMP123 - Programming 2 - Assignment 4 - Inheritance
    class Program
    {
        //Luis Sanchez - Assignment 4 - 28/07/2017
        //300796405
        //Inheritance - Ch.10 | worth 10%
        //Main class where objects are instantiated and methods are used
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116.464, 5.6836, "Ice");
            Console.WriteLine(giantPlanet);
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12.742, 5.972, true);
            Console.WriteLine(terrestrialPlanet);
            Program.WaitForAnyKey();

        }
    }
    
       //Luis Sanchez - Assignment 4 - 28/07/2017
    //300796405
    //Inheritance - Ch.10 | worth 10%
    //This class is the parent class where the different types of planets derive from.
    abstract class Planet
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }

        public double Mass
        {
            get
            {
                return _mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return _moonCount;
            }
            set
            {
                _moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                _orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return _ringCount;
            }
            set
            {
                _ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
            set
            {
                _rotationPeriod = value;
            }
        }

        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }

        public override string ToString()
        {
            return string.Format("{0} - diameter = {1} | mass = {2} ", Name, Diameter, Mass);
        }
    }
    
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
    
       //Luis Sanchez - Assignment 4 - 28/07/2017
    //300796405
    //Inheritance - Ch.10 | worth 10%
    //This interface is used by the Planet classes and returns a boolean variable depending on whether or not
    //a planet has Rings.

    public interface IHasRings
    {
        bool HasRings();
    }
    
        //Luis Sanchez - Assignment 4 - 28/07/2017
    //300796405
    //Inheritance - Ch.10 | worth 10%
    //This interface is used by the Planet classes and returns a boolean variable depending on whether or not
    //a planet is habitable.

    public interface IHabitable
        {
            bool Habitable();
        }
        
            //Luis Sanchez - Assignment 4 - 28/07/2017
    //300796405
    //Inheritance - Ch.10 | worth 10%
    //This interface is used by the Planet classes and returns a boolean variable depending on whether or not
    //a planet has Moons.

    public interface IHasMoons
    {
        bool HasMoons();
    }
