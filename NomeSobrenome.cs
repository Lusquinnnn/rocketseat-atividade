using System.Text;

namespace Hello_world;

public class NomeSobrenome
{
        static void ListaNomeSobrenome()
        {
            Console.WriteLine("Digite o primeiro nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append(nome + " ");
            sb.Append(sobrenome);

            string resultado = sb.ToString();

            Console.WriteLine(resultado);

        }
    
}
