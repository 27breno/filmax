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

        private ImplementarDesconto desconto;

        public InterfaceUsuario()
        {
            this.estacionamento = new Estacionamento(10); 
            this.desconto = new ImplementarDesconto(4, "breno", 121322, 12134);
        }


        public void Iniciar()
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1. Listar Vagas Totais");
                Console.WriteLine("2. Aplicar desconto");
                Console.WriteLine("3. Reservar Vagas");
                Console.WriteLine("4. Adicionar veículo");
                Console.WriteLine("5. Mostrar Histórico ");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        estacionamento.ExibirVagas();
                        break;

                        case "2":
                        desconto.MiniMenu();
                        break;

                    case "3":
                        estacionamento.ReservarVagas();
                        break;

                    case "4":
                      
                        estacionamento.AdicionarVeiculo();
                        break;


                    case "5":
                        estacionamento.Historico.MostrarHistorico();
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
