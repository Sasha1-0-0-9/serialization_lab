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
    public partial class AuthorInfo : Form
    {
        Author authorInfo;
       
        public AuthorInfo(Author author)
        {
            InitializeComponent();
            authorInfo = author;            
           
            if(author != null && author.FirstName!= null && author.LastName != null && author.Birthday != null)
            {
                firstName_textBox.Text = author.FirstName;
                lastName_textBox.Text = author.LastName;
                birthday_dateTimePicker.Value = author.Birthday;
            }         
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if(firstName_textBox.Text =="" || lastName_textBox.Text == "")
            {
                MessageBox.Show("You need to fill emply values!");
                return;
            }
            authorInfo.FirstName = firstName_textBox.Text;
            authorInfo.LastName = lastName_textBox.Text;
            authorInfo.Birthday = birthday_dateTimePicker.Value;              
            DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void firstName_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(firstName_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("The first name should be consist of letters and can`t be empty");
            }
        }

        private void lastName_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(firstName_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("The last name should be consist of letters and can`t be empty");
            }
        }

        private void AuthorInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    authorInfo.FirstName = firstName_textBox.Text;
                    authorInfo.LastName = lastName_textBox.Text;
                    authorInfo.Birthday = birthday_dateTimePicker.Value;                    
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
