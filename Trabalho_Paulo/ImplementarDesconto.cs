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

        public ImplementarDesconto(long id, string name, int cpf, int cep)
        {
            Id = id;
            Name = name;
            CPF = cpf;
            CEP = cep;
        }

        public void MiniMenu()
        {
            bool sair = false;



            Console.WriteLine(" Primeiro voce terá que cadastrar em nosso sistema, para assim soltarmos o seu desconto ");

            Console.WriteLine("voce deseja se cadastrar? sim / não ");
            string opcao = Console.ReadLine();


            switch (opcao)

            {
                case "sim":

                    cadastrar();

                    Console.WriteLine("seu cadastro foi um sucesso !!! siga em frente para que libere o desconto ");

                    Desconto();
                    break;

                case "não":

                    sair = true;

                    break;

            }

        }

        public void cadastrar()
        {
            Console.WriteLine("digite seu nome ");
            Name = Console.ReadLine();

            Console.WriteLine("digite seu CPF ");
            CPF = int.Parse(Console.ReadLine());

            Console.WriteLine("digite seu CEP");
            CEP = int.Parse(Console.ReadLine());

        }
        public void Desconto()
        {
            Console.WriteLine("Escolha ums das duas opções e veja o cupon que será disponibilizado");



            double valormoto = 140.00;

            double valorcarro = 200.00;

            Console.WriteLine("1. Para a moto ");

            Console.WriteLine("2. Para o carro ");

            int acao = int.Parse(Console.ReadLine());



            switch (acao)

            {
                case 1:

                    valormoto = (valormoto - 0.5);

                    Console.WriteLine($"Valor total $140.00, Cupon de 5% adicionado ${valormoto}");

                    break;

                case 2:

                    valorcarro = (valorcarro - 0.10);
                    Console.WriteLine($"Valor total $200.00, Cupon de 10% adicionado {valorcarro}");

                    break;

            }


        }
    }
}

