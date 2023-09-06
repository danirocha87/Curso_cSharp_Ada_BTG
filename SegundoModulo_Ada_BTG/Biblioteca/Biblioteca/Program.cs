using System;

namespace Biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro(1, "50 Tons de Cinza", "E.L.James - ", 2011, 544);

            Revista revista = new Revista(1, "Capricho", "Victor Civita", 1952, 30);

            MidiaDigital midia = new MidiaDigital(1, "Tudo posso", "O mundo", 1987, 36);

            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AdicionarItem(livro);
            biblioteca.AdicionarItem(revista);
            biblioteca.AdicionarItem(midia);

            DateTime dataEmprestimo = DateTime.Now;
            DateTime dataDevolucao = dataEmprestimo.AddDays(14);

            Imprimir.ImprimirLivro(dataDevolucao, dataEmprestimo, livro);
            Console.WriteLine();
            Imprimir.ImprimirRevista(dataDevolucao, dataEmprestimo, revista);
            Console.WriteLine();
            Imprimir.ImprimirMidiaDigital(dataDevolucao, dataEmprestimo, midia);

            Console.ReadKey();
        }
    }
}
