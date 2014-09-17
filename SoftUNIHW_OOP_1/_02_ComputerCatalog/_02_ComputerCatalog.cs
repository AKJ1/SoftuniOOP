using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class _02_ComputerCatalog
    {
        private static Component goodCPU = new Component(
            name: "Intel i7 5930X",
            manufacturer: "Intel",
            details: "Processor with 16 threads. 200W TDP",
            price: 1020.43m);

        private static Component okCPU = new Component(
            name: "AMD FX 8350",
            manufacturer: "MAD",
            details: "Processor with 8 threads. 150W TDP",
            price: 333.33m);

        private static Component badCPU = new Component(
            name: "AMD Athlon 5350K",
            manufacturer: "AMD",
            details: "Processor with 4 threads. 25W TDP",
            price: 33.20m);


        private static Component[] CPUs = new Component[]{ badCPU, okCPU, goodCPU };

        private static Component goodGPU = new Component(
            name: "Nvidia Titan Z",
            manufacturer: "Nvidia",
            details: "Very Fast GPU",
            price: 1422.22m);

        private static Component okGPU = new Component(
            name: "AMD ATI Radeon 7970",
            manufacturer: "MAD",
            details: "Pretty Fast GPU",
            price: 222.22m);

        private static Component badGPU = new Component(
            name: "AMD ATI Radeon 7570",
            manufacturer: "MAD",
            details: "Not-so-Fast GPU",
            price: 52.22m);
        private static Component[] GPUs = new Component[]{badGPU,okGPU,goodGPU};

        private static Component goodMobo = new Component(
            name: "SNSV Formula VI Gene",
            manufacturer: "SNSV",
            details: "Motherboard, 26 Sata Ports, Very Good",
            price: 345.88m);

        private static Component okMobo = new Component(
            name: "AssRock 970 Extreme3",
            manufacturer: "AssRock",
            details: "Motherboard, 6 Sata Ports",
            price: 123.21m);

        private static Component badMobo = new Component(
            name: "BioStar AM1 Mobo",
            manufacturer: "Biostar",
            details: "Motherboard, No Sata Ports, Not Good",
            price: 43.21m);
        private static Component[] mobos = new Component[]{badMobo,okMobo,goodMobo};

        private static Component goodHDD = new Component(
            name: "Seagate PE4009SSD",
            manufacturer: "Seagate",
            details: "Pretty good PCI-E SSD WITH 4 TB of storage",
            price: 2132.1m);
        private static Component okHDD = new Component(
            name: "Seagate ST9001STD",
            manufacturer: "Seagate",
            details: "Hard Drive with over 3 TB of storage",
            price: 232.1m);
        private static Component badHDD = new Component(
            name: "Seagate ST81STD",
            manufacturer: "Seagate",
            details: "Old Drive with 80GB of storage",
            price: 12.1m);
        private static Component[] HDDs = new Component[]{badHDD,okHDD,goodHDD};

        private static Component goodPSU = new Component(
            name: "Fractal Tesla 1200W",
            manufacturer: "Fractal",
            details: "Fractal PSU 8 PCI-E Headers , 20 MOLEX, 30 SATA",
            price: 500.00m);
        private static Component okPSU = new Component(
            name: "Corsair AX750 750W",
            manufacturer: "Corsair",
            details: "Corsair PSU 4 PCI-E Headers , 10 MOLEX, 15 SATA",
            price: 251.00m);
        private static Component badPSU = new Component(
            name: "Fortron 550W Bronze",
            manufacturer: "Fortron",
            details: "Fortron PSU 1 PCI-E Header , 2 MOLEX, 6 SATA",
            price: 50.00m);
        private static Component[] PSUs = new Component[]{badPSU,okPSU,goodPSU};

        private static Component goodRAM = new Component(
            name: "IBM 192GB Kit",
            manufacturer: "IBM",
            details: "Features ECC",
            price: 980.81m);
        private static Component okRAM = new Component(
            name: "Corsair 16GB Kit",
            manufacturer: "Corsair",
            details: "No ECC",
            price: 180.81m);
        private static Component badRAM = new Component(
            name: "Hynix 2GB Kit OEM",
            manufacturer: "Hynix",
            details: "No ECC",
            price: 22.81m);
        private static Component[] RAMs = new Component[]{badRAM,okRAM,goodRAM};

        private static Component goodCase = new Component(
            name: "Cooler Master Cosmos S3",
            manufacturer: "Cooler Master",
            details: "This case comes with a total of 550 LEDs.",
            price: 420.98m);
        private static Component okCase = new Component(
            name: "Fractal Design R4",
            manufacturer: "Fractal Design",
            details: "This case comes with a total of 200 LEDs.",
            price: 220.82m);
        private static Component badCase = new Component(
            name: "Daotech X8",
            manufacturer: "China",
            details: "This case comes with a total of 3 LEDs.",
            price: 20.98m);
        private static Component[] cases = new Component[]{badCase,okCase,goodCase};

        private static List<Computer> CompList = new List<Computer>();
        private static Computer currentComp;
        static void Main(string[] args)
        {
            Random seed = new Random();
            for (int i = 0; i < 100; i++)
            {
                currentComp = new Computer(CPUs[seed.Next(0, 3)], GPUs[seed.Next(0, 3)], mobos[seed.Next(0, 3)], HDDs[seed.Next(0, 3)], PSUs[seed.Next(0, 3)], cases[seed.Next(0, 3)], RAMs[seed.Next(0, 3)]);
                CompList.Add(currentComp);
            }
             CompList.Sort(
                 delegate(Computer c1, Computer c2)
                 {
                     if (c1.Price > c2.Price)
                     {
                         return 1;
                     }
                     else if (c1.Price == c2.Price)
                     {
                         return 0;
                     }
                     else
                     {
                         return -1;
                     }
                 });

             StreamWriter SR = new StreamWriter(@"C://users//public//output.txt",true, new UTF8Encoding());
             
            foreach (Computer comp in CompList.ToArray())
            {
                Console.WriteLine(comp.ToString());
                SR.WriteLine(String.Format(comp.ToString()));
            }
            Console.ReadKey();
        }
    }

    class Computer
    {
        public Component Disk { get; set; }
        public Component Motherboard { get; set; }
        public Component Processor { get; set; }
        public Component GPU { get; set; }
        public Component PSU { get; set; }
        public Component Case { get; set; }
        public Component RAM { get; set; }

        public decimal Price { get; set; }
        public override string ToString()
        {
            return String.Format("Processor:\n {0} \n Motherboard:\n {1} \n GPU:\n {2} \n PSU:\n {3} \n Disk:\n {4}\n RAM: \n {6}\n Case: \n {7}\n Price:\n {5}", this.Processor.ToString(), this.Motherboard.ToString(), this.GPU.ToString(), this.PSU.ToString(), this.Disk.ToString(), this.Price, this.RAM.ToString(), this.Case.ToString());
        }

        public Computer(Component CPU, Component GPU, Component Mobo, Component Disk, Component PSU, Component Case, Component RAM)
        {
            this.RAM = RAM;
            this.Processor = CPU;
            this.GPU = GPU;
            this.Motherboard = Mobo;
            this.Disk = Disk;
            this.Case = Case;
            this.PSU = PSU;
            this.Price = this.Processor.Price + this.GPU.Price + this.Motherboard.Price + this.Disk.Price +
                         this.PSU.Price + this.RAM.Price + this.Case.Price;
        }
    }

    class Component
    {
        

        private decimal price;
        private string manufacturer;
        private string name; 
        private string details;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public Component(string name, string manufacturer, string details, decimal price)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.details = details;
            this.price = price;
        }
        public override string ToString()
        {
            
            return String.Format("Name : {0} \n Manufacturer : {1} \n Details : {2} \n Price : {3} \n", this.name, this.manufacturer, this.details, this.price);
        }

    }
}