﻿using HotelProject.BL.Model;
using HotelProject.UI.CustomerWPF.Model;
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
using System.Windows.Shapes;

namespace HotelProject.UI.CustomerWPF
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        public CustomerUI customerUI;
        public CustomerWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer(NameTextBox.Text,new ContactInfo(EmailTextBox.Text,PhoneTextBox.Text,new Address(CityTextBox.Text,ZipTextBox.Text,HouseNumberTextBox.Text,StreetTextBox.Text)));
            //write customer
            c.Id = 100;
            //TODO id from DB
            customerUI = new CustomerUI(c.Id, c.Name, c.ContactInfo.Email, c.ContactInfo.Phone, c.ContactInfo.Address.ToString(), c.GetMembers().Count);
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}