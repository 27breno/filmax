using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{
    public class Moto
    {
        public int Cilindrada { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }

        public void ExibirDetalhesMoto()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Cilindrada:{Cilindrada}");
            Console.WriteLine($"Ano:{Ano}");
            Console.WriteLine($"Marca:{Marca}");
            Console.WriteLine($"Cor:{Cor}");
            Console.WriteLine($"Placa:{Placa}");
        }
    }
    
}
