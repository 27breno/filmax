using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{
    public class Carro:Veiculo 
    {
    
        public string Placa { get; }

        public Carro(int id, string modelo, string cor, string placa)
             :base(id, modelo, cor, placa)
        {
           
            Placa = placa;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Modelo: {Modelo}, Cor: {Cor}, Placa: {Placa}";
        }
    }

}
