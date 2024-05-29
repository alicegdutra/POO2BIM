using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceVendas
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }

        public Cheque(double valor, long numero, DateTime dataDeposito) : base(valor)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento em cheque no valor de {Valor:C}, número {Numero}, data de depósito {DataDeposito:dd/MM/yyyy} processado.");
        }
    }
}
