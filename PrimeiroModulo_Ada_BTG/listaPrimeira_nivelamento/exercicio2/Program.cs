namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2- A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 
             horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um 
             algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do 
             funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês 
             possua 4 semanas exatas).
            */



             int horasSemanais = 40;
            int semanasNoMes = 4;
            double acrescimoHoraExtra = 0.5; // 50%

            Console.Write("Digite o número de horas trabalhadas em um mês: ");

            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Digite o salário por hora: ");
            double salarioPorHora = double.Parse(Console.ReadLine());

            if (horasTrabalhadas <= horasSemanais * semanasNoMes)
            {
                double salarioTotal = horasTrabalhadas * salarioPorHora;
                Console.WriteLine($"Salário total do funcionário: R${salarioTotal:F2}");
            }
            else
            {
                double horasExtras = horasTrabalhadas - (horasSemanais * semanasNoMes);
                double salarioTotal = (horasSemanais * semanasNoMes * salarioPorHora) +
                                     (horasExtras * salarioPorHora * (1 + acrescimoHoraExtra));
                Console.WriteLine($"Salário total do funcionário (com horas extras): R${salarioTotal:F2}");
            }



        }
    }
}
