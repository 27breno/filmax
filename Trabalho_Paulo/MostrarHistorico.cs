using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{

    public class HistoricoVagas
    {
        private List<Vaga> vagasHistorico;

        public HistoricoVagas()
        {
            vagasHistorico = new List<Vaga>();
        }

        public void AdicionarVagaHistorico(Vaga vaga)
        {
            vagasHistorico.Add(vaga);
        }

        public void MostrarHistorico()
        {
            Console.WriteLine("\n--- Histórico de Vagas Ocupadas ---");
            foreach (var vaga in vagasHistorico)
            {
                Console.WriteLine(vaga);
            }
            Console.WriteLine("VEÍCULO - MODELO - COR - HORÁRIO DE ENTRADA - HORÁRIO DE SAÍDA ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CARRO - FIAT UNO - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CARRO - FIAT UNO - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("MOTO - YAMAHA YZF R-3 - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CARRO - FIAT UNO - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("MOTO - BMW S 1000 RR - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("MOTO - HONDA SHADOW 750 - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("MOTO- HARLEY DAVDSON Sportster 883 - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CARRO - FIAT UNO - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("MOTO - KAWASAKI VOYAGER - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CARRO - FIAT UNO - VERMELHO- ENTRADA 07:00 - SAÍDA 09:30 ");
            Console.WriteLine("----------------------------------\n");

        }
    }
}
