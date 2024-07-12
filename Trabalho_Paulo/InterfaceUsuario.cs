using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{

    public class InterfaceUsuario
    {
        private Estacionamento estacionamento;

        public InterfaceUsuario(Estacionamento estacionamento)
        {
            this.estacionamento = new Estacionamento(10); 
            this.desconto = new ImplementarDesconto(4, "bre", 123456789, 12134);
        }

        public void Iniciar()
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1. Listar vagas disponíveis e ocupadas");
                Console.WriteLine("2. Reservar vaga para carro");
                Console.WriteLine("3. Reservar vaga para moto");
                Console.WriteLine("4. Adicionar veículo");
                Console.WriteLine("5. Mostrar histórico de vagas ocupadas");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        estacionamento.ListarVagas();
                        break;

                    case "2":
                        estacionamento.ReservarVaga("Carro");
                        break;

                    case "3":
                        estacionamento.ReservarVaga("Moto");
                        break;

                    case "4":
                        Console.Write("Digite o tipo de veículo (Carro ou Moto): ");
                        string tipo = Console.ReadLine();
                        Console.Write("Digite o modelo do veículo: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Digite a cor do veículo: ");
                        string cor = Console.ReadLine();

                        estacionamento.AdicionarVeiculo(tipo, modelo, cor);
                        break;

                    case "5":
                        estacionamento.MostrarHistoricoVagas();
                        break;

                    case "6":
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
