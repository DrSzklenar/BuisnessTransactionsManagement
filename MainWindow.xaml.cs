using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Business;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace BuisnessTransactionsManagement
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SearchPage s1 = new SearchPage();
        public NewItemPage n1 = new NewItemPage();
        public ModifyPage m1 = new ModifyPage();
        public Home home = new Home();

        cnBusiness cnBusiness = new cnBusiness();
        
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = home;
            InitializeDb();
        }

        private void InitializeDb()
        {
            cnBusiness.Database.EnsureCreated();
            if (cnBusiness.Customers != null)
            {
                if (!cnBusiness.Customers.Any())
                {
                    SeedDb();
                }
                //else
                //	ShowData();
            }
        }

        private void SeedDb()
        {
            //var c1 = new City { Zip = 6534, Name = "Big City" };
            //var c2 = new City { Zip = 6548, Name = "Small City" };
            //var p1 = new Person { Name = "John Smith", City = c1, Address = "10 New Street" };
            //var p2 = new Person { Name = "Jane Smith", City = c2, Address = "25 Small Avenue" };
            //c1.People.Add(p1); c2.People.Add(p2);
            //var n1 = new Number { NumberString = "+99-99-9999999" };
            //var n2 = new Number { NumberString = "+36-76-988999" };
            //var n3 = new Number { NumberString = "+40-84-91999999" };
            //p1.Numbers.Add(n1); p1.Numbers.Add(n3);
            //p2.Numbers.Add(n2); p2.Numbers.Add(n3);
            //n1.People.Add(p1); n2.People.Add(p2);
            //n3.People.Add(p1); n3.People.Add(p2);
            //cnPhoneBook.People.AddRange([p1, p2]);
            //cnPhoneBook.Numbers.AddRange([n1, n2, n3]);
            //cnPhoneBook.Cities.AddRange([c1, c2]);
            //cnPhoneBook.SaveChanges();
        }



        private void miSearchClick(object sender, RoutedEventArgs e)
        {
            Main.Content = s1;
            
        }

        private void miNewClick(object sender, RoutedEventArgs e)
        {
            Main.Content = n1;
        }

        private void miModifyPageClick(object sender, RoutedEventArgs e)
        {
            Main.Content = m1;
        }

        private void miHomeClick(object sender, RoutedEventArgs e)
        {
            Main.Content = home;
        }
    }
}