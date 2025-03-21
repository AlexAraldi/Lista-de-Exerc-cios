namespace Exercicio5
{
    internal class Program
    {
        // 5.Crie um programa para calcular o salário total de um vendedor.Deverá ser informado o salário base e o total de
        // vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.

        static void Main(string[] args)

        {

            Console.WriteLine("<<<<<<<<< Calculadora Salárial >>>>>>>>>");

            Console.WriteLine("Informe o salario base: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe o percentual: ");
            double percentual = (Convert.ToDouble(Console.ReadLine()))/100;

            double salarioTotal = salario + (totalVendas * percentual);

            Console.WriteLine($"O Salário total do vendedor é:{salarioTotal}");

            Console.ReadLine();

        }
    }
}
