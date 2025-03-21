using System;

namespace Exercicio6
{
    internal class Program
    {
        //6. Crie um programa para calcular a média harmônica das notas de um Aluno
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<< Calculadora Harmônica >>>>>>>>>>");


            Console.WriteLine("informe o valor da nota de MATEMÁTICA: ");
            int notaMat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor da nota de BIOLOGIA: ");
            int notaBio = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("informe o valor da nota de PORTUGUÊS: ");
            int notaPort = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("informe o valor da nota de FÍSICA: ");
            int notaFis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor da nota de Geografia: ");
            int notaGeo = Convert.ToInt32(Console.ReadLine());

            double notaHarm = 5.0 / ((1.0/notaMat) + (1.0 / notaBio) + (1.0 / notaPort) + (1.0/ notaFis) + (1.0/ notaGeo));

            Console.WriteLine($"A nota Harmônica do Aluno é: {notaHarm}.");

            Console.ReadLine();
        }
    }
}
