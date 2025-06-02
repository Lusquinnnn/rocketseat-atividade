namespace Hello_world;

public class PlacaDoCarro
{
    static void Placa()
    {
        Console.WriteLine("Digite a placa do seu veiculo: ");
        string placa = Console.ReadLine();

        if (placa.Length == 7 && char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]) && char.IsDigit(placa[3]) && char.IsDigit(placa[4])
            && char.IsDigit(placa[5]) && char.IsDigit(placa[6]))
        {
            Console.WriteLine("VERDADEIRO - A placa é válida");
        }
        else
        {
            Console.WriteLine("FALSO - A placa é inválida");
        }
    }
}

