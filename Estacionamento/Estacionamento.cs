// Estacionamento.cs
namespace Estacionamento
{
    public class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private const decimal precoPorHora = 5.00m;

        public void AdicionarVeiculo(string placa)
        {
            Veiculo veiculo = new Veiculo(placa);
            veiculos.Add(veiculo);
            Console.WriteLine($"Veículo {placa} adicionado com sucesso.");
        }

        public void RemoverVeiculo(string placa)
        {
            Veiculo veiculo = veiculos.FirstOrDefault(v => v.Placa == placa);

            if (veiculo != null)
            {
                DateTime horaSaida = DateTime.Now;
                TimeSpan tempoPermanencia = horaSaida - veiculo.HoraEntrada;
                decimal valorCobrado = (decimal)tempoPermanencia.TotalHours * precoPorHora;

                veiculos.Remove(veiculo);
                Console.WriteLine($"Veículo {placa} removido. Valor cobrado: {valorCobrado:C}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo.Placa} (Entrada: {veiculo.HoraEntrada})");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo estacionado.");
            }
        }
    }
}
