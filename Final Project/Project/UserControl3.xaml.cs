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
    /// Interaction logic for UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        int days;
        string CurrentUser;
        public UserControl3(string name)
        {
            InitializeComponent();
            CurrentUser = name;
            updateDays();
        }
        void updateDays()
        {
            days = DataBaseManager.CountRemainingDays(CurrentUser);
            if (days >= 0)
            {
                txtDays.Text = days.ToString() + " Days";
            }
            else
            {
                txtDays.Text = (days * -1).ToString() + " Days";
                txtDays.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
        private void SubBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataBaseManager.MemberBalance(CurrentUser) >= 30000)
            {
                DataBaseManager.UpdateSubscriptionWithDays(CurrentUser, 30);
                DataBaseManager.UpdateMemberBalance(CurrentUser, 30000);
                updateDays();
            }
            else
            {
                MessageBox.Show(String.Format("You Need {0} T More For Subscription!", 30000 - DataBaseManager.MemberBalance(CurrentUser)), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
