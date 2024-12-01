using Homework_1.Services;
using Homework_1.Models;

namespace Homework1
{

    public class Program
    {



        public static void Main()
        {

            string connectionString = "Server=DESKTOP-K0386GG;Database=Homework1;Trusted_Connection=True;";


            CRUDservices CRUD = new CRUDservices();

            //CRUD.CreateCompany(new Companies("AKKO", 100));

            //CRUD.CreateWorker(new Workers("Javid", 19, 4500, 1,1),new Personal_info("055 564 47 75","Javid@gmail.com"));

            //CRUD.EditWorker(1);


            //CRUD.CreateWorker(new Workers("Cavid", 19, 2000, 1),new Personal_info("055 564 43 75","Cavid@gmail.com",1));

            CRUD.CreateOfficePrinter(new Office_Printer("Samsung", "AS123"));
            CRUD.AllowPrinterUse(new printer_worker(1, 2));

            CRUD.ShowWorkerWithCompany(1);

            CRUD.ShowWorkerWithInfo(1);

            

            CRUD.CheckPrinterAccess(1);
        }
    }





}