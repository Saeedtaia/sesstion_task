using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
     class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee(1, "ahmed" , 5000 , Gender.Male);
            if (employee1.ValidateData())
            {
                Console.WriteLine("Data is valid.");
            }
            else
            {
                Console.WriteLine("Data is invalid.");
            }
        }
    }
}
