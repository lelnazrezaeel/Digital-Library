using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace Project
{
    /// <summary>
    /// Interaction logic for UserInformations.xaml
    /// </summary>
    public partial class UserInformations : Window
    {
        public ObservableCollection<Book> books { get; set; }
        public UserInformations(User user)
        {
            InitializeComponent();
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.Phonenumber;
            txtRegistration.Text = user.SignupDate.ToString();
            txtSubscription.Text = user.SubscriptionDate.ToString();
            txtRemainingDays.Text = (user.SubscriptionDate - DateTime.Now).Days.ToString();
            var uri = new Uri(user.ImageName.ToString());
            ImageFile.Source = new BitmapImage(uri);
            books = new ObservableCollection<Book>();
            DataTable bookTable = DataBaseManager.MyBooks(txtName.Text);
            for (int i = 0; i < bookTable.Rows.Count; i++)
            {
                books.Add(new Book() { Name = bookTable.Rows[i][0].ToString(), Author = bookTable.Rows[i][1].ToString(), PrintNumber = bookTable.Rows[i][3].ToString(), Genre = bookTable.Rows[i][2].ToString(), Count = int.Parse(bookTable.Rows[i][4].ToString()) , EndDate = bookTable.Rows[i][6].ToString()});
            }
            DataContext = this;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
