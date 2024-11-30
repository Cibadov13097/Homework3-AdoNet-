using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Models
{
    public  class Workers
    {
        public Workers( string name,int age, float salary, int company_id,int personal_info_id)
        {
            
            Name = name;
            Age = age;
            Salary = salary;
            Company_id = company_id;
            Personal_info_id = personal_info_id;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public float Salary { get; set; }

        public int Company_id { get; set; }

        public int Personal_info_id { get; set; }
    }
}
