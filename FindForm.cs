using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using ComponentFactory.Krypton.Toolkit;
using System.IO;

namespace CodeX
{
    public partial class FindForm : KryptonForm
    {
        private readonly DataClasses1DataContext _dataContext = new DataClasses1DataContext();

        public FindForm()
        {
            InitializeComponent();
            BooksGridview.DataSource = _dataContext.Books;
        }

        private async Task<Image> GetBookCover(string isbn)
        {
            string url = $"https://covers.openlibrary.org/b/isbn/{isbn}-L.jpg";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var imageBytes = await client.GetByteArrayAsync(url);
                    return Image.FromStream(new MemoryStream(imageBytes));
                }
                catch
                {
                    MessageBox.Show("Can not Show The Cover");
                    return null;
                }
            }
        }

        private async void FindBT_Click(object sender, EventArgs e)
        {
            var conditions = GetSearchConditions();
            var results = SearchBooks(conditions);

            BooksGridview.DataSource = results;

            if (!results.Any())
            {
                MessageBox.Show("There are no books could be find");
                return;
            }

            var firstBookIsbn = results.First().ISBN;

            if (!string.IsNullOrWhiteSpace(firstBookIsbn))
            {
                var coverImage = await GetBookCover(firstBookIsbn);
                if (coverImage != null)
                {
                    CoverPicBox.Image = coverImage;
                }
            }
        }

        private List<Expression<Func<Book, bool>>> GetSearchConditions()
        {
            var conditions = new List<Expression<Func<Book, bool>>>();

            if (!string.IsNullOrWhiteSpace(AuthorTB.Text))
                conditions.Add(b => b.Author.Contains(AuthorTB.Text.Trim()));

            if (!string.IsNullOrWhiteSpace(TitleTB.Text))
                conditions.Add(b => b.Title.Contains(TitleTB.Text.Trim()));

            if (!string.IsNullOrWhiteSpace(GenreTB.Text))
                conditions.Add(b => b.Genre.Contains(GenreTB.Text.Trim()));

            if (!string.IsNullOrWhiteSpace(ISBN_TB.Text))
                conditions.Add(b => b.ISBN == ISBN_TB.Text.Trim());

            if (int.TryParse(YearTB.Text, out int year))
                conditions.Add(b => b.Year == year);

            if (!string.IsNullOrWhiteSpace(PublisherTB.Text))
                conditions.Add(b => b.Publisher.Contains(PublisherTB.Text.Trim()));

            return conditions;
        }

        private List<Book> SearchBooks(List<Expression<Func<Book, bool>>> conditions)
        {
            var query = _dataContext.Books.AsQueryable();

            foreach (var condition in conditions)
            {
                query = query.Where(condition);
            }

            return query.ToList();
        }
    }
}
