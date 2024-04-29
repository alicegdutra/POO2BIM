using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        protected string dataFabricacao;
        protected string dataValidade;
        protected int lote;

        public Perecivel() : base()
        {
            
        }

        public Perecivel(int codigo, string nome, double preco, string dataFabricacao, string dataValidade, int lote) : base(codigo, nome, preco) //BASE FAZ REFERENCIA A SUPERCLASSE, POR ISSO NAO COLCOA OS OUTROS PARAMETROS
        {
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
            Lote = lote; 
        }

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