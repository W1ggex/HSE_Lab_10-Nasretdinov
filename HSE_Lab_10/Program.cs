using Library10;
namespace HSE_Lab_10;

internal class Program
{
    static void Main()
    {
        Instrument[] instruments = new Instrument[20];
        var rnd = new Random();
        for (int i = 0; i < instruments.Length; i++)
        {
            int choice = rnd.Next(0, 4);   
            if(choice == 0)
                instruments[i] = new Guitar();
            else if(choice == 1)
                instruments[i] = new ElectricGuitar();
            else if(choice == 2)
                instruments[i] = new Fortepiano();
            else
                instruments[i] = new Instrument();   
            
            instruments[i].RandomInit();
        }
        
        Console.WriteLine("Default:");
        foreach (var instrument in instruments)
            Console.WriteLine(instrument.Name);

        Console.WriteLine("\nVirtual:");
        foreach (var instrument in instruments)
            Console.WriteLine(instrument.Show());
        
        Console.WriteLine($"\nAverage Guitar has {AverageGuitarStringNumber(instruments).ToString("F2")} strings");
        Console.WriteLine($"All fixed PS E-Guitars have {FixedPSEGuitarStringNumber(instruments)} strings combined");
        Console.WriteLine($"Octavian Fortepiano has a maximum of {MaxKeyNumberOfOctavianFortepiano(instruments)} keys");
        
    }

    public static double AverageGuitarStringNumber(Instrument[] instruments)
    {
        double average = 0;
        int count = 0;
        foreach (var instrument in instruments)
        {
            if (instrument is Guitar guitar)
            {
                count++;
                average += guitar.StringCount;
            }
            
            if (instrument is ElectricGuitar electricGuitar)
            {
                count++;
                average += electricGuitar.StringCount;
            }
        }
            if(count > 0)
                average /= count;
            else
                average = 0;
            return average;
    }

    public static int FixedPSEGuitarStringNumber(Instrument[] instruments)
    {
        int count = 0;
        foreach (var instrument in instruments)
        {
            ElectricGuitar electricGuitar = (instrument as ElectricGuitar)!;
            if (electricGuitar !=null)
                if(electricGuitar.PowerSupply == "Fixed power source")
                    count += electricGuitar.StringCount;
        }
        return count;
    }

    public static int MaxKeyNumberOfOctavianFortepiano(Instrument[] instruments)
    {
        int max = 0;
        foreach (var instrument in instruments)
        {
            if (instrument.GetType() == typeof(Fortepiano))
            {
                Fortepiano fortepiano = (Fortepiano)instrument;
                if(fortepiano.KeyNumber > max)
                    if(fortepiano.KeyLayout == "Octavian")
                        max = fortepiano.KeyNumber;
            }
        }
        return max;
    }

}