namespace Task4;


public static class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee ("Иванов", "Программист"),
            new Employee ("Петров", "Бухгалтер"),
            new Employee ("Сидоров", "Менеджер"),
            new Employee ("Егоров", "Программист"),
            new Employee ("Удальцов", "Программист")
        };

        List<Salary> salaries = new List<Salary>
        {
            new Salary("Иванов", 100000),
            new Salary("Петров", 50000),
            new Salary("Сидоров", 70000),
            new Salary("Егоров", 80000),
            new Salary("Удальцов", 90000)
        };

        var combined = employees.Join(salaries, e => e.secondName, s => s.secondName, (e, s) => new { Employee = e, Salary = s.salary })
            .GroupBy(x => x.Employee.speciality)
            .Select(g => new { Specialty = g.Key, TotalSalary = g.Sum(x => x.Salary) });

        foreach (var item in combined)
        {
            Console.WriteLine($"Специальность: {item.Specialty}, Cумма зарплат: {item.TotalSalary}");
        }
    }
}