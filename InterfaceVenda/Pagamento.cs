using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InterfaceVendas
{
    public abstract class Pagamento
    {
        public double Valor { get; set; }

        protected Pagamento(double valor)
        {
            Valor = valor;
        }

        public abstract void ProcessarPagamento();
    }
}
