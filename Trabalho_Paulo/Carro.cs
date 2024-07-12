using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{

    public class Carro : Veiculo
    {


        public int Id { get; }
        public string Tipo { get; }
        public string Modelo { get; }
        public string Cor { get; }

        public Carro(int id, string tipo, string modelo, string cor)
          : base(id, tipo, modelo, cor)
        {
            Cor = cor;
        }


        public override string ToString()
        {
            return $"ID: {Id}, Modelo: {Modelo}, Cor: {Cor}";
        }
    }
}
