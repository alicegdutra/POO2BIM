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

        public void ProcessarPagamento(Pagamento pagamento)
        {
            Pagamento = pagamento;
            pagamento.ProcessarPagamento();
        }

        public string Descrever()
        {
            string descricaoItens = "";
            foreach (var item in Itens)
            {
                descricaoItens += item.Descrever() + "\n";
            }
            return $"Código da Venda: {Codigo}, Itens:\n{descricaoItens}\nTotal: {CalcularTotal():C}";
        }
    }
}
