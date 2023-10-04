using HotelProject.BL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BL.Model
{
    public class ContactInfo
    {
        public ContactInfo(string email, string phone,Address address)
        {
            Email = email;
            Phone = phone;
            Address = address;
        }
        private string _email;
        public string Email { get { return _email; } set { if (string.IsNullOrEmpty(value) || !value.Contains('@')) throw new ContactInfoException("email is empty"); _email = value; } }
        private string _phone;
        public string Phone { get { return _phone; } set { if (string.IsNullOrWhiteSpace(value)) throw new ContactInfoException("phone is empty"); _phone = value; } }
        private Address _address;
        public Address Address { get { return _address; } set { if (value == null) throw new ContactInfoException("address is null"); _address = value; } }
    }
}
