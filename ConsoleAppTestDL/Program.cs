using HotelProject.BL.Model;
using HotelProject.DL.Repositories;

namespace ConsoleAppTestDL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string connectionString = "Data Source=NB21-6CDPYD3\\SQLEXPRESS;Initial Catalog=HotelWoensdag;Integrated Security=True";
            CustomerRepositoryADO repo = new CustomerRepositoryADO(connectionString);
            //var x=repo.GetCustomers("jo");
            Customer customer = new Customer("Fred", new ContactInfo("fred@gmail","0123456789",new Address("gent","9000","12f","kerkstraat")));
            customer.AddMember(new Member("Freddy", DateOnly.FromDateTime(DateTime.Parse("1989-8-8"))));
            customer.AddMember(new Member("Gino", DateOnly.FromDateTime(DateTime.Parse("1987-5-8"))));
            repo.AddCustomer(customer);

        }
    }
}