using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BL.Exceptions
{
    public class ContactInfoException : Exception
    {
        public ContactInfoException(string? message) : base(message)
        {
        }

        public ContactInfoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
