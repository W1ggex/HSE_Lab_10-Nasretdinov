 namespace HSE_Lab_10
 {
 
    internal class Guitar : Instrument
    {
        private string name;
        private int stringCount;
        
        public int StringCount
        {
            get
            {return stringCount;}
            set
            {
                if(value <= 4 || value > 6)
                    throw new ArgumentException("String count must be between 4 and 6");
                stringCount = value;
            }
        }
         
        public Guitar()
            {
                StringCount = 6;
                name = "Gibson J-35";
            }
        
        public Guitar(string name, int stringCount): base(name)
        {
            this.name = name;
            this.stringCount = stringCount;
        }
        
        public void Show()
        {
            Console.WriteLine($"The giutar is called {Name}, it has {StringCount} strings");    
        }
    }
 }
