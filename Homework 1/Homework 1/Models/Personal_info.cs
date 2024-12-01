using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Models
{
    public class Personal_info
    {
        public Personal_info(string phone_number, string email, int worker_id)
        {
            Phone_number = phone_number;
            Email = email;
            Worker_id = worker_id;
        }

        public int Id { get; set; }
        public string Phone_number { get; set; }

        public string Email  { get; set; }

        public int Worker_id { get; set; }
    }
}
