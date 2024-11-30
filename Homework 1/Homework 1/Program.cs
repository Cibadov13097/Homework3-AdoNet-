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

            CRUD.CreateOfficePrinter(new Office_Printer("Canon", "AP234"));

            CRUD.ShowWorkerWithCompany(1);

            CRUD.ShowWorkerWithInfo(1);
        }
    }





}