using Employees.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Employee> list = new List<Employee>();

                Console.Write("Digite o número de funcionários: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Dados do #{i} Funcionário:");
                    Console.Write("Terceiro (s/n)? ");
                    char terceiro = char.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Horas: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    if (terceiro.ToString().ToUpper().Equals("S"))
                    {
                        Console.Write("Despesas Adicionais: ");
                        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                    }
                    else
                    {
                        list.Add(new Employee(name, hours, valuePerHour));
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Pagamentos: ");

                foreach (Employee emp in list)
                {
                    Console.WriteLine($"{emp.Name} - R$ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
