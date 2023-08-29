public interface IAnimal
{
    public void comer(string comida);
    public void dormir();
    public string emitirSom();
}

public class Cachorro : IAnimal
{
    public string nome { get; set; }
    public string raca { get; set; }

    public void comer(string comida) { }
    public void dormir() { }
    public string emitirSom() { return "AuAu"; }
}

