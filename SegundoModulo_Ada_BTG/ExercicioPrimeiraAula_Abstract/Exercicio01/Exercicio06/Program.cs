
//Aqui estou declarando uma variavel e estanciando uma classe e passando um parametro/argumento que foi exigido.
//DiaDosNamorados amor = new("Daniel");
 

 

public abstract class CartaoWeb
{
    public string Destinatario { get; set; }

    //metodo abstrato não tem implementação
    //se não fosse abstrata eu colocaria {}
    public abstract string ShowMessage();

}

//classe filha, herdando da mãe .
public class DiaDosNamorados : CartaoWeb
{
    //este é um construtor, ele recebe o destinatario que vem da classe mãe
    //tudo que fica dentro do () é parametro ,tipo(ex string) e um nome(ex o nome da variavel)
    public  DiaDosNamorados(string destinatario)//aqui tem a variavel destinatario 
    {
        //atributo
        Destinatario = destinatario;
    }
    //metodo
    public override string ShowMessage()
    {
        return $"Feliz Dia dos Namorados, {Destinatario}!";
    }
}

public class Natal : CartaoWeb
{
    //ctor eu crio um construtor da classe - atalho
    public Natal(string familia)
    {
        Destinatario = familia;
    }

    public override string ShowMessage()
    {
       return $"Feliz Natal, {Destinatario}!";
    }
}

public class Aniversario : CartaoWeb
{

    public Aniversario(string pessoa)
    {
        Destinatario = pessoa;
    }

    //metodo
    public override string ShowMessage()
    {
        return $"Feliz Aniversário, {Destinatario}!";
    }
}

