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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public EmployeePanel employee;
        public Manager manager;
        public UserPanel user;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (userBox.Text == "admin" && passwordBox.Password == "AdminLib123")
            {
                manager = new Manager();
                manager.Show();
            }
            else if (DataBaseManager.isEmployeeExistsSignIn(userBox.Text,passwordBox.Password))
            {
                employee = new EmployeePanel(userBox.Text);
                employee.Show();
            }
            else if (DataBaseManager.isUserExistsSignIn(userBox.Text, passwordBox.Password))
            {
                user = new UserPanel(userBox.Text);
                user.Show();
            }
            else
            {
                MessageBox.Show("Please sign up first");
            }
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

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            Close();
        }
    }
}
