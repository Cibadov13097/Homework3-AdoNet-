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

            CRUD.CreateCompany(new Companies("AKKO", 100));

            CRUD.CreateWorker(new Workers("Javid", 19, 4500, 1));

            CRUD.EditWorker(1);

            CRUD.ShowWorkerWithCompany(1);
        }
    }





}