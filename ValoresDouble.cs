namespace Hello_world;

public class ValoresDouble
{
        static void Valores()
        {
            Console.WriteLine("Declare o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());



            var soma = num1 + num2;
            Console.WriteLine("O resultado da soma é: " + soma);

            var subtracao = num1 - num2;
            Console.WriteLine("O resultado da subtracao é: " + subtracao);

            var multiplicacao = num1 * num2;
            Console.WriteLine("O resultado da multiplicacao é " + multiplicacao);

            if (num2 == 0)
            {
                Console.WriteLine("Divisao por zero nao e permitida!");
            }
            else
            {
                var divisao = num1 / num2;
                Console.WriteLine("O resultado da divisao é: " + divisao);
            }

            var media = (num1 + num2 / 2);
            Console.WriteLine("A média dos números é: " + media);
        }
}
