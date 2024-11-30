using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Models
{
    public  class Office_Printer
    {
        public Office_Printer(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Model { get; set; }

    }
}
