namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4- Escrever um programa que preencha um vetor de 100 elementos com valores inteiros aleatórios, e 
                iden0fique o maior e o menor número gerados, e respec0vas posições.
             */


            Random random= new Random();
            int[] valoresInteiros = new int[100];

            for (int i = 0; i < 10; i++)
            {
                var numeroAleatorio = random.Next(100);
                Console.WriteLine(numeroAleatorio);
                valoresInteiros[i] = numeroAleatorio;
            }

            Array.Sort(valoresInteiros);
            int menorNumero= valoresInteiros.GetLowerBound(0);
            Console.WriteLine( "o menor numero esta na posição"  + menorNumero);
            int maiorNumero= valoresInteiros.GetUpperBound(0);
            Console.WriteLine("o maior numero esta na posição" + maiorNumero);

            Console.WriteLine("O menor valor é" + valoresInteiros[menorNumero]);
            Console.WriteLine("O maior valor é" + valoresInteiros[maiorNumero]);




        
        
        }
    }
}