namespace Exercicio14
{
    internal class Program
    {
        //14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

        static void Main(string[] args)
        {
            Console.WriteLine("Amostra de números\n"); 

            Console.Write("Escreva o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] numeros = [num1, num2, num3];

            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.Write($"A sequência decrescente é: ");

            for (int i  = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " " );
            }

            
           

            Console.ReadLine();

            

        }
    }
}
