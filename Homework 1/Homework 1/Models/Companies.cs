using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Models
{
    public class Companies
    {
        public Companies(string name, int worker_count)
        {
         
            Name = name;
            Max_Worker_count = worker_count;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Max_Worker_count { get; set; }
    }
}
