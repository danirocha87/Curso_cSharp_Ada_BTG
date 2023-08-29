// aqui crie uma classe abstract
public abstract class Figura
{
    //aqui criei uma propriedade abstrata
    public abstract string Cor { get; set; }

    //Método abastrato
    public abstract double Area();
}

public class Retangulo : Figura

{
    //atributo
    public double Lado1 { get; set; }
    //atributo
    public double Lado2 { get; set; }


    // propriedade ou atributo
    public override string Cor { get; set; }

    //metodo
    public override double Area()
    {

        return Lado1 * Lado2;
    }
}

public class Triangulo : Figura
{
    //atributo
    public double Base { get; set; }
    //atributo
    public double Altura { get; set; }

    //atributo
    public override string Cor { get; set; }

    //metodo
    public override double Area()
    {
        return Base * Altura;
    }
}

public static class Teste
{
    public static string DetalhesFigura(Figura figura)
    {
        return $"Cor da figura: {figura.Cor} - Área da figura: {figura.Area()}";
    }

}




