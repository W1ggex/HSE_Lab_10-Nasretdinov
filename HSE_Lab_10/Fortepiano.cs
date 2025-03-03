namespace HSE_Lab_10
{

        internal class Fortepiano : Instrument
    {
        private string name;
        private string keyLayout;
        private int keyNumber;

        public Fortepiano(string name, string keyLayout, int keyNumber) : base(name)
        {
            this.name = name;
            this.keyLayout = keyLayout;
            this.keyNumber = keyNumber;
        }
    }
}