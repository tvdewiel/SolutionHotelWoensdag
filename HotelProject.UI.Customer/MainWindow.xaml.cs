using HotelProject.BL.Managers;
using HotelProject.BL.Model;
using HotelProject.DL.Repositories;
using HotelProject.UI.Customer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelProject.UI.Customer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerManager customerManager;
        private string connectionString = "Data Source=NB21-6CDPYD3\\SQLEXPRESS;Initial Catalog=HotelWoensdag;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
            customerManager = new CustomerManager(new CustomerRepositoryADO(connectionString));            
            CustomerDataGrid.ItemsSource = new List<CustomerUI>(customerManager.GetCustomers(null).Select(x => new CustomerUI(x.Id, x.Name, x.ContactInfo.Email, x.ContactInfo.Phone, x.ContactInfo.Address.ToString(), x.GetMembers().Count)));
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemAddCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemUpdateCustomer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
