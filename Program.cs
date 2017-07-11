using System;
using System.Linq;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
        // In the Main method, create a company, and three employees
        Company firstCompany = new Company("Dogz", DateTime.Now);
        Employee employeeOne = new Employee ("Kathy", "Walker", DateTime.Now);
        Employee employeeTwo = new Employee ("Cara", "Groomer", DateTime.Now);
        Employee employeeThree = new Employee ("Sophie", "Treat Eater", DateTime.Now);

        // and then assign the employees to the company.
        firstCompany.AddEmployee(employeeOne);
        firstCompany.AddEmployee(employeeTwo);
        firstCompany.AddEmployee(employeeThree);

        firstCompany.ListEmployees();
        }
    }
}
    public class Company
{
    public Company (string name, DateTime date)
    {
            this.Name = name;
            this.Startdate = date;
        }

    public string Name { get; }
    public DateTime Startdate { get; }
    
    // Create a method that allows external code to add an employee
    public void AddEmployee(Employee person) {
        EmployeeList.Add(person);
    }

    // Create a method that allows external code to remove an employee
    public void RemoveEmployee(Employee person) {
        EmployeeList.Remove(person);
    }
    // Update the Company class to write the name of each employee to the console. 
    // Consider a method named ListEmployees().
    public void ListEmployees(){
        Console.WriteLine($"List of employees: ");
        foreach (Employee item in EmployeeList){
            Console.WriteLine($"{item.Name} started his/her job as {item.Jobtitle} on {item.Date}");
        }
    }

    // Create a property for holding a list of current employees
    List<Employee> EmployeeList = new List<Employee>();
        
}

    // Create a class that contains information about employees of a company and define methods 
    // to get/set employee name, job title, and start date.
    public class Employee {
        public string Name { get; set; }
        public string Jobtitle { get; set; }
        public DateTime Date { get; set; }
        public Employee (string name, string jobtitle, DateTime date)
        {
            this.Name = name;
            this.Jobtitle = jobtitle;
            this.Date = date;
        }
    
    }
   