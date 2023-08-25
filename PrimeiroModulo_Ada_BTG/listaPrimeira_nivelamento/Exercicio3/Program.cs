namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              3- Faça um algoritmo para ler: quan0dade atual em estoque, quan0dade máxima em estoque e quan0dade 
                mínima em estoque de um produto. Calcular e escrever a quan0dade média ((quan0dade média = 
                quan0dade máxima + quan0dade mínima)/2). Se a quan0dade em estoque for maior ou igual a quan0dade 
                média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'. 
             */

            int quantidadeEmEstoque = 0;
            int quantidadeMaxima = 0;
            int quantidadeMinima = 0;
            int media = 0;

            Console.WriteLine("Digite a quantidade em estoque do produto em  estoque.");
            quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade maxima do produto em  estoque.");
            quantidadeMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade minima  do produto em  estoque.");
            quantidadeMinima = int.Parse(Console.ReadLine());

            media = (quantidadeMaxima + quantidadeMinima) / 2;
            Console.WriteLine(" A média em estoque é de "+ media);

            if (quantidadeEmEstoque >= media)
            {
                Console.WriteLine("Não efetuar compra");
            }
            else
            {
                Console.WriteLine("Efetuar compra.");
            }

        }
    }
    
}
