namespace Cinema
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Filme filme = new Filme("Titanic", 2000, 222);

            Sala sala = new Sala() { quantidadeCadeiras = 100, Numero = 10 };

            Sessao sessao = new Sessao(sala, new DateTime(2023, 09, 02, 17, 20, 0));

            sessao.AddFilme(filme);
            Console.WriteLine(sessao);
        }
    }
}