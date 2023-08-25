namespace listaPrimeira_nivelamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1- Um imposto é calculado com base na seguinte tabela: 
             Até 1.200,00 isento 
             de 1.201,00 a 2.500,00 10%  OK
             de 2.501,00 a 5.000,00 15% 
             acima de 5.000,00 20%. 
             Implemente um programa que leia o valor base e calcule o imposto a pagar.
            */


            double salarioInicial = 0;



            Console.WriteLine("Digite seu salario");
             salarioInicial = double.Parse(Console.ReadLine());

            if (salarioInicial <= 1200)
            {
                Console.WriteLine("Isento de impostos");
            }
            else if (salarioInicial >= 1201 && salarioInicial <= 2500)
            {
                Console.WriteLine("O valor do imposto a pagar sera de R$ " + salarioInicial * 0.1 + "reais");
            }
            else if (salarioInicial >= 2501 && salarioInicial <= 5000)
            {
                Console.WriteLine(" O valor do imposto sera de R$" + salarioInicial * 0.15 + "reais");

            }
            else
            {
                Console.WriteLine(" O valor do imposto sera de R$" + salarioInicial * 0.20 + "reais");
            }
               

            
            Console.ReadKey();














        }
    }
}