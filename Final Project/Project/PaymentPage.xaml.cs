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

namespace Project
{
    /// <summary>
    /// Interaction logic for PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Window
    {
        User user;
        int amount = -1;
        string s;
        public PaymentPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public PaymentPage()
        {
            InitializeComponent();
        }

        public PaymentPage(int a , string s = null)
        {
            InitializeComponent();
            this.amount = a;
            this.s = s;
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

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            if (isCardValid())
            {
                if (amount == -1)
                {
                    if (DataBaseManager.isUserExists(user.Name, user.Email, user.Phonenumber))
                    {
                        DataBaseManager.AddUser(user);
                    }
                }
                else
                {
                    if (s == null)
                    {
                        DataBaseManager.AdminBalance(amount);
                        MessageBox.Show(amount.ToString());
                    }
                    else
                    {
                        DataBaseManager.UpdateMemberBalance(s, (-1 * amount));
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid card informations");
            }
        }
        private bool isCardValid()
        {
            DateTime today = DateTime.Now;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text) || string.IsNullOrEmpty(num3.Text) || string.IsNullOrEmpty(num4.Text))
            {
                MessageBox.Show("Enter card number !");
                return false;
            }
            else
            {
                if (num1.Text.Length != 4 || num2.Text.Length != 4 || num3.Text.Length != 4 || num4.Text.Length != 4)
                {
                    MessageBox.Show("card number should be 16 digits !");
                    return false;
                }
                else
                {
                    if (!IsDigitsOnly(num1.Text) || !IsDigitsOnly(num2.Text) || !IsDigitsOnly(num3.Text) || !IsDigitsOnly(num4.Text))
                    {
                        MessageBox.Show("card number should be all digits !");
                        return false;
                    }
                    else
                    {
                        int sum = 0;
                        int[] number = { int.Parse(num1.Text), int.Parse(num2.Text), int.Parse(num3.Text), int.Parse(num4.Text) };
                        foreach (var item in number)
                        {
                            var temp = item;
                            sum += temp % 10;
                            temp /= 10;
                            sum += IsGraterThan10(2 * (temp % 10));
                            temp /= 10;
                            sum += temp % 10;
                            temp /= 10;
                            sum += IsGraterThan10(2 * (temp % 10));
                        }



                        if (sum % 10 != 0)
                        {
                            MessageBox.Show("card number is not valid !");
                            return false;
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(txtCVV2.Text))
            {
                MessageBox.Show("Enter CVV2 !");
                return false;
            }
            else
            {
                if (txtCVV2.Text.Length != 3 && txtCVV2.Text.Length != 4)
                {
                    MessageBox.Show("CVV2 should be exactly 3 or 4 digits !");
                    return false;
                }
                else
                {
                    if (!IsDigitsOnly(txtCVV2.Text))
                    {
                        MessageBox.Show("CVV2 should be all digits !");
                        return false;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("Enter year !");
                return false;
            }
            else
            {
                if (!IsDigitsOnly(txtYear.Text))
                {
                    MessageBox.Show("year should be all digits !");
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtMonth.Text))
            {
                MessageBox.Show("Enter month !");
                return false;
            }
            {
                if (!IsDigitsOnly(txtMonth.Text))
                {
                    MessageBox.Show("month should be all digits !");
                    return false;
                }
            }
            int txtyear = 1400 + int.Parse(txtYear.Text);
            int txtmonth = int.Parse(txtMonth.Text);
            int yearDiff = txtyear - pc.GetYear(today);
            if (yearDiff > 5 || yearDiff < 0)
            {
                MessageBox.Show("Expire year is not valid !");
                return false;
            }
            if (txtmonth < 1 || txtmonth > 12)
            {
                MessageBox.Show("Expire month is not valid !");
                return false;
            }
            if (yearDiff == 0)
                if (txtmonth - pc.GetMonth(today) < 3)
                    return false;
            if (yearDiff == 1)
                if (txtmonth + 12 - pc.GetMonth(today) < 3)
                    return false;
            return true;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        int IsGraterThan10(int num)
        {
            if (num > 9)
            {
                int temp = num % 10;
                num /= 10;
                temp += num;
                return temp;
            }
            return num;
        }
    }
}
