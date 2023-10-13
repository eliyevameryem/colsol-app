using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string DepartmanNo { get; set; }
        public int Salary { get; set; }
        public Employee(string name, string surname, int age,string departmanno,int salary )
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmanNo = departmanno;
            Salary = salary;
        }
    }
}
