using System;
using System.Globalization;

namespace FUNCIONARIO_SALARIO_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Funcionario {f1}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            f1.AumentarSalario(porcent);
            Console.WriteLine($"Funcionario {f1}");
            Console.WriteLine();


        }
    }
}
