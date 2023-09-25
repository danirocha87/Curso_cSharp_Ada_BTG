
using Microsoft.AspNetCore.Builder;

namespace AplicacaoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //aqio eu crio o builder para poder criar alguma coisa e 
            //automaticamente cria o using
            var builder = WebApplication.CreateBuilder();


            //depois de criar um builder eu ja posso criar meu app 
            //e colocar o que quiser 
            // builder.Build = construtor.Construir
            var app = builder.Build();

            //aqui eu crio o caminho que devo acessar a minha API
            //neste caso a rota foi /api mas poderia ser qualquer nome
            //aqui eu crio um metodo anonimo(anonimo porque não tem nome) antes eu criava assim 
            /*
             void MeuMetodo(){}
            *///agora eu crio desta forma 

            app.MapGet("/api/{nome}", (string nome) =>
            {
                //AQUI EU RETORNO A MENSAGEM QUE QUERO VER EX
                return $"Olá {nome}, bem vindo ao mundo das APIs";
            });
            
                
          app.Run();
        }
    }
}