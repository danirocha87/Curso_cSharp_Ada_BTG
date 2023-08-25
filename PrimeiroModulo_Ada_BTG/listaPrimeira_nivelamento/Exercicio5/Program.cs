namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5- Um Posto de combus>veis deseja determinar qual de seus produtos tem a preferência de seus clientes.
             Escreva um algoritmo para ler o tipo de combustvel abastecido (codificado da seguinte forma: 1.Álcool 
             2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser 
             solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o 
             número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram 
             cada tipo de combustvel, conforme exemplo.
             */

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            bool combustivel = true;
            int opcao = 0;

            Console.WriteLine("Escolha o numero que corresponde ao combustivel que utilizou.");
            Console.WriteLine("1.Álcool");
            Console.WriteLine("2.Gasolina");
            Console.WriteLine("3.Diesel");
            Console.WriteLine("4.Fim");
            
            int  opcao = int.Parse(Console.ReadLine());

            while (combustivel)
            {

                

                switch (combustivel)
                {
                    case "1":
                        alcool ++;
                        break;
                    case "2":
                        gasolina ++;
                        break;
                    case "3":
                        diesel ++;
                        break;
                    case "4":
                        combustivel = false;
                        break;
                    default:
                        Console.WriteLine("O valor inserido deve ser um número de 1 a 4.");
                        break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Álcool:" + alcool);
            Console.WriteLine($"Gasolina:" + gasolina);
            Console.WriteLine($"Diesel:" + diesel);
            Console.ReadKey();


        }
    }
}