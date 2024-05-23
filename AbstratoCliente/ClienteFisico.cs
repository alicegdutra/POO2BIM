using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente//extends
{   //         classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        private int rg;
        public ClienteFisico(): base()
        {            
        }
        public override void Mostrar()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tEndereço: "+ endereco + "\tRG: " + Rg);

        }

        public ClienteFisico(int codigo, string nome, string endereco, int idade, int rg) : base(codigo, nome, endereco, idade)
        {
            Rg = rg;
        }
        public int Rg{
            get { return rg;}
            set { rg = value;}
        }

        public override void AvaliaIdade()
        {
            if (Idade > 18 && Idade < 40)
                System.Console.WriteLine("Cliente Físico!");
            
        }
    }
}