using EfCore_PostgreSql.Entities;

namespace EfCore_PostgreSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PostgresContext context = new PostgresContext();

            var musteriler = context.Customers.ToList();

            foreach ( var m in musteriler ) 
            {
                global::System.Console.WriteLine(m.CustomerId + " " + m.CompanyName + " " + m.Country);
            }

            Console.WriteLine("Hello, World!");
        }
    }
}