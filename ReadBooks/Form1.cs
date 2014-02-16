using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadMoreBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Library m_library;

        private void Form1_Load(object sender, EventArgs e)
        {
            m_library = new Library();
            Book cookies = new Book();
            cookies.Title = "Cookies";
            cookies.Text = "Chocolate chip cookies are the most delicious cookies";
            cookies.PageLength = 8;
            Book fairyTales = new Book();
            fairyTales.Title = "Fairy Tales";
            fairyTales.Text = "Once upon a time there was a bear";
            fairyTales.PageLength = 8;
            m_library.CheckIn(cookies);
            m_library.CheckIn(fairyTales);
            listOfBooks.Items.Add(cookies.Title);
            listOfBooks.Items.Add(fairyTales.Title);
        }

        private void listOfBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = listOfBooks.SelectedItem.ToString();
            Book theBook = m_library.CheckOut(title);
            theBook.PageLength = (int)pageLength.Value;
            titleLabel.Text = theBook.Title;
            page.Text = theBook.GetPage((int)pageToDisplay.Value);
            m_library.CheckIn(theBook);
        }

        //private void showPage_Click(object sender, EventArgs e)
        //{
        //    Book fairyTales;
        //    fairyTales = new Book();

        //    fairyTales.Text = "Once upon a time there was a bear.";
        //    fairyTales.PageLength = 8;
        //    fairyTales.Title = "Fairy Tales";

        //    Book cookies;
        //    cookies = new Book();

        //    cookies.Text = "Chocolate chip cookies are the most delicious cookies";
        //    cookies.PageLength = 8;
        //    cookies.Title = "Cookie Recipes";

        //    int page = 3;
        //    string report;

        //    report = "Page " + page.ToString() + "\n"
        //        + fairyTales.Title + ": " + fairyTales.GetPage(page) + "\n"
        //        + cookies.Title + ": " + cookies.GetPage(page) + "\n";
        //    MessageBox.Show(report);
        //    report = "Titles: " + fairyTales.Title + " and " + cookies.Title;
        //    MessageBox.Show(report);
        //}
    }
}
