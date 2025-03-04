using System.Linq;

namespace HSE_Lab_10
{

    internal class ElectricGuitar : Instrument
    {
        private string powerSupply;
        private string[] powerSupplies = { "Batteries", "Accumulator", "Fixed power source", "USB" };
        private string[] names = {"Les Paul", "Slash", "Adam Jones", "ES-335", "SG", "Flying V"};
        
            
        public string PowerSupply
                {
                    get => powerSupply;
                    set
                    {
                        if(!powerSupplies.Contains(value))
                            throw new ArgumentException("Power supply must be one of the following:\nBatteries\nAccumulator\nFixed power source\nUSB");
                        powerSupply = value;
                    }
                }
        
        //конструкторы
        public ElectricGuitar(){}
        
        public ElectricGuitar(string name, string powerSupply) : base(name)
        {
            this.name = name;
            this.powerSupply = powerSupply;
        }
        
        //методы
        public void Show()
        {
            Console.WriteLine($"The E-Giutar is called {Name}, it is powered by a(n) {PowerSupply}");    
        }
        
        public override void Init()
        {
            base.Init();
            Console.Write("Enter the E-Guitar power supply: ");
            PowerSupply = Console.ReadLine();
        }
        
        public override void RandomInit()
        {
            Name = "Gibson " + names[new Random().Next(0, names.Length)];
            PowerSupply = powerSupplies[new Random().Next(0, powerSupplies.Length)];
        }
        
        public override bool Equals(object? obj)
        {
            return obj is ElectricGuitar other && base.Equals(other) && PowerSupply == other.PowerSupply;
        }
    }
}
