using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BL.Exceptions
{
    public class CustomerManagerException : Exception
    {
        public CustomerManagerException(string? message) : base(message)
        {
        }

        public CustomerManagerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
