using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask.Inheritance
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
        
        }

        public Person(int ıd, string firstName, string lastName)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
        }

        public void BilgiGöster()
        {
            Console.WriteLine($"Id: {Id}, Name: {FirstName}, Lastname: {LastName}");
        }
    }

    public class Employee : Person
    {
        public string Department { get; set; }

        public Employee()
        {
        
        }

        public Employee(string department)
        {
            Department = department;
        }
    }

    public class Manager : Employee
    {
        public string Section { get; set; }

        public Manager()
        {
        
        }

        public Manager(string section)
        {
            Section = section;
        }    
    }

    public class Assistans:Employee
    {
        public Assistans()
        {
            
        }

    
    }
}





