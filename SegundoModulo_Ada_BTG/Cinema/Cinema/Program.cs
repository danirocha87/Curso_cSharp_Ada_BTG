namespace Cinema
{
    internal class Program
    {
        private static void Main(string[] args)
        {   
            
            //aqui uso a classe Filme
            Filme filme = new ("Titanic", 2000, 222);
            //instanciando 
            
            Sala sala = new()
            {
                //propriedade
                quantidadeCadeiras = 10,
                Numero = 5
            };

            Sessao sessao = new (sala, new DateTime(2023, 09, 02, 17, 20, 0));
           
            sessao.AddFilme(filme);
            Console.WriteLine(sessao);
        }
    }
}