using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InterfaceVendas
{
    public class ItemVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco
        {
            get { return Produto.Preco * Quantidade; }
        }

        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public string Mostrar()
        {
            return $"Produto: {Produto.Nome}, Quantidade: {Quantidade}, Preço: {Preco:C}";
        }
    }
}