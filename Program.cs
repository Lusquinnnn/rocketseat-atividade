using System.Globalization;

namespace Hello_world;

class Program
{
    static void algo()
    {
        DateTime datetime = DateTime.UtcNow;
        Console.WriteLine("Qual a data e o horário de hoje? Digite apenas com números!");
        
        datetime = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Formato completo: ");
        Console.WriteLine(datetime.ToString("F", new CultureInfo ("pt-Br")));
        Console.WriteLine("Apenas a data no formato normal: ");
        Console.WriteLine(datetime.ToString("d", new CultureInfo("pt-Br")));
        Console.WriteLine("Apenas a hora: ");
        Console.WriteLine(datetime.ToString("T", new CultureInfo("pt-Br")));
        Console.WriteLine("A data com o mes por extenso: ");
        Console.WriteLine(datetime.ToString("m", new CultureInfo("pt-Br")));

    }
}