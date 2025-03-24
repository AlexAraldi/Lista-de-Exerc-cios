using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio18
{
    internal class Program
    {
        //18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um ENTER para começar: ");
            Console.ReadLine();
                       
            for (int i = 100; i < 200; i++) 
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
           
            Console.ReadLine();

        }

    }
}
