using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class JournalInfo : Form
    {
        public Journal journalInfo;

        public JournalInfo(Journal journal)
        {
            InitializeComponent();

            journalInfo = journal;

            Periodicity[] periodiciiesy = (Periodicity[])Enum.GetValues(typeof(Periodicity));
            foreach (Periodicity periodicity in periodiciiesy)
            {
                periodicity_comboBox.Items.Add(periodicity.ToString());
            }            
            if(journalInfo != null && journalInfo.Name != null && journal.JournalPeriodicity != null)
            {
                periodicity_comboBox.SelectedIndex = periodicity_comboBox.Items.IndexOf(journal.JournalPeriodicity.ToString());
                journal_name.Text = journal.Name;
                journalInfo.CalculatePagesAndAuthors();
                total_pages_label.Text = journal.TotalPagesNumber.ToString();
                if (journal.Articles != null)
                {
                    journal.Articles.ForEach(article =>
                    {
                        articles_list.Items.Add(article);
                    });
                }
            }                      
            edit_Article.Enabled = false;
            delete_button.Enabled = false;
        }
            
        private void edit_Article_Click(object sender, EventArgs e)
        {            
            int selectedIndex = articles_list.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= journalInfo.Articles.Count)
            {
                MessageBox.Show("You need to choose article!");
                return;
            }
            ArticleInfo articleModal = new ArticleInfo(journalInfo.Articles[selectedIndex]);
            if (articleModal.ShowDialog() == DialogResult.OK)
            {
                articles_list.Items[selectedIndex] = journalInfo.Articles[selectedIndex].ToString();
                journalInfo.CalculatePagesAndAuthors();
                total_pages_label.Text = journalInfo.TotalPagesNumber.ToString();
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

        private void create_article_Click(object sender, EventArgs e)
        {
            Article newArticle = new Article();
            ArticleInfo articleModal = new ArticleInfo(newArticle);
            if (articleModal.ShowDialog() == DialogResult.OK)
            {
                journalInfo.AddArticle(newArticle);
                journalInfo.CalculatePagesAndAuthors();
                articles_list.Items.Add(newArticle.ToString());
                total_pages_label.Text = journalInfo.TotalPagesNumber.ToString();
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

        private void articles_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_Article.Enabled = true;
            delete_button.Enabled = true;
        }      

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void save_button_Click(object sender, EventArgs e)
        {           
            journalInfo.Name = journal_name.Text;           
            if (periodicity_comboBox.SelectedItem == null || journal_name.Text == "")
            {
                MessageBox.Show("You need to fill empty fields!");
                return;
            }
            journalInfo.JournalPeriodicity = (Periodicity)Enum.Parse(typeof(Periodicity), periodicity_comboBox.SelectedItem.ToString());        
            DialogResult = DialogResult.OK;
        }

        private void JournalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if user click "X" it will trigger UserClosing CloseReason, so we need to check if he want to save changes
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    journalInfo.Name = journal_name.Text;
                    journalInfo.JournalPeriodicity = (Periodicity)Enum.Parse(typeof(Periodicity), periodicity_comboBox.SelectedItem.ToString());
                    journalInfo.Articles = journalInfo.Articles != null ? journalInfo.Articles : null;
                    DialogResult = DialogResult.OK;                  
                }
               else
               {
                    DialogResult = DialogResult.Cancel;
               }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = articles_list.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= journalInfo.Articles.Count)
            {
                MessageBox.Show("You need to choose article!");
                return;
            }
            journalInfo.Articles.RemoveAt(selectedIndex);
            articles_list.Items.RemoveAt(selectedIndex);
        }
    }
}
