using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{
    public class Moto : Veiculo
    {


        public int Id { get; }
        public string Tipo { get; }
        public string Modelo { get; }
        public string Cor { get; }

        public Moto(int id, string tipo, string modelo, string cor) 
          : base(id, tipo, modelo, cor)
        {
            Cor = cor;
        }
        
        
        public override string ToString()
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


