using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Book
    {
        string name;
        string printNumber;
        string author;
        int count;
        string genre;
        int id;
        string endDate;
        public string Name { get => name; set => name = value; }
        public string PrintNumber { get => printNumber; set => printNumber = value; }
        public string Author { get => author; set => author = value; }
        public int Count { get => count; set => count = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Id { get => id; set => id = value; }
        public string EndDate { get => endDate; set => endDate = value; }

        public Book()
        {

        }
        public Book(string Name, string PrintNumber, string Author, string Gener, int Count)
        {
            this.Name = Name;
            this.PrintNumber = PrintNumber;
            this.Author = Author;
            this.Genre = Gener;
            this.Count = Count;
        }
    }
}
