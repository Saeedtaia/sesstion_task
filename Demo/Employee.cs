using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        public bool ValidateData()
        {
            return true;
        }
        private int id { get; set; }
        private string name { get; set; }
        private int salary { get; set; }
        private Gender gender { get; set; }



        public Employee(int id, string name, int salary, Gender gender)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.gender = gender;
        }


        public override string ToString()
        {
            return $"Your name : {name} \nYour id  : {id} \nyour salary : {salary}\nyour Gender : {gender}";
        }
    }
    
   
    internal enum Gender
    {
        Male,
        Female,
    }


}
