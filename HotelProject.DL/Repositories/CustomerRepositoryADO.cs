using HotelProject.BL.Interfaces;
using HotelProject.BL.Model;
using HotelProject.DL.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DL.Repositories
{
    public class CustomerRepositoryADO : ICustomerRepository
    {
        private string connectionString;

        public CustomerRepositoryADO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Customer> GetCustomers(string filter)
        {
            try
            {
                Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
                string sql;
                if (string.IsNullOrEmpty(filter))
                {
                    sql = "select t1.id,t1.email,t1.name customername,t1.address,t1.phone,t2.name membername,t2.birthday\r\nfrom customer t1 \r\nleft join (select * from member where status=1) t2 on t1.id=t2.customerId\r\nwhere t1.status=1";
                }
                else
                {
                    sql = "select t1.id,t1.email,t1.name customername,t1.address,t1.phone,t2.name membername,t2.birthday\r\nfrom customer t1 \r\nleft join (select * from member where status=1) t2 on t1.id=t2.customerId\r\nwhere t1.status=1 and (t1.id like @filter or t1.name like @filter or t1.email like @filter)";
                }
                using(SqlConnection conn = new SqlConnection(connectionString)) 
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@filter", $"%{filter}%");
                    SqlDataReader reader=cmd.ExecuteReader();
                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            int id= Convert.ToInt32(reader["ID"]);
                            if (!customers.ContainsKey(id)) //member toevoegen
                            {
                               customers.Add(id, new Customer((string)reader["customername"], (int)reader["id"], new ContactInfo((string)reader["email"], (string)reader["phone"], new Address((string)reader["address"]))));                              
                            }
                            if (!reader.IsDBNull(reader.GetOrdinal("membername")))
                            {
                                customers[id].AddMember(new Member((string)reader["membername"], DateOnly.FromDateTime((DateTime)reader["birthday"])));
                            }                            
                        }
                    return customers.Values.ToList();
                }
            }
            catch(Exception ex)
            {
                throw new CustomerRepositoryException("GetCustomer",ex);
            }
        }
    }
}
