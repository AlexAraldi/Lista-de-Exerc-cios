namespace Exercicio13
{
    internal class Program
    {
        // 13 - Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            Console.WriteLine("Escreva o número A: ");
            int nunA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o número B: ");
            int nunB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o numero C: ");
            int nunC = Convert.ToInt32(Console.ReadLine());

            if (nunA + nunB < nunC) 
            {
                Console.WriteLine(" Sim, a soma de A + B é menor que C.");
            }
            else Console.WriteLine("Não, a soma A + B é maior que C");

                Console.ReadLine();
        }
    }
}
