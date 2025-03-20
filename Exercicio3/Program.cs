namespace Exercicio3
{
    internal class Program
    {

        // 3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.O
        // programa deve solicitar ao usuário:
        //   ● A quilometragem inicial do veículo no início da viagem.
        //   ● A quilometragem final ao término da viagem.
        //   ● A quantidade de combustível consumida durante a viagem(em litros).
        static void Main(string[] args)
        {
            
            Console.Write("Digite o valor do Km Inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do Km Final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do Consumo: ");
            double consumoCombustivel = Convert.ToDouble(Console.ReadLine());


            double distanciaPercorrida = kmFinal - kmInicial;
            double consumoKm = distanciaPercorrida / consumoCombustivel;

            Console.WriteLine($"O consumo de combustível por km foi de : {consumoKm} km/Ltr.");


            Console.ReadLine();    
        }
    }
}
