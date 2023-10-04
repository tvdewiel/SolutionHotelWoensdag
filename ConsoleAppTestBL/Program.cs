using HotelProject.BL.Model;

namespace ConsoleAppTestBL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address a = new Address("gent", "9000", "45", "kloosterstraat");
            Console.WriteLine("Hello, World!");
            ContactInfo ci = new ContactInfo("112@112", "kkkkl",null);
            //ci = new ContactInfo("eeer", "112");
            //ci = new ContactInfo(null, "11120");
            //ci = new ContactInfo("jj@", null);
        }
    }
}