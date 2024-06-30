using System;
using System.Globalization;

namespace Registro
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set;}

        public Funcionario(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;

        }

        public void IncreaseSalary(double percentage)
        {
            Salary = Salary + (Salary * (percentage / 100));
        }

        public override string ToString()
        {
            return Id+ ", " +Name+ ", " +Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}