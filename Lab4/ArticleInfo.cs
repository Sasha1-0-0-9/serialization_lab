using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class ArticleInfo : Form
    {
        Article articleInfo;
        List<Author> authors;

        public ArticleInfo(Article article)
        {
            InitializeComponent();
            articleInfo = article;
            edit_author_info.Enabled = false;
  
            authors = Author.ReadAuthorsList("authors");
            authors.ForEach(author =>
            {
                authors_comboBox.Items.Add(author.ToString());
            });

            if (articleInfo != null && articleInfo.Title != null && articleInfo.ArticleAuthor != null)
            {
                authors_comboBox.SelectedIndex = authors_comboBox.Items.IndexOf(article.ArticleAuthor.ToString());
                title_textBox.Text = article.Title;
                pagesNumber_textBox.Text = article.PagesNumber.ToString();
                honorarium_textBox.Text = article.Honorarium.ToString();
            }          
        }     

        private void authors_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_author_info.Enabled = true;
        }

        private void edit_author_info_Click(object sender, EventArgs e)
        {           
            int selectedIndex = authors_comboBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= authors.Count)
            {
                MessageBox.Show("You need to choose author!");
                return;
            }
            AuthorInfo authorModal = new AuthorInfo(authors[selectedIndex]);
            if(authorModal.ShowDialog() == DialogResult.OK)
            {
                authors_comboBox.Items[selectedIndex] = authors[selectedIndex].ToString();
                Author.WriteAuthorsToFile("authors", authors);
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }                              
        }

        private void create_author_Click(object sender, EventArgs e)
        {
            Author newAuthor = new Author();
            AuthorInfo authorModal = new AuthorInfo(newAuthor);
            if(authorModal.ShowDialog() == DialogResult.OK)
            {
                authors_comboBox.Items.Add(newAuthor.ToString());
                authors.Add(newAuthor);
                Author.WriteAuthorsToFile("authors", authors);
            }   
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

        private void title_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(title_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("The title should be consist of letters and can`t be empty");
            }
        }

        private void pagesNumber_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$");
            if (!regexGroupFormat.IsMatch(pagesNumber_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Pages number must be an integer number!");
            }
        }

        private void honorarium_textBox_Validating(object sender, CancelEventArgs e)
        {
            //regex must be changed to view like( 10,45 or 1000)
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(honorarium_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Honorarium must be a number(100 or 10,60)!");
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = authors_comboBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= authors.Count)
            {
                MessageBox.Show("You need to choose author!");
                return;
            }
            if(title_textBox.Text == "" || pagesNumber_textBox.Text == "" || honorarium_textBox.Text == "")
            {
                MessageBox.Show("You need to fill empty fields!");
                return;
            }
            articleInfo.ArticleAuthor = authors[selectedIndex];
            articleInfo.Title = title_textBox.Text;
            articleInfo.PagesNumber = int.Parse(pagesNumber_textBox.Text);
            articleInfo.Honorarium = double.Parse(honorarium_textBox.Text);
            DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.Cancel;
        }

        private void ArticleInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    articleInfo.ArticleAuthor = authors[authors_comboBox.SelectedIndex];
                    articleInfo.Title = title_textBox.Text;
                    articleInfo.PagesNumber = int.Parse(pagesNumber_textBox.Text);
                    articleInfo.Honorarium = double.Parse(honorarium_textBox.Text);
                    DialogResult = DialogResult.OK;                   
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
