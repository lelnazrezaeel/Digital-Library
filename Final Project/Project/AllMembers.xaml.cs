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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for AllMembers.xaml
    /// </summary>
    public partial class AllMembers : UserControl
    {
        int selector;
        DataTable userTable;
        public ObservableCollection<User> users { get; set; }
        public AllMembers(int a)
        {
            InitializeComponent();
            users = new ObservableCollection<User>();
            DataContext = this;
            this.selector = a;
            switch (selector)
            {
                case 0:
                    users.Clear();
                    userTable = DataBaseManager.MemberList();
                    for (int i = 0; i < userTable.Rows.Count; i++)
                    {
                        users.Add(new User() { Name = userTable.Rows[i][1].ToString(), Email = userTable.Rows[i][2].ToString(), Phonenumber = userTable.Rows[i][3].ToString(), Password = userTable.Rows[i][4].ToString(), SignupDate = DateTime.Parse(userTable.Rows[i][5].ToString()), SubscriptionDate = DateTime.Parse(userTable.Rows[i][6].ToString()), ImageName = userTable.Rows[i][7].ToString(), Balance = 0 });
                    }          
                    break;
                case 1:
                    users.Clear();
                    List<User> lateUsers= DataBaseManager.GetLateReturnnMembers();
                    foreach (var user in lateUsers)
                    {
                        users.Add(user);
                    }
                    break;
                case 2:
                    users.Clear();
                    List<User> lateUsersSub = DataBaseManager.GetLateSubscriptionMembers();
                    foreach (var user in lateUsersSub)
                    {
                        users.Add(user);
                    }
                    break;
            }
                
            
        }
    }
}
