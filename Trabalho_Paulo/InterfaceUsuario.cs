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
            this.estacionamento = estacionamento;
        }

        public void Iniciar()
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1. Listar Vagas Totais");
                Console.WriteLine("2. Reservar Vagas");
                Console.WriteLine("2. Adicionar veículo");
                Console.WriteLine("3. Mostrar istórico ");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        estacionamento.ExibirVagas();
                        break;

                    case "2":
                        estacionamento.ReservarVagas();
                        break;

                    case "3":
                      
                        estacionamento.AdicionarVeiculo();
                        break;


                    case "4":
                        estacionamento.Historico.MostrarHistorico();
                        break;

                    case "5":
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
