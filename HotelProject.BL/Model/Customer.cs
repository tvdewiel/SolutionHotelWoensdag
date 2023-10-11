using HotelProject.BL.Exceptions;

namespace HotelProject.BL.Model
{
    public class Customer
    {
        private string _name;
        public string Name { get { return _name; } set { if (string.IsNullOrWhiteSpace(value)) throw new CustomerException("name is empty"); _name = value; } }
        private int _id;
        public int Id { get { return _id; } set { if (value <= 0) throw new CustomerException("invalid id"); _id = value; } }
        private ContactInfo _contactInfo;
        public ContactInfo ContactInfo { get { return _contactInfo; } set { if (value == null) throw new CustomerException("contactinfo null"); _contactInfo = value; } }
        private List<Member> _members=new List<Member>();

        public Customer(string name, int id, ContactInfo contactInfo)
        {
            _name = name;
            _id = id;
            _contactInfo = contactInfo;
        }

        public Customer(string name, ContactInfo contactInfo)
        {
            _name = name;
            _contactInfo = contactInfo;
        }

        public IReadOnlyList<Member> GetMembers()
        {
            return _members.AsReadOnly();
        }
        public void AddMember(Member member) 
        {
            if (!_members.Contains(member))
                _members.Add(member);
            else
                throw new CustomerException("addmember");
        }
        public void RemoveMember(Member member)
        {
            if (_members.Contains(member))
                _members.Remove(member);
            else
                throw new CustomerException("removemember");
        }
    }
}