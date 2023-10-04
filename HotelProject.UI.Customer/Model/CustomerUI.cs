using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.UI.Customer.Model
{
    public class CustomerUI
    {
        public CustomerUI(int id, string name, string email, string phone, string address, int nrOfMembers)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            NrOfMembers = nrOfMembers;
        }

        public int id {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public int NrOfMembers { get; set; }
    }
}
