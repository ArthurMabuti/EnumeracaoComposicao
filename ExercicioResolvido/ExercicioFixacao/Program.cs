using System.Globalization;
using ExercicioFixacao;
using System.Collections.Generic;

List<Funcionario> employee = new List<Funcionario>();

Console.Write("Quantos funcionários há na empresa? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nEmployee #{i + 1}:");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employee.Add(new Funcionario(id, name, salary));
}

Console.Write("\nEnter the employee id that will have salary increase: ");
int idCheck = int.Parse(Console.ReadLine());

Funcionario employeeCheck = employee.Find(x => x.Id == idCheck);

if (employeeCheck != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employeeCheck.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine("\nUpdated list of employees:");

foreach (Funcionario obj in employee)
{
    Console.WriteLine(obj);
}



