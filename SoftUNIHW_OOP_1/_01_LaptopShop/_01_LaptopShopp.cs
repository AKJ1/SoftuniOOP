using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Dell", "Intel i5 4300U", "Intel HD4400", 13.3f, new Battery(47), (decimal) 1250.50);
            Console.WriteLine(laptop.ToString());
            Console.ReadKey();
        }
    }

    class Laptop
    {
        private string manufacturer;
        private string processor;
        private string graphics;
        private float screenSize;
        private decimal price;
        private Battery battery;

        public Laptop(string manufacturer, string processor, string graphics, float screenSize, Battery battery, decimal price)
        {
            this.battery = battery;
            this.screenSize = screenSize;
            this.processor = processor;
            this.graphics = graphics;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length > 0)
                {
                    manufacturer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Argument is not a string!");
                }
            }
        }

        public float ScreenSize
        {
            get { return screenSize; }
            set {
                if (value >= 7 && value <= 18.5)
                {
                    screenSize = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Screen size not in range [7.0...18.4]");
                }
            }
        }

        public string Processor
        {
            get { return processor; }
            set
            {
                if (value.Length > 0)
                {
                    processor = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Argument is not a string!");
                }
            }
        }
        public string Graphics
        {
            get { return graphics; }
            set
            {
                if (value.Length > 0)
                {
                    graphics = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Argument is not a string!");
                }
            }
        }

        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public override string ToString()
        {
            return string.Format("Manufacturer : {0} \n Processor : {1} \n Graphics : {2} \n ScreenSize : {3} \n Battery : {4} \n Cost : {5}", this.manufacturer, this.processor, this.graphics, this.screenSize.ToString(), this.battery.ToString(),this.price);
        }
    }

    class Battery
    {
        private int capacityWh;

        public Battery()
        {
            capacityWh = 0;
        }

        public int CapacityWh
        {
            get { return capacityWh; }
            set {
                if (value > 0)
                {
                    capacityWh = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Battery(int wattHours)
        {
            if (wattHours > 0)
            {
                this.capacityWh = wattHours;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

        public override string ToString()
        {
            return this.capacityWh.ToString() + "Wh";
        }
    }
}
