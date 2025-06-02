namespace Hello_world;

 class ContadorCaracteres
{

        static void Contador()
        {
            Console.WriteLine("Digite o texto: ");
            string texto = Console.ReadLine();
            char[] delimitadores = new char[] { ',', '.', '?', ' ', '!' };

            string[] palavras = texto.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries);

            int totalCaracteres = 0;

            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);
                int numeroDeCaracteres = palavra.Length;
                Console.WriteLine($"A palavra '{palavra}' tem {numeroDeCaracteres} caracteres");
                totalCaracteres += numeroDeCaracteres;
            }
            Console.WriteLine("O número total de caracteres é: " + totalCaracteres);
        }
    }

