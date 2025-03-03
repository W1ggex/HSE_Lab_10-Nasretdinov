using System.Linq;

namespace HSE_Lab_10
{

    internal class ElectricGuitar : Instrument
    {
        private string name;
        private string powerSupply;
        private string[] powerSupplies = { "Batteries", "Accumulator", "Fixed power source", "USB" };

        public string Name
            {
                get
                {return name;}
                set
                {name = value;}
            }
            
        public string PowerSupply
                {
                    get
                    {return powerSupply;}
                    set
                    {
                        if(!powerSupplies.Contains(value))
                            throw new ArgumentException("Power supply must be one of the following:\nBatteries\nAccumulator\nFixed power source\nUSB");
                        powerSupply = value;
                    }
                }
        public ElectricGuitar():base(){}
        
        public ElectricGuitar(int sth)
        {
            this.name = "Gibson SG Standard";
            this.powerSupply = powerSupplies[2];
        }
        
        public ElectricGuitar(string name, string powerSupply) : base(name)
        {
            this.name = name;
            this.powerSupply = powerSupply;
        }
        
        public void Show()
        {
            Console.WriteLine($"The E-giutar is called {Name}, it is powered by a(n) {PowerSupply}");    
        }
    }
}
