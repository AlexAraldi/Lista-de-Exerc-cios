namespace Exercicio20
{
    internal class Program
    {
        //20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
        // tabuada na forma:
        // ● 0 x N = 0,
        // ● 1 x N = 1N,
        // ● 2 x N = 2N,
        // .
        // .
        // .
        // ● 10 x N = 10N.

        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Tabuada");
            Console.WriteLine("--------------------------------");

            Console.Write("Digite um número: ");

            int numeroN = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroN * contador;
                Console.WriteLine($"{numeroN} x {contador} N = {resultadoTabuada} N");
            }
            Console.ReadLine();
        }
    }
}
