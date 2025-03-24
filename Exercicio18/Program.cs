namespace Exercicio18
{
    internal class Program
    {
        //18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        static void Main(string[] args)
        {

            int contador = 101;

            while (contador < 200 && contador > 100)
            {

                if (contador % 2 != 0)
                    Console.WriteLine($"{contador}");

            }

            Console.ReadLine();

        }

    }
}
