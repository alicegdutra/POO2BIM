using InterfaceVendas;


public class IniciarMenu
{
    public void MenuIniciar()
    {
        Menu menu = new Menu();
        menu.Iniciar();
    }
}

public class Menu
{
    private List<Produto> produtos = new List<Produto>();
    private List<Venda> vendas = new List<Venda>();

    public void Iniciar()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Registrar Venda");
            Console.WriteLine("3. Mostrar Vendas");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarProduto();
                    break;
                case 2:
                    RegistrarVenda();
                    break;
                case 3:
                    MostrarVendas();
                    break;
                case 4:
                    continuar = false;
                    break;
            }
        }
    }

    private Produto EncontrarProdutoPorCodigo(int codigo)
    {
        foreach (Produto produto in produtos)
        {
            if (produto.Codigo == codigo)
            {
                return produto;
            }
        }
        return null;
    }

    private void CadastrarProduto()
    {
        Console.Write("Código do Produto: ");
        int codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nome do Produto: ");
        string nome = Console.ReadLine();
        Console.Write("Preço do Produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Produto produto = new Produto(codigo, nome, preco);
        produtos.Add(produto);

        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    private void RegistrarVenda()
    {
        Console.Write("Código da Venda: ");
        int codigoVenda = Convert.ToInt32(Console.ReadLine());

        Venda venda = new Venda(codigoVenda);

        bool adicionarItens = true;
        while (adicionarItens)
        {
            Console.Write("Código do Produto: ");
            int codigoProduto = Convert.ToInt32(Console.ReadLine());
            Produto produto = EncontrarProdutoPorCodigo(codigoProduto);

            if (produto != null)
            {
                Console.Write("Quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                ItemVenda itemVenda = new ItemVenda(produto, quantidade);
                venda.AdicionarItem(itemVenda);
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }

            Console.Write("Deseja adicionar mais itens? (s/n): ");
            adicionarItens = Console.ReadLine().ToLower() == "s";
        }

        Console.WriteLine("Escolha a forma de pagamento:");
        Console.WriteLine("1. Espécie");
        Console.WriteLine("2. Cheque");
        Console.WriteLine("3. Cartão");
        Console.Write("Opção: ");
        int opcaoPagamento = Convert.ToInt32(Console.ReadLine());

        Pagamento pagamento = null;

        switch (opcaoPagamento)
        {
            case 1:
                pagamento = new Especie(venda.CalcularTotal());
                break;
            case 2:
                Console.Write("Número do Cheque: ");
                long numeroCheque;
                if (long.TryParse(Console.ReadLine(), out numeroCheque))
                {
                    pagamento = new Cheque(venda.CalcularTotal(), numeroCheque);
                }
                else
                {
                    Console.WriteLine("Número de cheque inválido!");
                }
                break;
            case 3:
                Console.Write("Dados da Transação: ");
                string dadosTransacao = Console.ReadLine();
                Console.Write("Resultado da Transação: ");
                int resultadoTransacao;
                if (int.TryParse(Console.ReadLine(), out resultadoTransacao))
                {
                    pagamento = new Cartao(venda.CalcularTotal(), dadosTransacao, resultadoTransacao);
                }
                else
                {
                    Console.WriteLine("Resultado de transação inválido!");
                }
                break;
        }

        if (pagamento != null)
        {
            venda.ProcessarPagamento(pagamento);
            vendas.Add(venda);
            Console.WriteLine("Venda registrada com sucesso!");
        }
    }

    private void MostrarVendas()
    {
        foreach (Venda venda in vendas)
        {
            Console.WriteLine(venda.Mostrar());
        }
    }
}
