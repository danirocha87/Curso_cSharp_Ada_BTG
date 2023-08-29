/*
  Crie a interface IData que fornece os métodos: void  setData(DateTime  data), ok
que ajusta a data do objeto; DateTime  getData(), que retorna a data do objeto;ok
e string  dataString, que retorna a data do objeto como uma string. ok
Crie uma classe Produto que possui nome, valor e data de validade -ok

Crie uma classe Venda que possui data e produto. - ok
Produto e Venda implementam a interface IData. -ok
Crie uma classe estática chamada TestarVenda -ok
e um método estático chamado DetalhesVenda - ok
que recebe uma Venda e retorna uma string com os dados da venda.

Exemplo:
 */



Produto produto = new Produto();
produto.nome = "Leite Integral";
produto.valor = 5;
produto.setData(new DateTime(2023, 3, 1));
Venda venda = new Venda();
venda.produto = produto;
venda.setData(DateTime.Now);
TestarVenda.DetalhesVenda(venda); //"Data da venda: 29/10/2022 - Produto: Leite Integral - Valor do produto: 5 - Vencimento: 01/03/2023"



public interface IData


{
    public void setData(DateTime data);
    public DateTime getData();
    public string dataString();

}

public class Produto : IData
{
    public string nome { get; set; }
    public int valor { get; set; }
   
    public DateTime DataValidade { get; set; }

    public string dataString()
    {
       return DataValidade.ToString("dd/MM/yyyy");
    }

    public DateTime getData()
    {
        return DataValidade;
    }

    public void setData(DateTime data)
    {
        DataValidade= data;
    }
}

public class Venda : IData
{
    //atributo ou propriedade{}
    public  DateTime Data { get; set; }
    public Produto produto { get; set; }

    public string dataString()
    {
        return Data.ToString("dd/MM/yyyy");
    }

    public DateTime getData()
    {
        return Data;
    }

    public void setData(DateTime data)
    {
         Data = data;
    }
}

public static class TestarVenda
{
    //metodo ()
    public static string DetalhesVenda(Venda venda)
    {
        //"Data da venda: 29/10/2022 - Produto: Leite Integral - Valor do produto: 5 - Vencimento: 01/03/2023"
        //Console.WriteLine($"Data de venda: {venda.dataString()} - Produto: {venda.produto.nome} - Valor do produto: {venda.produto.valor} - Vencimento: {venda.produto.dataString()} ");
        return $"Data da venda: {venda.dataString()} - Produto: {venda.produto.nome} - Valor do produto: {venda.produto.valor} - Vencimento:{venda.produto.dataString()}";
    }
}
    