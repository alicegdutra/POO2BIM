using InterfaceVendas

public class ControladorVendas
{
        private List<Produto> produtos = new List<Produto>();
        private List<Venda> vendas = new List<Venda>();
        private int codigoVenda = 1;

        public void Executar()
        {
            int opcao;

            do
            {
                MostrarMenu();
                opcao = LerOpcao();

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        RegistrarVenda();
                        break;
                    case 3:
                        ListarVendas();
                        break;
                }
            } while (opcao != 4);
        }

        private void MostrarMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Registrar Venda");
            Console.WriteLine("3. Listar Vendas");
            Console.WriteLine("4. Sair");
        }

        private int LerOpcao()
        {
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine());
        }

        private void CadastrarProduto()
        {
            Console.Write("Código do Produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            double preco = double.Parse(Console.ReadLine());

            produtos.Add(new Produto(codigo, nome, preco));
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        private void RegistrarVenda()
        {
            Venda venda = new Venda(codigoVenda++);
            int codigoProduto;

            do
            {
                Console.Write("Código do Produto (0 para finalizar): ");
                codigoProduto = int.Parse(Console.ReadLine());
                if (codigoProduto == 0) break;

                Produto produto = produtos.Find(p => p.Codigo == codigoProduto);
                if (produto != null)
                {
                    Console.Write("Quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    venda.AdicionarItem(new ItemVenda(produto, quantidade));
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            } while (codigoProduto != 0);

            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1. Espécie");
            Console.WriteLine("2. Cheque");
            Console.WriteLine("3. Cartão");
            int opcaoPagamento = int.Parse(Console.ReadLine());

            Pagamento pagamento = CriarPagamento(opcaoPagamento, venda.CalcularTotal());
            venda.ProcessarPagamento(pagamento);
            vendas.Add(venda);

            Console.WriteLine("Venda registrada com sucesso!");
        }

        private Pagamento CriarPagamento(int opcaoPagamento, double total)
        {
            if (opcaoPagamento == 1)
            {
                return new Especie(total);
            }
            if (opcaoPagamento == 2)
            {
                Console.Write("Número do Cheque: ");
                long numeroCheque = long.Parse(Console.ReadLine());
                Console.Write("Data de Depósito (dd/MM/yyyy): ");
                DateTime dataDeposito = DateTime.Parse(Console.ReadLine());
                return new Cheque(total, numeroCheque, dataDeposito);
            }
            if (opcaoPagamento == 3)
            {
                Console.Write("Dados da Transação: ");
                string dadosTransacao = Console.ReadLine();
                Console.Write("Resultado da Transação: ");
                int resultadoTransacao = int.Parse(Console.ReadLine());
                return new Cartao(total, dadosTransacao, resultadoTransacao);
            }
            return null;
        }

        private void ListarVendas()
        {
            foreach (Venda venda in vendas)
            {
                Console.WriteLine(venda.Descrever());
            }
        }
    }
}
