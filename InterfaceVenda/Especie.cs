using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InterfaceVendas
{
    public class Especie : Pagamento
    {
        public Especie(double valor) : base(valor) { }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento em espécie no valor de {Valor:C} processado.");
        }
    }
}
