using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{

    public class Veiculo
    {
        public int Id { get; }
        public string Tipo { get; }
        public string Modelo { get; }
        public string Cor { get; }

        public Veiculo(int id, string tipo, string modelo, string cor)
        {
            Id = id;
            Tipo = tipo;
            Modelo = modelo;
            Cor = cor;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Tipo: {Tipo}, Modelo: {Modelo}, Cor: {Cor}";
        }
    }
}

