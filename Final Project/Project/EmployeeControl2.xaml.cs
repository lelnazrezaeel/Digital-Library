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
    /// Interaction logic for EmployeeControl2.xaml
    /// </summary>
    public partial class EmployeeControl2 : UserControl
    {
        public EmployeeControl2()
        {
            InitializeComponent();
        }

        private void AllMembers_Click(object sender, RoutedEventArgs e)
        {
            GridPrincipal1.Children.Clear();
            GridPrincipal1.Children.Add(new AllMembers(0));
        }

        private void LateBook_Click(object sender, RoutedEventArgs e)
        {
            GridPrincipal1.Children.Clear();
            GridPrincipal1.Children.Add(new AllMembers(1));
        }

        private void LateSub_Click(object sender, RoutedEventArgs e)
        {
            GridPrincipal1.Children.Clear();
            GridPrincipal1.Children.Add(new AllMembers(2));
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            if (txtSearch.Text != "")
            {
                user = DataBaseManager.SearchInfo(txtSearch.Text);
                if (user != null)
                {
                    UserInformations informations = new UserInformations(user);
                    informations.Show();
                }
                else
                {
                    MessageBox.Show("There is no user with this name");
                }
            }
            else
            {
                MessageBox.Show("The name is empty");
            }
            
        }
    }
    
}
