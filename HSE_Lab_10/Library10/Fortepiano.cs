namespace Library10
{

        internal class Fortepiano : Instrument
    {
        private string[] names = {"A", "B", "D", "M", "O", "S"};
        private string keyLayout;
        private string[] keyLayouts = {"Octavian", "Scalic", "Digital"};
        private int keyNumber;

        public string KeyLayout
        {
            get => keyLayout;
            set
            {
                if(!keyLayouts.Contains(value))
                    throw new ArgumentException("Key Layout must be one of the following:\nOctavian\nScalic\nDigital");
                keyLayout = value;
            }
        }
        
        public int KeyNumber
        {
            get => keyNumber;
            set
            {
                if(value > 108 || value < 76)
                    throw new ArgumentException("Key Number must be between 76 and 108");
                keyNumber = value;
            }
        }
        
        //конструкторы
        public Fortepiano(){}
        
        public Fortepiano(string name, string keyLayout, int keyNumber) : base(name)
        {
            this.name = name;
            this.keyLayout = keyLayout;
            this.keyNumber = keyNumber;
        }
        
        //методы
        public void Show()
        {
            Console.WriteLine($"The Fortepiano is called {Name}, it has {KeyNumber} keys in the {keyLayout} layout.");    
        }
        
        public override void Init()
        {
            base.Init();
            Console.Write("Enter the Fortepiano's key layout: ");
            KeyLayout = Console.ReadLine();
            Console.Write("Enter the Fortepiano's key number: ");
            KeyNumber = Convert.ToInt32(Console.ReadLine());
        }

        public override void RandomInit()
        {
            Name = "Steinway & Sons' Model " + names[new Random().Next(0, names.Length)];
            KeyLayout = keyLayouts[new Random().Next(0, keyLayouts.Length)];
            KeyNumber = new Random().Next(76, 109);
        }
        
        public override bool Equals(object? obj)
        {
            return obj is Fortepiano other && base.Equals(other) && KeyNumber == other.KeyNumber && KeyLayout == other.KeyLayout;
        }
        
    }
}