using System;
using System.Runtime.InteropServices;

namespace Exercicio4
{
    internal class Program
    {

        //4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        // °F = °C × 1,8 + 32
        static void Main(string[] args)
        {


            Console.WriteLine(" >>>>> Conversor de Escalas T° <<<<< ");
            Console.WriteLine("Digite 1 para graus Celsius ");
            Console.WriteLine("Digite 2 para graus Fahrenheit ");

            int valorMenu = Convert.ToInt32(Console.ReadLine());

            if (valorMenu == 1)
            {
                Console.Write("Escreva o valor de graus Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                double resultado = (celsius * 1.2) + 32;

                Console.Write($"O valor em °F é: {resultado} F°.");
            }
            else 
            {

                Console.Write("Escreva o valor de Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                double resulto2 = (5/9) * (fahrenheit - 32);

                Console.WriteLine($"O valor da T° em Celsius é: {resulto2} C°");

            }
            Console.ReadLine(); 
        }
    }
}
