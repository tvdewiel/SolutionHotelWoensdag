using HotelProject.BL.Interfaces;
using HotelProject.DL.Repositories;
using System.Configuration;

namespace HotelProject.Util
{
    public static class RepositoryFactory
    {
        public static ICustomerRepository CustomerRepository { get { return new CustomerRepositoryADO(ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString); } }
    }
}