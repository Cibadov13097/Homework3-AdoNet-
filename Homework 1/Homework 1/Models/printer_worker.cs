using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Models
{
    public  class printer_worker
    {
        public printer_worker(int worker_Id, int printer_Id)
        {
            Worker_Id = worker_Id;
            Printer_Id = printer_Id;
        }

        public int Id { get; set; }
        public int Worker_Id { get; set; }
        public int Printer_Id { get; set; }
    }
}
