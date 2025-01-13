using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }

        public Employee(int id, string name, double? salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee? CompareEmployee = (Employee?)obj;
            if (this.Salary > CompareEmployee?.Salary)
                return 1;
            else if (this.Salary < CompareEmployee?.Salary)
                return -1;
            else
            {
                return 0;
            }
        }
    }
}