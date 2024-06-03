using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceVendas
{
    public class Venda
    {
        public int Codigo { get; set; }
        public List<ItemVenda> Itens { get; set; }
        public Pagamento Pagamento { get; set; }

        public Venda(int codigo)
        {
            Codigo = codigo;
            Itens = new List<ItemVenda>();
        }

        public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var item in Itens)
            {
                total += item.Preco;
            }
            return total;
        }

        public void ProcessarPagamento(int opcaoPagamento)
        {
            Pagamento = CriarPagamento(opcaoPagamento, CalcularTotal());
            Pagamento.ProcessarPagamento();
        }

        private Pagamento CriarPagamento(int opcaoPagamento, double valor)
        {
            switch (opcaoPagamento)
            {
                case 1:
                    return new Especie(valor);
                case 2:
                    return CriarCheque(valor);
                case 3:
                    return CriarCartao(valor);
                default:
                    return null;
            }
        }

        private Pagamento CriarCheque(double valor)
        {
            Console.Write("Número do Cheque: ");
            if (!long.TryParse(Console.ReadLine(), out long numeroCheque)) return null;
            Console.Write("Data de Depósito (dd/MM/yyyy): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataDeposito)) return null;
            return new Cheque(valor, numeroCheque, dataDeposito);
        }

        private Pagamento CriarCartao(double valor)
        {
            Console.Write("Dados da Transação: ");
            string dadosTransacao = Console.ReadLine();
            Console.Write("Resultado da Transação: ");
            if (!int.TryParse(Console.ReadLine(), out int resultadoTransacao)) return null;
            return new Cartao(valor, dadosTransacao, resultadoTransacao);
        }

        public string Mostrar()
        {
            string descricaoItens = "";
            foreach (var item in Itens)
            {
                descricaoItens += item.Mostrar() + "\n";
            }
            return $"Código da Venda: {Codigo}, Itens:\n{descricaoItens}\nTotal: {CalcularTotal():C}";
        }
    }
}
