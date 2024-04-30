using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente//extends
{   //         classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        private int rg;
        public ClienteFisico(): base()
        {            
        }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Rg: " + Rg);
        }

        public ClienteFisico(int codigo, string nome, string endereco, int rg) : base(codigo, nome, endereco)
        {
            Rg = rg;
        }
        public int Rg{
            get { return rg;}
            set { rg = value;}
        }
    }
}