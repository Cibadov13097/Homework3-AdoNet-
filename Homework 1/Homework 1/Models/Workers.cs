using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Models
{
    public  class Workers
    {
        public Workers( string name,int age, float salary, int company_id)
        {
            
            Name = name;
            Age = age;
            Salary = salary;
            Company_id = company_id;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public float Salary { get; set; }

        public int Company_id { get; set; }
    }
}
