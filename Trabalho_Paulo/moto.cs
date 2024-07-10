using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{
    public class Moto:Veiculo
    {
        public Moto(int id, string tipo, string modelo, string cor) : base(id, tipo, modelo, cor)
        {
        }

       
        public override string ToString()
        {
            return $"ID: {Id}, Modelo: {Modelo}, Cor: {Cor}";
        }
    }

}
