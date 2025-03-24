namespace Exercicio16
{
    internal class Program
    {
        //16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {


            Console.WriteLine("Digite um número para descobrir se é par ou ímpar:  ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 != 0)
            {
                Console.WriteLine("O número é ímpar");
            }
            else 
            {
                Console.WriteLine("O número é par");
            }



            Console.ReadLine();
        }
    }
}
