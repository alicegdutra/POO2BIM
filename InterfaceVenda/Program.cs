
using InterfaceVendas;


ControladorVendas controlador = new ControladorVendas();
controlador.Executar();

public class ControladorVendas
{
    private List<Produto> produtos = new List<Produto>();

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
                    ListarProdutos();
                    break;
            }
        } while (opcao != 3);
    }

    private void MostrarMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Cadastrar Produto");
        Console.WriteLine("2. Listar Produtos");
        Console.WriteLine("3. Sair");
    }

    private int LerOpcao()
    {
        Console.Write("Escolha uma opção: ");
        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            return opcao;
        }
        return 0;
    }

    private void CadastrarProduto()
    {
        Console.Write("Código do Produto: ");
        if (!int.TryParse(Console.ReadLine(), out int codigo)) return;

        Console.Write("Nome do Produto: ");
        string nome = Console.ReadLine();

        Console.Write("Preço do Produto: ");
        if (!double.TryParse(Console.ReadLine(), out double preco)) return;

        produtos.Add(new Produto(codigo, nome, preco));
        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    private void ListarProdutos()
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto.Mostrar());
        }
    }
}
