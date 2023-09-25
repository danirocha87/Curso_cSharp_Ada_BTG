namespace MinhaPrimeiraApi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);


            //aqui diz para o builder minha aplicação que eu vou usar os  controllers
            //aqui ele cria classes, rotas 
            builder.Services.AddControllers();

            var app = builder.Build();

            //aqui faz o mapeamento dos endpoints
            //aqui que acontece os mapGet,mapPost etc.
            app.MapControllers();

            app.Run();
        }
    }
}