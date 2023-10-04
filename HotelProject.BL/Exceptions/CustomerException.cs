using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BL.Exceptions
{
    public class CustomerException : Exception
    {
        public CustomerException(string? message) : base(message)
        {
        }

        public CustomerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
