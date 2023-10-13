using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console_App
{
    internal class Department
    {
        public int No { get; set; }

        private int _employeelimit;
        public int EmployeeLimit
        {
            get
            {
                return _employeelimit;
            }
            set
            {
                if (value > 0 && value < 20)
                {
                    value = _employeelimit;
                }
            }
        }

        public Employee[] Employees = new Employee[0];

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }

        public void GetEmployee(string name, string surname)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Name == name && Employees[i].Surname == surname)
                {
                    Console.WriteLine($"Name:{name},Surname:{surname}");
                }
                else
                {
                    Console.WriteLine("Bele bir isci yoxdur");
                }
            }

        }
        public void GetEmployeeInfo()
        {
            foreach (var item in Employees) 
            {
                Console.WriteLine($"Name:{item.Name},Surname:{item.Surname}, Age:{item.Age}, Salery:{item.Salary}");
            }
        }

        public void GetAllEmployees()
        {
            if(Employees.Length > 0 )
            {
                foreach (var item in Employees) 
                {
                    Console.WriteLine($"Name:{item.Name}, Surname:{item.Surname}");
                }
            }
        }













    }
      
        
        
        
        
        
        
        
        
        
        



    }
