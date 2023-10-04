using HotelProject.BL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BL.Model
{
    public class Member
    {
        public Member(string name, DateOnly birthDay)
        {
            Name = name;
            BirthDay = birthDay;
        }
        private string _name;
        public string Name { get { return _name; } set { if (string.IsNullOrWhiteSpace(value)) throw new MemberException("name is empty"); _name = value; } }
        private DateOnly _birthDay;
        public DateOnly BirthDay { get { return _birthDay; } set { if (value>DateOnly.FromDateTime(DateTime.Now)) throw new MemberException("birthday invalid"); _birthDay = value; } }

        public override bool Equals(object? obj)
        {
            return obj is Member member &&
                   _name == member._name &&
                   _birthDay.Equals(member._birthDay);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_name, _birthDay);
        }
    }
}
