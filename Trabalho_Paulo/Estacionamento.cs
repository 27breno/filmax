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
        public HistoricoVagas Historico { get; }

        private int proximoIdVeiculo;

        public Estacionamento(int totalVagas)
        {
            TotalVagas = totalVagas;

            VagasDisponiveis = new List<Vaga>();

            VagasOcupadas = new List<Vaga>();

            Historico = new HistoricoVagas();

            proximoIdVeiculo = 1;

           

            // Inicializa as vagas do estacionamento
            for (int i = 1; i <= totalVagas; i++)
            {
                string tipoVaga = i % 2 == 0 ? "Carro" : "Moto"; // Exemplo simples de alternância de tipo de vaga
                Vaga vaga = new Vaga(i, tipoVaga);
                VagasDisponiveis.Add(vaga);
            }
        }

        public void ExibirVagas()
        {
            // Exemplo: Matriz 5x5 de vagas
            bool[,] vagas = new bool[5, 5]; // Matriz 5x5 de booleanos inicializada como falsa (vaga livre)
            int numeroColunas = 5; // Número de colunas (no exemplo, são 5 colunas A, B, C, D, E)
            int numvagas = 5; // Número de vagas (no exemplo, são 5 vagas numeradas de 1 a 5)

            Console.WriteLine("\n   Vagas");
            Console.Write("  ");
            for (int i = 1; i <= numvagas; i++)
            {
                Console.Write($" {i.ToString().PadLeft(2)}");
            }
            Console.WriteLine();

            for (int i = 0; i < numeroColunas; i++)
            {
                Console.Write($"{(char)('A' + i)} ");
                for (int j = 0; j < numvagas; j++)
                {
                    if (vagas[i, j])
                    {
                        Console.Write(" X"); // Assento ocupado
                    }
                    else
                    {
                        Console.Write(" -"); // Assento livre
                    }
                }
                Console.WriteLine();
            }
        }


        public void ReservarVagas()
        {
            int numeroColunas = 10;
            int numvagas = 20;
            bool[,] vagas = new bool[numeroColunas, numvagas];


          
            Console.WriteLine("\n    Assentos");
            Console.Write("  ");
            for (int i = 1; i <= numvagas; i++)
            {
                Console.Write($" {i.ToString().PadLeft(2)}");
            }
            Console.WriteLine();

            for (int i = 0; i < numeroColunas; i++)
            {
                Console.Write($"{(char)('A' + i)} ");
                for (int j = 0; j < numvagas; j++)
                {
                    if (vagas[i, j])
                    {
                        Console.Write(" X");
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                }
                Console.WriteLine();
            }

            // Escolha do assento
            Console.Write("\nEscolha o assento desejado (digite a letra da coluna seguida do número da cadeira, ex: A1): ");
            string escolhaVagas = Console.ReadLine().ToUpper();

            int colunaEscolhida = escolhaVagas[0] - 'A'; // Convertendo a letra da coluna para um número correspondente ao índice
            int vagasEscolhida = int.Parse(escolhaVagas.Substring(1)); // Pegando o número da cadeira

            if (colunaEscolhida >= 0 && colunaEscolhida < numeroColunas && vagasEscolhida >= 0 && vagasEscolhida < numvagas)
            {
                if (!vagas[colunaEscolhida, vagasEscolhida])
                {
                    vagas[colunaEscolhida, vagasEscolhida] = true;
                    Console.WriteLine($"Vagas {escolhaVagas} reservada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Esta vaga já está reservado. Por favor, escolha outra vaga.");
                }
            }
            else
            {
                Console.WriteLine("Vaga inválido. Por favor, escolha um vaga válido.");
            }
            // Perguntando se deseja reservar mais assentos
            Console.Write("Deseja reservar mais algum assento? (s/n): ");
            char maisAssentos = char.ToLower(Console.ReadKey().KeyChar);

            while (maisAssentos == 's') ;




        }

        


        public void AdicionarVeiculo()
        {
            Console.WriteLine("=== Adicionar Veículo ===");
            Console.WriteLine("1. Adicionar Carro");
            Console.WriteLine("2. Adicionar Moto");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    AdicionarCarro();
                    break;

                case "2":
                    AdicionarMoto();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }


        private void AdicionarCarro()

        {
            string tipoVeiculo = "Carro";

            Vaga vaga = VagasDisponiveis.Find(v => v.TipoVaga.Equals(tipoVeiculo, StringComparison.OrdinalIgnoreCase));

            if (vaga != null && !vaga.Ocupada)
            {
                Console.Write("Digite o modelo do carro: ");
                string modelo = Console.ReadLine();
                Console.Write("Digite a cor do carro: ");
                string cor = Console.ReadLine();
                Console.Write("Digite a placa do carro: ");
                string placa = Console.ReadLine();

                Carro carro = new Carro(proximoIdVeiculo++, modelo, cor, placa);
                vaga.EstacionarVeiculo(carro);
                VagasDisponiveis.Remove(vaga);
                VagasOcupadas.Add(vaga);
                Console.WriteLine($"selecione a vaga {ExibirVagas}!");
            }
            else
            {
                Console.WriteLine($"Não há vagas disponíveis para carros ou já está ocupada.");
            }
        }
        private void AdicionarMoto()
        {
            string tipoVeiculo = "moto";

            Vaga vaga = VagasDisponiveis.Find(v => v.TipoVaga.Equals(tipoVeiculo, StringComparison.OrdinalIgnoreCase));

            if (vaga != null && !vaga.Ocupada)
            {
                Console.Write("Digite o modelo do moto: ");
                string modelo = Console.ReadLine();
                Console.Write("Digite a cor do moto: ");
                string cor = Console.ReadLine();
                Console.Write("Digite a placa do moto: ");
                string placa = Console.ReadLine();

                Moto moto = new Moto(proximoIdVeiculo++, modelo, cor, placa);
                vaga.EstacionarVeiculo(moto);
                VagasDisponiveis.Remove(vaga);
                VagasOcupadas.Add(vaga);
                Console.WriteLine($"Carro adicionado com sucesso na vaga {vaga.Id}!");
            }
            else
            {
                Console.WriteLine($"Não há vagas disponíveis para carros ou já está ocupada.");
            }

        }
    }
}

