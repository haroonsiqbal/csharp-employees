using System;
using System.Collections.Generic;

namespace employees {
    public class Company {
        public DateTime datefounded {get;}
        public string companyname {get;}
        public Company(string name, DateTime date) {
            employeelist = new List<Employee>();
            
            companyname = name;
            datefounded = date;
        }
        public List<Employee> employeelist {get; set;}
        public void AddEmployees(Employee name) {
            employeelist.Add(name);
        }
        public void ListEmployees() {
            foreach (Employee name in employeelist)
            {
                Console.WriteLine(name);
            }
        }
    }
}