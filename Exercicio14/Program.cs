namespace Exercicio14
{
    internal class Program
    {
        //14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            Console.WriteLine("Amostra de números"); 

            Console.Write("Escreva o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2 && num2 > num3 )
            {
                Console.WriteLine($" A sequencia correta é: { num1 } > { num2 } > { num3 }.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($" A sequencia correta é: {num2} > {num3} > {num1}.");

            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($" A sequencia correta é: {num3} > {num2} > {num1}.");

            }


            Console.ReadLine();

        }
    }
}
