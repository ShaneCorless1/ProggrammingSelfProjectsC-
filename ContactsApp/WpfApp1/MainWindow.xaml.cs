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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            ReadDatabase();
        }

        private void AddNewCotnact_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContactWindow = new NewContactWindow();
            newContactWindow.ShowDialog();
            ReadDatabase();
        }

        public void ReadDatabase()
        {
         
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                contacts = connection.Table<Contact>().OrderBy(c =>c.Name).ToList();

             



            }
            if (contacts != null)

            {

                
                contactListView.ItemsSource = contacts;

            }
        }

        private void TextBoxChanged_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = sender as TextBox;

            var filteredList = contacts.Where(c => c.Name.ToLower().Contains(searchTextBox.Text)).ToList();

            //SQL Queries
            var filteredList2 = from c2 in contacts
                                where c2.Name.ToLower().Contains(searchTextBox.Text.ToLower())
                                orderby c2.EmailAddress
                                select c2;

            //Contact list will equla in the filetered
            contactListView.ItemsSource = filteredList2.ToList();

        }

        private void ContactListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact selectedContact = (Contact)contactListView.SelectedItem;
            if (selectedContact!= null)
            {
                EditContact NewEditContact = new EditContact(selectedContact);
                NewEditContact.ShowDialog();
            }
        }
    }
}

