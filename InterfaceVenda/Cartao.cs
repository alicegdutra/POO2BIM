using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InterfaceVendas
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; set; }
        public int ResultadoTransacao { get; set; }

        public Cartao(double valor, string dadosTransacao, int resultadoTransacao) : base(valor)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento em cartão no valor de {Valor:C} processado com resultado {ResultadoTransacao}.");
        }
    }
}
