namespace Exercicio19
{
    internal class Program
    {
        //19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
        //encontram no conjunto dos números de 1 até 500.
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora somática de números impares multiplos de 3 de 1 até 500. ");

            int operacao = 0;

            for (int i = 1; i < 500; i++)
            {

                if (i % 2 != 0 && i % 3 == 0)
                {

                    operacao += i;
                }

            }
            Console.WriteLine($"Resultado da soma dos números ímpares e multiplos de três de 0 à 500: [ {operacao} ]");
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
