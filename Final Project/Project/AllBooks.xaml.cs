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
    /// Interaction logic for AllBooks.xaml
    /// </summary>
    public partial class AllBooks : UserControl
    {
        public ObservableCollection<Book> books { get; set; }
        public AllBooks()
        {
            books = new ObservableCollection<Book>();
            InitializeComponent();
            DataTable bookTable = DataBaseManager.BookList();

            for (int i = 0; i < bookTable.Rows.Count; i++)
            {
                books.Add(new Book() { Name = bookTable.Rows[i][1].ToString(), Author = bookTable.Rows[i][2].ToString(), PrintNumber = bookTable.Rows[i][3].ToString(), Genre = bookTable.Rows[i][4].ToString(), Count = int.Parse(bookTable.Rows[i][5].ToString()) });
            }
            DataContext = this;
        }
    }
}
