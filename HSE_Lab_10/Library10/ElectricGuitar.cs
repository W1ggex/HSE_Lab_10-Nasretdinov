using System.Linq;

namespace Library10
{

    internal class ElectricGuitar : Guitar
    {
        private string powerSupply;
        private string[] powerSupplies = { "Batteries", "Accumulator", "Fixed power source", "USB" };
        private string[] names = {"Les Paul", "Slash", "Adam Jones", "ES-335", "SG", "Flying V"};
        //private int stringCount;
        
            
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
        
        public ElectricGuitar(string name, string powerSupply, int stringCount) : base(name, stringCount)
        {
            this.powerSupply = powerSupply;
        }
        
        //методы
        public override string Show()
        {
            return $"The E-Giutar is called {Name}, it is powered by a(n) {PowerSupply} and has {StringCount} strings";    
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
            StringCount = new Random().Next(4, 7);
            
        }
        
        public override bool Equals(object? obj)
        {
            return obj is ElectricGuitar other && base.Equals(other) && PowerSupply == other.PowerSupply;
        }
    }
}
