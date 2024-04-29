using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        // Campos adicionais específicos para produtos perecíveis
        protected string dataFabricacao;
        protected string dataValidade;
        protected int lote;

        // Construtor padrão
        public Perecivel()
        {}

        // Construtor com parâmetros
        public Perecivel(int codigo, string nome, double preco, string dataFabricacao, string dataValidade, int lote) : base(codigo, nome, preco) // Chama o construtor da classe base Produto com os parâmetros correspondentes
        {
            // Inicializa os campos específicos da classe Perecivel
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
            Lote = lote;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Data de Fabricação: " + DataFabricacao + "\tData de Validade: " + DataValidade + "\tLote: " + Lote);
        }

        // Propriedades para os campos específicos
        public string DataFabricacao
        {
            get { return dataFabricacao; }
            set { dataFabricacao = value; }
        }

        public string DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }

        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }
    }
}