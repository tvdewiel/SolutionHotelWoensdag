using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DL.Exceptions
{
    public class CustomerRepositoryException : Exception
    {
        public CustomerRepositoryException(string? message) : base(message)
        {
        }

        public CustomerRepositoryException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
