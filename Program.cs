using System;

namespace employees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company randcorp = new Company("Rand Corp", DateTime.Now);
            
            // Create three employees
            
            Employee danny = new Employee("Danny", "Rand", "CEO", new DateTime(2014, 01, 13));
            Employee karen = new Employee("Karen", "Page", "CFO", new DateTime(2016, 04, 27));
            Employee matt = new Employee("Matthew", "Murdoch", "General Counsel", new DateTime(2019, 11, 07));

            // Assign the employees to the company
            
            randcorp.AddEmployees(danny);
            randcorp.AddEmployees(karen);
            randcorp.AddEmployees(matt);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (Employee employee in randcorp.employeelist)
            {
                Console.WriteLine($"{employee.firstname} {employee.lastname} works for {randcorp.companyname} as {employee.title} since {employee.startdate}");
            }

        }
    }
}
