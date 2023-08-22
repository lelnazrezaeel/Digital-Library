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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public string name;
        DataTable bookTable;
        public ObservableCollection<Book> books { get; set; }
        public UserControl1(string name)
        {
            InitializeComponent();
            this.name = name;
            books = new ObservableCollection<Book>();
            bookTable = DataBaseManager.BookList();
            for (int i = 0; i < bookTable.Rows.Count; i++)
            {
                books.Add(new Book() { Name = bookTable.Rows[i][1].ToString(), Author = bookTable.Rows[i][2].ToString(), PrintNumber = bookTable.Rows[i][3].ToString(), Genre = bookTable.Rows[i][4].ToString(), Count = int.Parse(bookTable.Rows[i][5].ToString()) });
            }
            DataContext = this;
        }
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            books.Clear();
            if (BookName.IsChecked == true)
            {
                for (int i = 0; i <bookTable.Rows.Count; i++)
                {
                    if (bookTable.Rows[i][1].ToString().Contains(txtSearch.Text))
                    {
                        books.Add(new Book() { Name = bookTable.Rows[i][1].ToString(), Author = bookTable.Rows[i][2].ToString(), PrintNumber = bookTable.Rows[i][3].ToString(), Genre = bookTable.Rows[i][4].ToString(), Count = int.Parse(bookTable.Rows[i][5].ToString()) });
                    }
                }
            }
            else if (AuthorName.IsChecked == true)
            {
                for (int i = 0; i < bookTable.Rows.Count; i++)
                {
                    if (bookTable.Rows[i][2].ToString().Contains(txtSearch.Text))
                    {
                        books.Add(new Book() { Name = bookTable.Rows[i][1].ToString(), Author = bookTable.Rows[i][2].ToString(), PrintNumber = bookTable.Rows[i][3].ToString(), Genre = bookTable.Rows[i][4].ToString(), Count = int.Parse(bookTable.Rows[i][5].ToString()) });
                    }
                }
            }
        }

        private void BorrowBtn_Click(object sender, RoutedEventArgs e)
        {
            if (txtBorrow.Text != "")
            {
                DataBaseManager.BorrowBook(DataBaseManager.GetBookId(txtBorrow.Text), DataBaseManager.GetMemberId(name));
            }
            else
            {
                MessageBox.Show("The borrow box is empty");
            }
        }
    }
}
