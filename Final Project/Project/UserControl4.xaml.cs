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
    /// Interaction logic for UserControl4.xaml
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        public string name;
        public UserControl4(string name)
        {
            InitializeComponent();
            this.name = name;
            txtWallet.Text = DataBaseManager.MemberBalance(name).ToString();
        }

        private void PatBtn_Click(object sender, RoutedEventArgs e)
        {
            if (txtAdd.Text != "")
            {
                PaymentPage paymentPage = new PaymentPage(int.Parse(txtAdd.Text),name);
                paymentPage.Show();
            }
        }
    }
}
