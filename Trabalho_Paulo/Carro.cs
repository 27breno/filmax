using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{
    public class Carro
    {
        public int QuantidadePortas { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }


    public void ExibirDetalhesCarro()
    {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Ano:{Ano}");
            Console.WriteLine($"Marca:{Marca}");
            Console.WriteLine($"Quantidade de Portas:{QuantidadePortas}");
            Console.WriteLine($"Cor:{Cor}");
            Console.WriteLine($"Placa:{Placa}");
    }

    }
}
