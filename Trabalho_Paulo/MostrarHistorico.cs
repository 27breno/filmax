using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{

    public class HistoricoVagas
    {
       public int HistoricoId { get; set; }
        public DateTime DataHistorico { get; set; }

        public string Mensagem { get; set; }    
        public HistoricoVagas(string contexto, string De, string Para, string alteracao)
        {
            DataHistorico= DateTime.Now;
            Mensagem = $"{contexto} {alteracao} De {De} Para {Para} no dia {DataHistorico} ";
        }

        public void MostrarHistorico()
        {
            Console.WriteLine($"Historico ID {HistoricoId}");
            Console.WriteLine(Mensagem);
           
        }

    }
}
