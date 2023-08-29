public interface IVeiculos
{
    //metodo ()
    public string Dirigir();
    //metodo()
    //parametro int quantidadeGasolina
    //variavel com letra minuscula quantidadeGasolin
    public bool Reabastecer(int gasolina);
}

public class Carro : IVeiculos
{

    //ctor - construtor 
    public Carro(int quantidadeGasolinaInicial) //parametro ou argumento int quantidadegasolineInicial
    {
        Tanque = quantidadeGasolinaInicial;
    }

    public int Tanque { get; set; }

    public string Dirigir()
    {
       if(Tanque > 0)
        {
            return "Dirigindo";
        }
        else
        {
            //string vazia 
            return "Sem combustível";
        }
    }

    public bool Reabastecer(int gasolina)
    {
        Tanque += gasolina;
        return true;
    }
}
