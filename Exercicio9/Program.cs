namespace Exercicio9
{
    internal class Program
    {
        //        A imobiliária Imóbilis vende apenas terrenos retangulares.Faça um algoritmo para ler as dimensões de um
        //        terreno e depois exibir a área do terreno.
        static void Main(string[] args)
        {




            
            Console.WriteLine(">>>>> Dimensionamento de Terrenos <<<<<<\n");

            Console.Write("- Informe o comprimento em metros do terreno:  ");
            double comprimento = ( Convert.ToDouble(Console.ReadLine()));

            Console.Write("- Informe o valor da frente em metros do terreno: ");
            double largura = (Convert.ToDouble(Console.ReadLine()));

            double areaTotal = comprimento * largura;

            Console.WriteLine($"- Área total do terreno é: ({areaTotal} m²).");
            Console.ReadLine();
            
        }
    }
}
