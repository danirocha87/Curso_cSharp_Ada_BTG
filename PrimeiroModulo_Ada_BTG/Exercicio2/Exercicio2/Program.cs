namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque).
            Em seguida:• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)• 
            Realizar uma entrada no estoque e mostrar novamente os dados do produto• Realizar uma saída no estoque e mostrar novamente os dados do produto
             */


            try
            {
                string logo = ($"------{Environment.NewLine}-------- Controle do Estoque --------{Environment.NewLine}-----------------------------------------");
                Console.WriteLine(logo);

                produto produto1 = new();

                Console.WriteLine("Digite os dados do produto:");
                Console.Write("Nome: ");
                produto1.nome = Console.ReadLine();

                Console.Write("Preço: ");
                produto1.preco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade no estoque: ");
                produto1.quantidade = int.Parse(Console.ReadLine());


                Console.Clear();
                Console.WriteLine(logo);
                Console.WriteLine("Dados do produto:");
                Console.WriteLine(produto1);

                Console.WriteLine($"{Environment.NewLine}Opções:");
                Console.WriteLine("1 - Adicionar itens ao estoque");
                Console.WriteLine("2 - Remover itens do estoque");
                Console.WriteLine("0 - Sair");


                while (true)
                {
                    Console.Write($"{Environment.NewLine}Escolha uma opção: ");
                    int opcao = int.Parse(Console.ReadLine());

                    if (opcao == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(logo);
                        Console.WriteLine("Você saiu do controle de estoque!");
                        break;
                    }
                    else if (opcao == 1)
                    {
                        Console.Write($"{Environment.NewLine}Digite a quantidade a ser adicionada no estoque: ");
                        int quantidadeAdicionada = int.Parse(Console.ReadLine());
                        produto1.AdicionarProduto(quantidadeAdicionada);
                        Console.Clear();
                        Console.WriteLine(logo);
                        Console.WriteLine("Dados do produto após adição no estoque:");
                        Console.WriteLine(produto1);
                    }
                    else if (opcao == 2)
                    {
                        Console.Write($"{Environment.NewLine}Digite a quantidade a ser removida do estoque: ");
                        int quantidadeRemovida = int.Parse(Console.ReadLine());
                        produto1.RemoverProduto(quantidadeRemovida);
                        Console.Clear();
                        Console.WriteLine(logo);
                        Console.WriteLine("Dados do produto após remoção do estoque:");
                        Console.WriteLine(produto1);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Escolha novamente.");
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}