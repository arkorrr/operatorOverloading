class Program
{
    static void Main()
    {
        //Task1
        Employee emp1 = new Employee();
        emp1.InputData("Иван Иванов", new DateTime(1985, 5, 20), "123-456-7890", "ivan@company.com", "Менеджер", "Управление проектами", 50000);
        emp1.OutputData();

        Employee emp2 = new Employee();
        emp2.InputData("Петр Петров", new DateTime(1990, 6, 15), "098-765-4321", "petr@company.com", "Инженер", "Разработка ПО", 60000);
        emp2.OutputData();

        Console.WriteLine($"Зарплата сотрудника 1 == сотрудника 2: {emp1 == emp2}");
        emp1 += 10000;
        Console.WriteLine($"Зарплата сотрудника 1 после увеличения: {emp1.Salary}");

        //Task2
        City city1 = new City();
        city1.InputData("Киев", "Украина", 12000000, "+380", "Центральный, Северный, Западный");
        city1.OutputData();

        City city2 = new City();
        city2.InputData("Лондон", "Великобритания", 9000000, "+44", "Вестминстер, Кенсингтон, Челси");
        city2.OutputData();

        Console.WriteLine($"Население города 1 == города 2: {city1 == city2}");
        city1 += 1000000;
        Console.WriteLine($"Население города 1 после увеличения: {city1.Population}");
    }
}
