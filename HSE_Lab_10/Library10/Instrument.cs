namespace Library10
{
    
    internal class Instrument
    {
        protected string[] names =
            { "Harmonica", "Sax", "Violin", "Cello", "Trumpet", "Flute", "Accordion", "Trombone", "Harp", "Bassoon" };
        //поля
        protected string name;

        public string Name
        {
            get => name;
            set => name = value;
         }       
        
        //конструкторы
        public Instrument(){}
        
        public Instrument(string name)
        {
            this.name = name;
        }
        
        //методы
        public void Show()
        {
            Console.WriteLine($"The instrument is called {Name}");
        }
        
        public virtual void Init()
        {
            Console.Write("Enter the name of the instrument: ");
            Name = Console.ReadLine() ?? throw new InvalidOperationException();
        }
        
        public virtual void RandomInit()
        {
            var rnd = new Random();
            Name = names[rnd.Next(10)];
        }
        
        public override bool Equals(object obj)
        {
            if (obj is Instrument other)
                return Name == other.Name;
            return false;
        }


    }
    
}