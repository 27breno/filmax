using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Paulo
{
    public class ImplementarDesconto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int CPF { get; set; }
        public int CEP { get; set; }

        public ImplementarDesconto(long id, string name, int cpf, int cep )
        {
            Id = id;
            Name = name;
            CPF = cpf;
            CEP = cep;
        }
        public void cadastrar()
        {
            Console.WriteLine("digite seu nome ");
            Name = Console.ReadLine();

            Console.WriteLine("digite seu CPF ");
            CPF = int.Parse (Console.ReadLine());

            Console.WriteLine("digite seu CEP");
            CEP = int.Parse (Console.ReadLine());

        }
        public void Desconto()
        {
            Console.WriteLine("Escolha ums das duas opções e veja o cupon que será disponibilizado");

            int opcao= 0;

            double valormoto = 140.90;

            double valorcarro = 200.00;

            Console.WriteLine("1. Para a moto ");
            Console.WriteLine("2. Para o carro ");

            if (opcao==1)
            {
                valormoto = (valormoto - 0.5);
            }
            else if (opcao==1)
            {
                valorcarro= (valorcarro - 0.10);
            }


        }

        public void MiniMenu()
        {

            Console.WriteLine(" Primeiro voce terá que cadastrar em nosso sistema, para que assim soltaremos o seu desconto ");

            Console.WriteLine("voce deseja se cadastrar? s/n ");

            char opcao = 's';

            char opcao2 = 'n';
            

            if (opcao  == 's')
            {

                cadastrar();

                Console.WriteLine("seu cadastro foi um sucesso !!! siga em frente para que libere o ");

               
            }
            else if (opcao2 == 'n')
            {

            }

        }

         
}
}
