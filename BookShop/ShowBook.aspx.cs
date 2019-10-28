using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop
{
    public partial class ShowBook : System.Web.UI.Page
    {
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Book> bookList = new List<Book>();

            string connectionString = @"Server=DESKTOP-EP20VEN\SQLEXPRESS2014;Database=BookStore;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from AddBook";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int bookId = (int)reader["AddBookId"];
                string bookName = reader["AddBookName"].ToString();
                string bookIsbn = reader["AddBookIsbn"].ToString();
                string bookAuthor = reader["AddBookAuthor"].ToString();

                Book book = new Book(bookName, bookIsbn, bookAuthor);
                book.AddBookId = bookId;
                bookList.Add(book);
            }
            reader.Close();
            connection.Close();
            showBookGrideView.DataSource = bookList;
            showBookGrideView.DataBind();


        }


        protected void searchButton_Click(object sender, EventArgs e)
        {
            List<Book> bookList = new List<Book>();
            string an = searchBookNameTextBox.Text;
            string connectionString = @"Server=DESKTOP-EP20VEN\SQLEXPRESS2014;Database=BookStore;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from AddBook Where AddBookName LIKE '%"+an+"%'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int bookId = (int)reader["AddBookId"];
                string bookName = reader["AddBookName"].ToString();
                string bookIsbn = reader["AddBookIsbn"].ToString();
                string bookAuthor = reader["AddBookAuthor"].ToString();

                Book book = new Book(bookName, bookIsbn, bookAuthor);
                book.AddBookId = bookId;
                bookList.Add(book);
            }
            reader.Close();
            connection.Close();
            showBookGrideView.DataSource = bookList;
            showBookGrideView.DataBind();

        }
    }
}