﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Homework_1.Models;


namespace Homework_1.Services
{
    public class CRUDservices
    {
        public const string connectionString = "Server=DESKTOP-K0386GG;Database=Homework1;Trusted_Connection=True;";


      public void CreateCompany(Companies company)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "INSERT INTO companies VALUES(@Name,@Workers_count)";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            
            sqlCommand.Parameters.AddWithValue("@Name",company.Name);
            sqlCommand.Parameters.AddWithValue("@Workers_count", company.Max_Worker_count);

            sqlCommand.ExecuteNonQuery();
        }


        public void ShowWorkerWithCompany(int id)
        {
            List<Workers> workers = new List<Workers>();
            string query = "SELECT w.Id, w.Name, w.Age, c.Name AS CompanyName FROM Workers w JOIN Companies c ON w.Company_id = c.id WHERE w.Id = @id";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int workerId = reader.GetInt32(0);
                            string workerName = reader.GetString(1);
                            int workerAge = reader.GetInt32(2);
                            string companyName = reader.GetString(3);

                            Console.WriteLine($"ID: {workerId}, Name: {workerName}, Age: {workerAge}, Company: {companyName}");
                        }
                    }
                }
            }
        }



        public void CreateWorker(Workers worker)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "INSERT INTO Workers VALUES(@Name,@Age,@Salary,@Company_id)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", worker.Name);
            sqlCommand.Parameters.AddWithValue("@Age", worker.Age);
            sqlCommand.Parameters.AddWithValue("@Salary", worker.Salary);
            sqlCommand.Parameters.AddWithValue("@Company_id",worker.Company_id);
            sqlCommand.ExecuteNonQuery();

        }

        public void DeleteWorker(int id)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "DELETE FROM Workers WHERE id = @id";
            using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();
        }   

        public void EditWorker(int id)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("Choose what do you want change?");
            Console.WriteLine("1.Name");
            Console.WriteLine("2.Age");
            Console.WriteLine("3.Salary");
            string input = Console.ReadLine();

            string query = string.Empty;

            SqlCommand sql = new SqlCommand();
            sql.Connection = sqlConnection;
          

            switch (input)
            {
                case "1":

                    
                    Console.WriteLine("Set new name!");
                    string str=Console.ReadLine();


                    query = "UPDATE Workers SET Name = @value WHERE id = @id";


                    sql.Parameters.AddWithValue("@value", str);
                    
                    break;
                case "2":

                    Console.WriteLine("Set an Age!");
                    int age= int.Parse(Console.ReadLine());

                    query = "UPDATE Workers SET Age=@value WHERE id=@id";

                    sql.Parameters.AddWithValue("@value", age);


                    break;
                case "3":
                    Console.WriteLine("Set an Salary!");
                    float x= float.Parse(Console.ReadLine());
                    query = "UPDATE Workers SET Salary=@value WHERE id=@id";


                    sql.Parameters.AddWithValue("@value", x);
                    break;

            }

            sql.CommandText = query;
            sql.Parameters.AddWithValue("@id", id);
            sql.ExecuteNonQuery();
        }


    }
}