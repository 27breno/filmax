using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{

    public class Estacionamento
    {
        public int TotalVagas { get; }
        public List<Vaga> VagasDisponiveis { get; }
        public List<Vaga> VagasOcupadas { get; }
        public List<Vaga> HistoricoVagas { get; }

        private int proximoIdVeiculo;

        public Estacionamento(int totalVagas)
        {
            TotalVagas = totalVagas;

            VagasDisponiveis = new List<Vaga>();

            VagasOcupadas = new List<Vaga>();

            HistoricoVagas = new List<Vaga>();

            proximoIdVeiculo = 1;

            // Inicializa as vagas do estacionamento
            for (int i = 1; i <= totalVagas; i++)
            {
                string tipoVaga = i % 2 == 0 ? "Carro" : "Moto"; // Exemplo simples de alternância de tipo de vaga
                Vaga vaga = new Vaga(i, tipoVaga);
                VagasDisponiveis.Add(vaga);
            }
        }

        public void ListarVagas()
        {
            Console.WriteLine("\n--- Vagas Disponíveis ---");
            foreach (var vaga in VagasDisponiveis)
            {
                Console.WriteLine(vaga);
            }
            Console.WriteLine("--------------------------");

            Console.WriteLine("\n--- Vagas Ocupadas ---");
            foreach (var vaga in VagasOcupadas)
            {
                Console.WriteLine(vaga);
            }
            Console.WriteLine("--------------------------\n");
        }

        public void ReservarVaga(string tipoVeiculo)
        {
            Predicate<Vaga> match = v => v.TipoVaga.Equals(tipoVeiculo, StringComparison.OrdinalIgnoreCase);
            Vaga vaga = VagasDisponiveis.Find(match);

            if (vaga != null && !vaga.Ocupada)
            {
                Veiculo veiculo = new Veiculo(proximoIdVeiculo++, tipoVeiculo, "Indefinido", "Indefinida");
                vaga.EstacionarVeiculo(veiculo);
                VagasDisponiveis.Remove(vaga);
                VagasOcupadas.Add(vaga);
                Console.WriteLine($"Vaga para {tipoVeiculo} reservada com sucesso na vaga {vaga.Id}!");
            }
            else
            {
                Console.WriteLine($"Não há vagas disponíveis para {tipoVeiculo} ou já está ocupada.");
            }
        }

        public void MostrarHistoricoVagas()
        {
            Console.WriteLine("\n--- Histórico de Vagas Ocupadas ---");
            foreach (var vaga in HistoricoVagas)
            {
                Console.WriteLine(vaga);
            }
            Console.WriteLine("----------------------------------\n");
        }

        public void AdicionarVeiculo(string tipoVeiculo, string modelo, string cor)
        {
            Vaga vaga = VagasDisponiveis.Find(v => v.TipoVaga.Equals(tipoVeiculo, StringComparison.OrdinalIgnoreCase));

            if (vaga != null && !vaga.Ocupada)
            {
                Veiculo veiculo = new Veiculo(proximoIdVeiculo++, tipoVeiculo, modelo, cor);
                vaga.EstacionarVeiculo(veiculo);
                VagasDisponiveis.Remove(vaga);
                VagasOcupadas.Add(vaga);
                Console.WriteLine($"Veículo adicionado com sucesso na vaga {vaga.Id}!");
            }
            else
            {
                Console.WriteLine($"Não há vagas disponíveis para {tipoVeiculo} ou já está ocupada.");
            }
        }
    }
}
