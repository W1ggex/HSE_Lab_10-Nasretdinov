namespace HSE_Lab_10
{
    
    internal class Instrument
    {
        protected string name;

        public string Name
        {
             get
                {return name;}
             set
                {name = value;}
         }       
        
        public Instrument()
        {
            this.name = "SilverStar Harmonica";
        }
        
        public Instrument(string name)
        {
            this.name = name;
        }
        
        public void Show()
        {
            Console.WriteLine($"The instrument is called {Name}");
        }
    }
    
}