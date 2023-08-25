namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              6- Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
                Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, 
                mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para 
                fora do intervalo).
             */


            
           

            Console.Write("Entre com a quantidade de números que deverão ser lidos: ");
            
            int quantidade = int.Parse(Console.ReadLine());
            int dentroIntervalo = 0;
            int foraIntervalo = 0;


            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write("Digite o numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero >= 10 && numero <= 20)
                {
                    dentroIntervalo++;
                }
                else { foraIntervalo++; }
            }
            Console.WriteLine("A quantidade de numeros inteiros que temos dento do intervalode 10 e 20 são ");
            Console.WriteLine($"in: {dentroIntervalo}");
            Console.WriteLine($"out: {foraIntervalo}");

            Console.ReadKey();
        }
    }
}