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
    public partial class AddBook : System.Web.UI.Page
    {
     

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string bookName= addBookName.Value;
            string bookIsbn=addBookIsbn.Value;
            string bookAuthor=addBookAuthor.Value;
            if (bookIsbn.Length==13)
            {
                Book book = new Book(bookName, bookIsbn, bookAuthor);
                string connectionString = @"Server=DESKTOP-EP20VEN\SQLEXPRESS2014;Database=BookStore;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "INSERT INTO AddBook(AddBookName,AddBookIsbn,AddBookAuthor)" +
                    "VALUES('" + book.AddBookName + "','"
                    + book.AddBookIsbn + "','"
                    + book.AddBookAuthor + "')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                int rowEffect = command.ExecuteNonQuery();
                connection.Close();
                ClearField();

                if (rowEffect > 0)
                {
                    messageLebel.InnerText = String.Empty;
                    messageLebel.InnerText = "Book Save Successfully";
                }
                else
                {
                    messageLebel.InnerText = "Failed to Save";
                }
            }
            else
            {
                messageLebel.InnerText = "Isbn Number Must be 13 Character";
            }




        }
        private void ClearField()
        {
            addBookName.Value = String.Empty;
            addBookIsbn.Value = String.Empty;
            addBookAuthor.Value = String.Empty;
           

        }

    }
}