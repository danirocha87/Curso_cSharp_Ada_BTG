
//aqui importa quando herdo do controlleBase
using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraApi.Controllers
{
    //2 passo anotar a classe como apicontroller
    [ApiController]

    //5-aqui eu coloco a rota que esta minha API, o que eu quero acessar 
    [Route("api")]

   

   // 1- passoaqui para criar a APIWEB EU HERDO: CONTROLLERBASE
    public class CidadesContoller : ControllerBase
    {
       //6- aqui uso o httpGet porque quero pegar a minha informação no caso a cidade
        [HttpGet("cidade")]

        //3 crio as action
        //as action tem que retorna alguma coisa
        //um objectResult retorna uma ActionResult, consigo consultar isso vendo de onde vem o codigo f12
        public ActionResult GetMinhaCidade()
        {
            //4-o metodo ok cria um objetoResult e retorna o que quero
            // return Ok("São Vicente");OK é um método
            //pode ser um string,um int etc
            //outra forma de fazer
            //ela resulta do codigo 200 ok status
            return new OkObjectResult("São Vicente");
        }


        //caso eu queira passar mais alguma informação só mudar aqui
        [HttpGet("saopaulo")]
        public ActionResult GetSaoPaulo(CidadePost cidade)
        {
            return new OkObjectResult("São Paulo a melhor cidade");
        
        }

        //caso eu queira passar mais alguma informação só mudar aqui
        [HttpPost("saopaulo3")]
        public ActionResult PostSaoPaulo3(CidadePost cidade)
        {
            return new OkObjectResult($"Olá, você é de {cidade.Nome}");

        }
        //O ApiController consegue retorna uma string por parametro
        //O AspNet não consegue fazer a construição de um parametro do tipo simples
        //porque quando manda a informação ela sempre vai em um PAR chave valor.
        //E o AspiNetCore não entende que a chave é o nome da variavel 
        //então temos que criar uma classe que tenha só a propriedade que quero acessar
        //e recebo no parametro uma estancia dessa classe

     
    }

    public class CidadePost
    {
        public string Nome { get; set; }
    }


}
