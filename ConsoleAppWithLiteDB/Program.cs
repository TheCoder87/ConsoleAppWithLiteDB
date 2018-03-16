using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithLiteDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess.Create();

            var customers = DataAccess.Read();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.IsActive);
            }
          


            Console.WriteLine("Press any ket to exit...");
            Console.ReadKey();
        }
    }
}
