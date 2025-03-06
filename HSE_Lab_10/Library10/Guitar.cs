 namespace Library10
 {
 
    internal class Guitar : Instrument
    {
        private int stringCount;
        private string[] names = {"L-00", "SJ-200", "J-45", "Hummingbird", "J-185"};
        
        public int StringCount
        {
            get => stringCount;
            set
            {
                if(value < 4 || value > 6)
                    throw new ArgumentException("String count must be between 4 and 6");
                stringCount = value;
            }
        }
         
        //конструкторы
        public Guitar(){}
        
        public Guitar(string name, int stringCount): base(name)
        {
            this.name = name;
            this.stringCount = stringCount;
        }
        
        //методы
        public override void Show()  //string
        {
            Console.WriteLine($"The Guitar is called {Name}, it has {StringCount} strings");    
        }
        
        public override void Init()
        {
            base.Init();
            Console.Write("Enter the amount of string between 4 and 6: ");
            StringCount = Convert.ToInt32(Console.ReadLine());
        }
        
        public override void RandomInit()
        {
            Name = "Gibson " + names[new Random().Next(0, names.Length)];
            StringCount = (new Random().Next(4, 7));
        }
        
        public override bool Equals(object? obj)
        {
            return obj is Guitar other
                   && base.Equals(other)
                   && StringCount == other.StringCount;
        }
    }
 }
