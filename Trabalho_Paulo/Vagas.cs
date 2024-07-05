using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{

    public class Vaga
    {
        public int Id { get; }
        public bool Ocupada { get; private set; }
        public string TipoVaga { get; }

        public Veiculo VeiculoEstacionado { get; private set; }

        public Vaga(int id, string tipoVaga)
        {
            Id = id;
            TipoVaga = tipoVaga;
            Ocupada = false;
            VeiculoEstacionado = null;
        }

        public void EstacionarVeiculo(Veiculo veiculo)
        {
            Ocupada = true;
            VeiculoEstacionado = veiculo;
        }

        public void LiberarVaga()
        {
            Ocupada = false;
            VeiculoEstacionado = null;
        }

        public override string ToString()
        {
            if (Ocupada)
            {
                return $"ID: {Id}, Ocupada: Sim, Tipo de Vaga: {TipoVaga}, Veículo: {VeiculoEstacionado}";
            }
            else
            {
                return $"ID: {Id}, Ocupada: Não, Tipo de Vaga: {TipoVaga}";
            }
        }
    }


}
