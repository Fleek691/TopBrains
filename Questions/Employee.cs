using System;
using System.Collections.Generic;

public abstract class Employee
{
    public abstract decimal CalculatePay();
}

// Hourly employee
public class HourlyEmployee : Employee
{
    private decimal rate;
    private decimal hours;

    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override decimal CalculatePay()
    {
        return rate * hours;
    }
}

// Salaried employee
public class SalariedEmployee : Employee
{
    private decimal monthlySalary;

    public SalariedEmployee(decimal monthlySalary)
    {
        this.monthlySalary = monthlySalary;
    }

    public override decimal CalculatePay()
    {
        return monthlySalary;
    }
}

// Commission employee
public class CommissionEmployee : Employee
{
    private decimal commission;
    private decimal baseSalary;

    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        this.commission = commission;
        this.baseSalary = baseSalary;
    }

    public override decimal CalculatePay()
    {
        return baseSalary + commission;
    }
}

public class PayrollSystem
{
    public static decimal ComputeTotalPay(string[] employees)
    {
        decimal total = 0;

        foreach (var emp in employees)
        {
            string[] parts = emp.Split(' ');

            Employee employee = null;

            if (parts[0] == "H")
            {
                decimal rate = decimal.Parse(parts[1]);
                decimal hours = decimal.Parse(parts[2]);
                employee = new HourlyEmployee(rate, hours);
            }
            else if (parts[0] == "S")
            {
                decimal salary = decimal.Parse(parts[1]);
                employee = new SalariedEmployee(salary);
            }
            else if (parts[0] == "C")
            {
                decimal commission = decimal.Parse(parts[1]);
                decimal baseSalary = decimal.Parse(parts[2]);
                employee = new CommissionEmployee(commission, baseSalary);
            }

            total += employee.CalculatePay();
        }

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    // Example
    public static void Main()
    {
        string[] employees =
        {
            "H 200 5",
            "S 30000",
            "C 5000 20000"
        };

        decimal totalPay = ComputeTotalPay(employees);
        Console.WriteLine(totalPay);
    }
}
