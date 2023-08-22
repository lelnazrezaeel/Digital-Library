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
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public string name;
        DataTable bookTable;
        public ObservableCollection<Book> books { get; set; }
        public UserControl2(string name)
        {
            InitializeComponent();
            this.name = name;
            books = new ObservableCollection<Book>();
            bookTable = DataBaseManager.MyBooks(name);
            for (int i = 0; i < bookTable.Rows.Count; i++)
            {
                books.Add(new Book() { Name = bookTable.Rows[i][0].ToString(), Author = bookTable.Rows[i][1].ToString(), PrintNumber = bookTable.Rows[i][2].ToString(), Genre = bookTable.Rows[i][3].ToString(), Count = int.Parse(bookTable.Rows[i][4].ToString()) });
            }
            foreach (var book in books)
            {
                MyBooks.Items.Add(book.Name);
            }          
            DataContext = this;
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MyBooks.Text != "")
            {
                DataBaseManager.ReturnBook(DataBaseManager.GetBookId(MyBooks.Text), DataBaseManager.GetMemberId(name));
            }
            else
            {
                MessageBox.Show("Empty comboBox");
            }
        }
    }
}
