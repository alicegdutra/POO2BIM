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

    public class Especie : Pagamento
    {
        public Especie(double valor) : base(valor) { }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento em espécie no valor de {Valor:C} processado.");
        }
    }

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
