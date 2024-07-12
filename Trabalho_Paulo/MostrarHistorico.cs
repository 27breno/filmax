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
            Console.WriteLine("----------------------------------\n");

        }
    }
}
