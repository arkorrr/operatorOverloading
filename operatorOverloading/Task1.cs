using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Employee
{
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ContactPhone { get; set; }
    public string WorkEmail { get; set; }
    public string Position { get; set; }
    public string JobDescription { get; set; }
    public decimal Salary { get; set; }

    public void InputData(string fullName, DateTime dateOfBirth, string contactPhone, string workEmail, string position, string jobDescription, decimal salary)
    {
        FullName = fullName;
        DateOfBirth = dateOfBirth;
        ContactPhone = contactPhone;
        WorkEmail = workEmail;
        Position = position;
        JobDescription = jobDescription;
        Salary = salary;
    }

    public void OutputData()
    {
        Console.WriteLine($"ФИО: {FullName}");
        Console.WriteLine($"Дата рождения: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Контактный телефон: {ContactPhone}");
        Console.WriteLine($"Рабочий email: {WorkEmail}");
        Console.WriteLine($"Должность: {Position}");
        Console.WriteLine($"Описание служебных обязанностей: {JobDescription}");
        Console.WriteLine($"Заработная плата: {Salary:C}");
    }

    public static Employee operator +(Employee employee, decimal increase)
    {
        employee.Salary += increase;
        return employee;
    }

    public static Employee operator -(Employee employee, decimal decrease)
    {
        employee.Salary -= decrease;
        return employee;
    }

    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Salary == emp2.Salary;
    }

    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    public static bool operator <(Employee emp1, Employee emp2)
    {
        return emp1.Salary < emp2.Salary;
    }

    public static bool operator >(Employee emp1, Employee emp2)
    {
        return emp1.Salary > emp2.Salary;
    }

    public override bool Equals(object obj)
    {
        if (obj is Employee employee)
        {
            return Salary == employee.Salary;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Salary.GetHashCode();
    }
}

