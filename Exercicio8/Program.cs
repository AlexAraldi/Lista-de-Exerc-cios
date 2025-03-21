using System;

namespace Exercicio8
{
    internal class Program
    {


        //  8. Crie um programa para verificar se um número é primo.
        //  Receber o número digitado pelo usuário
        //  Percorrer todos os números de 2 até o número digitado menos 1
        //  Verificar se o número digitado é divisível por algum dos números percorridos
        //  Se o número não for divisível por nenhum dos números percorridos, então ele é primo


        static void Main(string[] args)
        {

            Console.WriteLine("<<<<<<<< Indetificador de Números Primos >>>>>>>>");

            Console.WriteLine("Digite o número para verificação:");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            bool ehPrimo = true;

            if (numeroDigitado <= 1)
            {
                ehPrimo = false;

            }

            else
            {
                for (int i = 2; i < numeroDigitado; i++)
                {

                    if (numeroDigitado % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }

                }

            }

            if (ehPrimo)
                Console.WriteLine("O número é primo !!!");
            else
                Console.WriteLine("O número não é primo!!!");

            Console.ReadLine();


        }
    }
}
