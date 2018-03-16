using LiteDB;
using System;
using System.Collections.Generic;

namespace ConsoleAppWithLiteDB
{
    public class DataAccess
    {
        public static void Create()
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var customers = db.GetCollection<Customer>("Customers");

                var newCustomer = new Customer { Id = 1, Name = "TheCoder87", IsActive = true };

                customers.Insert(newCustomer);
            }
        }

        public static List<Customer> Read()
        {
            using (var db=new LiteDatabase(@"MyData.db"))
            {
                List<Customer> cust = new List<Customer>();
                var c= db.GetCollection<Customer>("Customers").FindAll();

                foreach (var item in c)
                {
                    cust.Add(item);
                }

                return cust;

            }
        }
    }
}