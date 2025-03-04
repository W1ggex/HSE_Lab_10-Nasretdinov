using Library10;
namespace HSE_Lab_10;

internal class Program
{
    static void Main(string[] args)
    {
        
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
            return average / count;
        return 0;
    }

    public static int FixedPSEGuitarStringNumber(Instrument[] instruments)
    {
        int count = 0;
        foreach (var instrument in instruments)
        {
            ElectricGuitar electricGuitar = instrument as ElectricGuitar;
            if (electricGuitar !=null)    
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
                    max = fortepiano.KeyNumber;
            }
        }
        return max;
    }

}