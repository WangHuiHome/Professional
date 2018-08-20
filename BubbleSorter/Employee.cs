using System;
namespace BubbleSorter
{
    public class Employee
    {
        public string Name {get;}
        public decimal Salary {get;}
        public Employee(string name,decimal salary)
        {
            Name = name;
            Salary = salary;
        }
        public override string ToString() => $"{Name},{Salary:C}";
        public static bool CompareSalary(Employee e1,Employee e2) => e1.Salary < e2.Salary;
    }
}