using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1hw
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public Employee()
        {
            Console.WriteLine("baslatılıyor...");
            
        }

        public Employee(int ıd, string firstName, string lastName)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string? ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }


    }
}
