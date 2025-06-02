using System.ComponentModel.Design;

namespace Hello_world;

class Program
{
    static void Main()
    {
        DateTime datetime = DateTime.UtcNow;
        Console.WriteLine("Qual a data e o horário de hoje? Digite apenas com números!");
        
        datetime = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Formato completo: ");
        Console.WriteLine(datetime.ToString("F"));
        Console.WriteLine("Apenas a data no formato normal: ");
        Console.WriteLine(datetime.ToString("d"));
        Console.WriteLine("Apenas a hora: ");
        Console.WriteLine(datetime.ToString("T"));
        Console.WriteLine("A data com o mes por extenso: ");
        Console.WriteLine(datetime.ToString("m"));

    }
}