using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CodeX
{
    public partial class EditBooks : KryptonForm
    {
        private DataClasses1DataContext dbo = new DataClasses1DataContext();
        private bool acctiveforedit = false;
        public EditBooks()
        {
            InitializeComponent();
        }

        private void ClearAllTextBox()
        {
            AuthorTB.Clear();
            TitleTB.Clear();
            ISBN_TB.Clear();
            GenreTB.Clear();
            YearTB.Clear();
            PublisherTB.Clear();
        }

        private static string GenerateCode()
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            char[] Code = new char[6];

            for (int i = 0; i < 6; i++)
            {
                Code[i] = characters[random.Next(characters.Length)];
            }

            return new string(Code);
        }
        private void EraseBT_Click(object sender, EventArgs e)
        {
            var res = dbo.Books.Where(x =>
                x.Author == AuthorTB.Text
                && x.Title == TitleTB.Text
                && x.ISBN == ISBN_TB.Text
                && x.Publisher == PublisherTB.Text
                && x.Genre == GenreTB.Text
                && x.Year == Convert.ToInt32(YearTB.Text)
            ).SingleOrDefault();

            if (res != null)
            {
                dbo.Books.DeleteOnSubmit(res); 
                dbo.SubmitChanges();
                ClearAllTextBox();
                return;
            }
            else
            {
                MessageBox.Show("No Books Have Found");
                return;
            }
        }

 
        private void ReadBT_Click(object sender, EventArgs e)
        {
           BooksGridview.DataSource = dbo.Books;
        }

        private void BooksGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                AuthorTB.Text = BooksGridview.CurrentRow.Cells["Author"].Value.ToString();
                TitleTB.Text = BooksGridview.CurrentRow.Cells["Title"].Value.ToString();
                ISBN_TB.Text = BooksGridview.CurrentRow.Cells["ISBN"].Value.ToString();
                GenreTB.Text = BooksGridview.CurrentRow.Cells["Genre"].Value.ToString();
                YearTB.Text = BooksGridview.CurrentRow.Cells["Year"].Value.ToString();
                PublisherTB.Text = BooksGridview.CurrentRow.Cells["Publisher"].Value.ToString();
            }
        }

        private void CreateTB_Click(object sender, EventArgs e)
        {
            Book obj = new Book
            {
                BookID = GenerateCode()
                , Title = TitleTB.Text
                , Author = AuthorTB.Text
                , Genre = GenreTB.Text
                , Publisher = PublisherTB.Text
                , ISBN = ISBN_TB.Text
                , Year = Convert.ToInt32(YearTB.Text)
            };

            try
            {
                dbo.Books.InsertOnSubmit(obj);
                dbo.SubmitChanges();
                ClearAllTextBox();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" Add Error " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            var res = dbo.Books.Where(x => x.Publisher == PublisherTB.Text).SingleOrDefault();
            if (res != null) { 

                if(!int.TryParse(YearTB.Text, out int year) ){
                    MessageBox.Show("Sign the right Number");
                    return;
                }
                res.Publisher = PublisherTB.Text;
                res.Author = AuthorTB.Text;
                res.Title   = TitleTB.Text;
                res.Year = year;
                dbo.SubmitChanges();
                return;
            }
            else
            {
                MessageBox.Show("There Are No Book to Edit,Please Sign right ISBN Number");
                return;
            }
        }
    }
}
