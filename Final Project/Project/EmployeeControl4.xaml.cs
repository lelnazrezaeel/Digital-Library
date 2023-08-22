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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for EmployeeControl4.xaml
    /// </summary>
    public partial class EmployeeControl4 : System.Windows.Controls.UserControl
    {
        public string ImageFile = null;
        Employee emp;
        public EmployeeControl4(Employee employee)
        {
            InitializeComponent();
            txtName.Text = employee.Name;
            txtEmail.Text = employee.Email;
            txtPhoneNumber.Text = employee.Phonenumber;
            this.emp = employee;
            try
            {
                var uri = new Uri(employee.ImageFileName.ToString());
                ProfileImg.Source = new BitmapImage(uri);
            }
            catch
            {
            }
        }
        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Employee employee = new Employee(txtName.Text, txtPhoneNumber.Text , txtEmail.Text , txtPassword.Password , 0 , ImageFile);
            if (ValidateFields() && txtPassword.Password == emp.Password)
            {
                DataBaseManager.updateEmployee(employee);
                System.Windows.MessageBox.Show("Done !");
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
        private void ChoosePhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageFile = dlg.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImageFile);
                bitmap.EndInit();
                ProfileImg.Source = bitmap;
            }
        }
    }
}
