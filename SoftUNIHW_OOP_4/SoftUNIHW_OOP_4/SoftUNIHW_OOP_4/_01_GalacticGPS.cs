using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_4
{
    class GalacticGPS
    {
        public static void HomeLocation()
        {
            Location home = new Location(18.037986, 28.870098, Planet.Earth);
            Console.WriteLine("Home is at {0}", home);
        }
    }

    struct Location
    {
        public double Latitude;
        public double Longitude;
        public Planet Planet;

        public Location(double longtitude, double latitude, Planet planet )
        {
            this.Longitude = longtitude;
            this.Latitude = latitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }

    enum Planet
    {
        Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
    }
}
