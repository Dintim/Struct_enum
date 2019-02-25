using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_structure
{
    public struct Employee : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Sex Sex { get; set; }
        public Position Position { get; set; }
        public DateTime HiredDate { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string surname, Sex sex, Position pos, DateTime hiredDate, double salary)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Position = pos;
            HiredDate = hiredDate;
            Salary = salary;
        }
        public override string ToString()
        {
            string str = string.Format("Имя: {0}\nФамилия: {1}\nДолжность: {2}\nДата принятия на работу: {3: dd.MM.yyyy}\nОклад: {4}\n",
                Name, Surname, Position, HiredDate, Salary);
            return str;
        }

        public bool IsPosition(Position pos)
        {
            return this.Position == pos;
        }
        public bool SalaryMoreThanAvg(double avgSalary)
        {
            return Salary >= avgSalary;
        }
        public bool HiredLaterThanDate(DateTime date)
        {
            return HiredDate >= date;
        }
        public bool IsSex(Sex s)
        {
            return Sex == s;
        }
        public bool IsSex()
        {
            return true;
        }
    }

    public class Employees
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }

        public void PrintAllEmployees()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
        }

        public void PrintEmployeesByPosition(Position pos)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].IsPosition(pos))
                    Console.WriteLine(employees[i].ToString());
            }
        }

        public void PrintEmployeesBySalary()
        {
            double avg = employees.Average(e => e.Salary);
            var emp = employees.OrderBy(e => e.Surname);
            foreach (Employee i in emp)
            {
                if (i.SalaryMoreThanAvg(avg))
                    Console.WriteLine(i.ToString());
            }
        }
        
        public void PrintEmployeesByHiredDate(DateTime date)
        {
            var emp = employees.OrderBy(e => e.Surname);
            foreach (Employee i in emp)
            {
                if (i.HiredLaterThanDate(date))
                    Console.WriteLine(i.ToString());
            }
        }

        public void PrintEmployeesBySex(Sex s)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].IsSex(s))
                    Console.WriteLine(employees[i].ToString());
            }
        }

        public void PrintEmployeesBySex()
        {
            PrintAllEmployees();
        }

    }
}
