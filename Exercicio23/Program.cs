namespace Exercicio23
{
    internal class Program
    {
        //23. Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
        //    múltiplos de 3 pela palavra &quot;Fizz&quot; e os múltiplos de 5 pela palavra &quot;Buzz&quot;. Para números que são múltiplos de
        //    ambos, use &quot;FizzBuzz&quot;.
        static void Main(string[] args)
        {
            string numeros = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    numeros = "FizzBuzz";
                    Console.WriteLine(numeros);
                }
                else if (i % 3 == 0)
                {
                    numeros = "Fizz";
                    Console.WriteLine(numeros);
                }
                else if (i % 5 == 0)
                {
                    numeros = "Buzz";
                    Console.WriteLine(numeros);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

        }
    }
}
