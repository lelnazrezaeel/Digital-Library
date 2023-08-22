using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Project
{
    /// <summary>
    ///     Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        string ImageFile = null;
        public SignUp()
        {
            InitializeComponent();
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

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void ChoosePhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
            if (open.ShowDialog() == true)
            {
                var uri = new Uri(System.IO.Path.GetFullPath(open.FileName));
                ProfileImg.Source = new BitmapImage(uri);
                ImageFile = uri.ToString() ;
            }
        }
        bool ValidateFields()
        {
            //Check required fields due to Regex

            //Check Name
            if (txtName.Text == "")
            {
                System.Windows.MessageBox.Show("Name is required! please provide a name.");
                return false;
            }
            else
            {
                if (txtName.Text.Length < 3 || txtName.Text.Length > 32)
                {
                    System.Windows.MessageBox.Show("Name length must be from 3 to 32! please provide a proper name.");
                    return false;
                }
            }
            //Check Email
            if (txtEmail.Text == "")
            {
                System.Windows.MessageBox.Show("E-mail is required! please provide an e-mail.");
                return false;
            }
            else
            {
                if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                {
                    System.Windows.MessageBox.Show("E-mail must be in correct format! please provide a proper e-mail.");
                    return false;
                }

            }
            //Check PhoneNumber
            if (txtPhoneNumber.Text == "")
            {
                System.Windows.MessageBox.Show("Phone number is required! please provide a phone number.");
                return false;
            }
            else
            {
                if (txtPhoneNumber.Text[0] != '9')
                {
                    System.Windows.MessageBox.Show("Phone number must begin with 9! please provide a proper phone number.");
                    return false;
                }
                if (txtPhoneNumber.Text.Length != 10)
                {
                    System.Windows.MessageBox.Show("Phone number should be 10 digits! please provide a proper phone number.");
                    return false;
                }
            }
            //Check Password
            if (txtPassword.Password != "")
            {
                if (txtPassword.Password.Length < 8)
                {
                    System.Windows.MessageBox.Show("Password must have at least 8 characters!please provide a proper password.");
                    return false;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Password phone number code is required! please provide a password.");
                return false;
            }
            if (ImageFile == null)
            {
                System.Windows.MessageBox.Show("Choose a profile Photo! please provide a picture.");
                return false;
            }
            //Fields Are Valid
            return true;
        }

        private void PlayClick(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                User NewMember = new User(txtName.Text, txtEmail.Text, txtPhoneNumber.Text , txtPassword.Password, 0, ImageFile, DateTime.Now);
                if (DataBaseManager.isUserExists(NewMember.Name, NewMember.Email, NewMember.Phonenumber)
                    && DataBaseManager.isEmployeeExists(NewMember.Name, NewMember.Email, NewMember.Phonenumber))
                {
                    PaymentPage payment = new PaymentPage(NewMember);
                    payment.Show();
                }
            }
        }
    }
}
