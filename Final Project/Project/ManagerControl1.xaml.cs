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
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    /// <summary>
    /// Interaction logic for ManagerControl1.xaml
    /// </summary>
    public partial class ManagerControl1 : System.Windows.Controls.UserControl
    {
        public ObservableCollection<Employee> emps { get; set; } 
        public ManagerControl1()
        {
            emps = new ObservableCollection<Employee>();
            InitializeComponent();
            DataTable employees = DataBaseManager.EmpList();

            for (int i = 0; i < employees.Rows.Count; i++)
            {
                emps.Add(new Employee() { Name = employees.Rows[i][1].ToString(), Phonenumber = employees.Rows[i][3].ToString(), Email = employees.Rows[i][2].ToString(), Password = employees.Rows[i][4].ToString(), Salary = int.Parse(employees.Rows[i][6].ToString()), ImageFileName = employees.Rows[i][5].ToString()});
            }
            DataContext = this ;
        }

        private void DepositOfSalaries_Click(object sender, RoutedEventArgs e)
        {
            if (DataBaseManager.AdminBalance() > DataBaseManager.Payment())
            {
                if(System.Windows.MessageBox.Show("Vertify the password", "Payment", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                {
                    DataBaseManager.PayAllSalaries();
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Not enough balance");
            }
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.Show();
        }
        private void RemoveEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (lsDataBinding.SelectedIndex != -1)
            {
                Employee employee = new Employee();
                employee = emps[lsDataBinding.SelectedIndex];
                if (System.Windows.MessageBox.Show("Are you sure ?", "Remove an employee", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    DataBaseManager.RemoveEmployee(employee.Name);
                    emps.RemoveAt(lsDataBinding.SelectedIndex);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("The employee is not removed");
            }
        }
    }
}
