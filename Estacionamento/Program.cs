// Program.cs
using Estacionamento.Models;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();

            while (true)
            {
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Remover Veículo");
                Console.WriteLine("3. Listar Veículos");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite a placa do veículo: ");
                        string placaAdicionar = Console.ReadLine();
                        estacionamento.AdicionarVeiculo(placaAdicionar);
                        break;
                    case "2":
                        Console.Write("Digite a placa do veículo: ");
                        string placaRemover = Console.ReadLine();
                        estacionamento.RemoverVeiculo(placaRemover);
                        break;
                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
