using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do vendedor: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe o nível do vendedor (I, II ou III): ");
        string nivel = Console.ReadLine().ToUpper();

        Console.WriteLine("Informe o valor total das vendas do vendedor: R$ ");
        double vendas = double.Parse(Console.ReadLine());

        switch (nivel)
        {
            case "I":
                if (vendas > 80000)
                {
                    Console.WriteLine($"O vendedor {nome}, nível I foi promovido ao nível II.");
                }
                else if (vendas > 50000)
                {
                    double bonificacao = vendas * 0.35;
                    Console.WriteLine($"O vendedor {nome}, nível I, deverá receber uma bonificação de R$ {bonificacao:F2}.");
                }
                else if (vendas > 20000)
                {
                    double bonificacao = vendas * 0.20;
                    Console.WriteLine($"O vendedor {nome}, nível I, deverá receber uma bonificação de R$ {bonificacao:F2}.");
                }
                else if (vendas < 5000)
                {
                    Console.WriteLine($"O vendedor {nome}, nível I, está em risco de demissão.");
                }
                break;

            case "II":
                if (vendas > 200000)
                {
                    Console.WriteLine($"O vendedor {nome}, nível II, foi promovido ao nível III.");
                }
                else if (vendas > 120000)
                {
                    double bonificacao = vendas * 0.40;
                    Console.WriteLine($"O vendedor {nome}, nível II, deverá receber uma bonificação de R$ {bonificacao:F2}.");
                }
                else if (vendas > 90000)
                {
                    double bonificacao = vendas * 0.25;
                    Console.WriteLine($"O vendedor {nome}, nível II, deverá receber uma bonificação de R$ {bonificacao:F2}.");
                }
                else if (vendas < 50000)
                {
                    Console.WriteLine($"O vendedor {nome}, nível II, está em risco de virar nível I.");
                }
                break;

            case "III":
                if (vendas > 500000)
                {
                    Console.WriteLine($"O vendedor {nome}, nível III, virou o dono da firma!");
                }
                else if (vendas > 250000)
                {
                    double bonificacao = vendas * 0.45;
                    Console.WriteLine($"O vendedor {nome}, nível III, deverá receber uma bonificação de R$ {bonificacao:F2}.");
                }
                else if (vendas > 210000)
                {
                    double bonificacao = vendas * 0.30;
                    Console.WriteLine($"O vendedor {nome}, nível III, deverá receber uma bonificação de R$ {bonificacao:F2}.");
                }
                else if (vendas < 100000)
                {
                    Console.WriteLine($"O vendedor {nome}, nível III, está em risco de virar nível II.");
                }
                break;

            default:
                Console.WriteLine("Nível inválido. Por favor, tente novamente.");
                break;
        }
    }
}
