using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace Project
{
    public class DataBaseManager
    {
        static SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=F:\Sara & Elnaz Project Final\Sara & Elnaz Project Final\Project\DataBase\ProjectDataBase.mdf;Integrated Security = True; Connect Timeout = 30 ; MultipleActiveResultSets=True");
        static string command;
        public static bool isUserExists(string name, string email, string phoneNumber)
        {
            DataTable data = MemberList();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == name || data.Rows[i][2].ToString() == email || data.Rows[i][3].ToString() == phoneNumber)
                {
                    System.Windows.MessageBox.Show("Same info exists !!");
                    return false;
                }
            }
            return true;
        }
        public static bool isEmployeeExists(string name, string email, string phoneNumber)
        {
            DataTable data = EmpList();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == name || data.Rows[i][2].ToString() == email || data.Rows[i][3].ToString() == phoneNumber)
                {
                    System.Windows.MessageBox.Show("Same info exists !!");
                    return false;
                }
            }
            return true;
        }
        public static bool isUserExistsSignIn(string name, string password)
        {
            DataTable data = MemberList();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == name && data.Rows[i][4].ToString() == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isEmployeeExistsSignIn(string name, string password)
        {
            DataTable data = EmpList();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == name && data.Rows[i][4].ToString() == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static DataTable EmpList()
        {
            con.Open();
            command = "SELECT * from tbl_Employees;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public static void AddEmployee(Employee employee)
        {
            con.Open();
            command = String.Format("INSERT INTO tbl_Employees (EmployeeName, Email , PhoneNumber, Password, Image , Salary , Balance) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", employee.Name,employee.Email,employee.Phonenumber,employee.Password,employee.ImageFileName,employee.Salary,0);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(1000);
            con.Close();
        }

        public static void RemoveEmployee(string name)
        {
            con.Open();
            command = String.Format("DELETE FROM tbl_Employees WHERE EmployeeName = '{0}';" , name.Trim());
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(1000);
            con.Close();

        }

        public static DataTable MemberList()
        {
            command = "SELECT * from tbl_Users;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public static void AddUser(User MemberToAdd)
        {
            con.Open();
            command = String.Format("INSERT INTO tbl_Users (MemberName, Email, PhoneNumber, Password, SignUpDate, SubscriptionDate, Image , Balance) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}' , '{7}');", MemberToAdd.Name, MemberToAdd.Email, MemberToAdd.Phonenumber, MemberToAdd.Password, MemberToAdd.SignupDate.ToString(), MemberToAdd.SubscriptionDate.ToString(), MemberToAdd.ImageName , 0);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(1000);
            con.Close();
        }
        public static void AddBook(Book BookToAdd)
        {
            con.Open();
            command = String.Format("INSERT INTO tbl_Books (BookName, Writer, Genre, PrintNumber, Count) VALUES ('{0}','{1}','{2}','{3}','{4}');", BookToAdd.Name, BookToAdd.Author, BookToAdd.Genre, BookToAdd.PrintNumber, BookToAdd.Count);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(1000);
            con.Close();
        }
        public static DataTable BookList()
        {
            con.Open();
            command = "SELECT * from tbl_Books;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public static bool isBookExists(Book BookToAdd)
        {
            DataTable data = BookList();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == BookToAdd.Name || data.Rows[i][4].ToString() == BookToAdd.PrintNumber)
                {
                    return false;
                }
            }
            return true;
        }
        public static void countBook(Book book)
        {
            con.Open();
            command = String.Format("Update tbl_Books set count = count + 1 where BookName = '{0}';" , book.Name );
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(1000);
            con.Close();
        }
        //Deposit
        public static int Payment()
        {
            con.Open();
            command = "SELECT SUM(tbl_Employees.Salary) As Total FROM tbl_Employees;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return int.Parse(table.Rows[0][0].ToString());
        }
        public static void PayAllSalaries()
        {
            DataTable data = EmpList();
            con.Open();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                command = String.Format("UPDATE tbl_Employees SET Balance = Balance + Salary  WHERE Id = '{0}';", data.Rows[i][0]);
                SqlCommand com = new SqlCommand(command, con);
                com.BeginExecuteNonQuery();
            }
            Thread.Sleep(1000);
            UpdateBalance();
            Thread.Sleep(1000);
            con.Close();
        }
        public static int AdminBalance()
        {
            con.Open();
            command = "SELECT tbl_Admin.Balance Total FROM tbl_Admin;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return int.Parse(table.Rows[0][0].ToString());
        }
        public static void UpdateBalance()
        {
            command = "SELECT SUM(tbl_Employees.Salary) As Total FROM tbl_Employees;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int newBalance =  int.Parse(table.Rows[0][0].ToString());
            command = String.Format("UPDATE tbl_Admin SET Balance = Balance - {0};",newBalance);
            SqlCommand com = new SqlCommand(command, con);
            Thread.Sleep(1000);
            com.BeginExecuteNonQuery();
        }
        public static void AdminBalance(int amount)
        {
            con.Open();
            command = String.Format("UPDATE tbl_Admin SET Balance = Balance + {0};", amount);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(1000);
            con.Close();
        }
        public static DataTable BorrowedBooks()
        {
            con.Open();
            command = "SELECT tbl_Books.BookName , tbl_Books.Writer , tbl_Books.PrintNumber , tbl_Books.Genre , tbl_Books.Count from tbl_Library inner join tbl_Books on tbl_Library.BookId = tbl_Books.Id;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public static DataTable AvailableBooks()
        {
            con.Open();
            command = "SELECT tbl_Books.BookName , tbl_Books.Writer , tbl_Books.PrintNumber , tbl_Books.Genre , tbl_Books.Count from tbl_Books where Count>0;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public static List<User> GetLateReturnnMembers()
        {
            List<User> UserList = new List<User>();
            con.Open();
            command = "SELECT tbl_Users.Id, tbl_Users.MemberName,tbl_Users.Email,tbl_Users.PhoneNumber, tbl_Users.Password,tbl_Users.SignupDate, tbl_Library.EndDate , tbl_Users.Image ,tbl_Users.Balance FROM tbl_Library INNER JOIN tbl_Books ON tbl_Library.BookId = tbl_Books.Id INNER JOIN tbl_Users ON tbl_Library.UserId = tbl_Users.Id;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (isLate(DateTime.Parse(table.Rows[i][6].ToString())))
                {
                    UserList.Add(new User(table.Rows[i][1].ToString(), table.Rows[i][2].ToString(),table.Rows[i][3].ToString(), table.Rows[i][4].ToString(), int.Parse(table.Rows[i][8].ToString()) , table.Rows[i][7].ToString() , DateTime.Parse(table.Rows[i][5].ToString())));
                }
            }
            con.Close();
            return UserList;
        }
        public static bool isLate(DateTime End)
        {
            if (DateTime.Compare(End, DateTime.Now) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<User> GetLateSubscriptionMembers()
        {
            List<User> userList = new List<User>();
            con.Open();
            command = "SELECT * from tbl_Users";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (isLate(DateTime.Parse(table.Rows[i][6].ToString())))
                {
                    userList.Add(new User(table.Rows[i][1].ToString(), table.Rows[i][2].ToString(), table.Rows[i][3].ToString(), table.Rows[i][4].ToString(),0,table.Rows[i][7].ToString(), DateTime.Parse(table.Rows[i][5].ToString())));
                }
            }
            con.Close();
            return userList;
        }
        public static User SearchInfo(string name)
        {
            con.Open();
            command = String.Format("SELECT * from tbl_Users where MemberName = '{0}';",name);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            if (table.Rows.Count!=0)
            {
                return new User(table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), table.Rows[0][3].ToString(), table.Rows[0][4].ToString(), 0, table.Rows[0][7].ToString(), DateTime.Parse(table.Rows[0][5].ToString()));
            }
            else
            {
                return null;
            }
        }
        public static Employee GiveEmployee(string name)
        {
            con.Open();
            command = String.Format("SELECT * from tbl_Employees where EmployeeName = '{0}';", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return new Employee(table.Rows[0][1].ToString(), table.Rows[0][3].ToString(), table.Rows[0][2].ToString(), table.Rows[0][4].ToString(), int.Parse(table.Rows[0][6].ToString()), table.Rows[0][7].ToString());
        }
        public static DataTable MyBooks(string name)
        {
            int userId = GetMemberId(name);
            con.Open();
            command = string.Format("SELECT tbl_Books.BookName, tbl_Books.Writer, tbl_Books.Genre, tbl_Books.PrintNumber, tbl_Books.Count, tbl_Library.UserId, tbl_Library.EndDate FROM tbl_Library INNER JOIN tbl_Books ON tbl_Library.BookId = tbl_Books.Id WHERE UserId='{0}'", userId);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static int GetMemberId(string name)
        {
            con.Open();
            command = String.Format("SELECT * from tbl_Users WHERE MemberName='{0}'", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return int.Parse(table.Rows[0][0].ToString());
        }
        public static void updateEmployee(Employee emp)
        {
            con.Open();
            command = String.Format("UPDATE tbl_Employees SET Email='{0}', PhoneNumber='{1}', Password='{2}',Image='{3}' WHERE EmployeeName = '{4}'", emp.Email, emp.Phonenumber , emp.Password, emp.ImageFileName, emp.Name);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(2000);
            con.Close();
        }
        public static int EmployeeBalance(string name)
        {
            command = String.Format("SELECT * from tbl_Employees WHERE EmployeeName='{0}'", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return int.Parse(table.Rows[0][7].ToString());
        }
        public static int CountBorrowedBooks(int Id)
        {
            command = String.Format("SELECT COUNT (Id) from tbl_Library WHERE UserId='{0}'", Id);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }
        public static int CountBook(int Id)
        {
            command = String.Format("SELECT * from tbl_Books WHERE Id='{0}'", Id);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return int.Parse(table.Rows[0][5].ToString());
        }
        public static bool IsAllowedToBorrow(int BookId, int UserId)
        {
            con.Open();
            int Count;
            if (CountBorrowedBooks(UserId) < 5)
            {
                if (CountBook(BookId) > 0)
                {

                    command = String.Format("SELECT COUNT (Id) from tbl_Library WHERE UserId='{0}' AND BookId='{1}'", UserId, BookId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    Count = int.Parse(table.Rows[0][0].ToString());
                    if (Count != 0)
                    {
                        con.Close();
                        return false;
                    }
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            con.Close();
            return false;
        }
        public static bool BorrowBook(int BookId, int UserId)
        {
            if (IsAllowedToBorrow(BookId, UserId))
            {
                InsertToLibraryManagment(BookId, UserId);
                CountUpdate(BookId);
                return true;
            }
            return false;
        }
        public static void CountUpdate(int BookId)
        {
            con.Open();
            command = String.Format("UPDATE tbl_Books SET Count = Count - 1 WHERE Id = '{0}'", BookId);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(2000);
            con.Close();
        }
        public static void InsertToLibraryManagment(int BookId, int UserId)
        {
            con.Open();
            command = String.Format("INSERT INTO tbl_Library (UserId , BookId, StartDate, EndDate) VALUES ('{0}','{1}','{2}','{3}');", UserId , BookId, DateTime.Now.ToString(), DateTime.Now.AddDays(7).ToString());
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(2000);
            con.Close();
        }
        public static int GetBookId(string name)
        {
            con.Open();
            command = String.Format("SELECT * from tbl_Books WHERE BookName='{0}'", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return int.Parse(table.Rows[0][0].ToString());
        }
        public static void ReturnBook(int BookId, int MemberId)
        {
            bool flag = true;
            con.Open();
            command = String.Format("SELECT UserId, EndDate, tbl_Users.Balance FROM tbl_Library INNER JOIN tbl_Users ON tbl_Library.UserID = tbl_Users.Id WHERE BookId = '{0}' AND UserId='{1}';", BookId, MemberId);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (isLate(DateTime.Parse(table.Rows[i][1].ToString())))
                {
                    if (int.Parse(table.Rows[i][2].ToString()) < 20000)
                    {
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                command = String.Format("DELETE FROM tbl_Library WHERE BookId = '{0}' AND UserId='{1}'", BookId, MemberId);
                SqlCommand com1 = new SqlCommand(command, con);
                com1.BeginExecuteNonQuery();

                command = String.Format("UPDATE tbl_Books SET Count = Count + 1 WHERE Id = '{0}'", BookId);
                SqlCommand com2 = new SqlCommand(command, con);
                com2.BeginExecuteNonQuery();
            }
            Thread.Sleep(2000);
            con.Close();
        }
        public static int CountRemainingDays(string name)
        {
            command = String.Format("SELECT * from tbl_Users WHERE MemberName = '{0}'", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DateTime subscriptiondate = DateTime.Parse(table.Rows[0][6].ToString());
            int numberofDays = (subscriptiondate - DateTime.Now).Days;
            con.Close();
            return numberofDays;
        }
        public static DateTime GetSubscriptionDate(string name)
        {
            command = String.Format("SELECT * from tbl_Users WHERE MemberName = '{0}'", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DateTime subscriptiondate = DateTime.Parse(table.Rows[0][6].ToString());
            return subscriptiondate;
        }
        public static void UpdateSubscriptionWithDays(string name, int days)
        {
            DateTime Subscriptiondate = GetSubscriptionDate(name);
            con.Open();
            command = String.Format("UPDATE tbl_Users SET SubscriptionDate = '{0}' WHERE MemberName = '{1}'", Subscriptiondate.AddDays(days).ToString(), name);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(2000);
            con.Close();
        }
        public static void UpdateMemberBalance(string name, int RemoveAmount)
        {
            con.Open();
            command = String.Format("UPDATE tbl_Users SET Balance = Balance - {0} WHERE MemberName = '{1}'", RemoveAmount, name);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(2000);
            con.Close();
        }
        public static int MemberBalance(string name)
        {
            command = String.Format("SELECT * from tbl_Users WHERE MemberName='{0}'", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return int.Parse(table.Rows[0][8].ToString());
        }
        public static void updateUser(User user)
        {
            con.Open();
            command = String.Format("UPDATE tbl_Users SET Email='{0}', PhoneNumber='{1}', Password='{2}',Image='{3}' WHERE MemberName = '{4}'", user.Email, user.Phonenumber, user.Password, user.ImageName , user.Name);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            Thread.Sleep(2000);
            con.Close();
        }
    }
}
