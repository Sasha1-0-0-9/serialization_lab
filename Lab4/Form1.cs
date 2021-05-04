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
    public partial class Form1 : Form
    {
        List<Journal> journals = new List<Journal>();
        public Form1()
        {
            InitializeComponent();

            edit_button.Enabled = false;
            showInfo_button.Enabled = false;
            delete_button.Enabled = false;
            
            journals = Journal.ReadJournalList("journals");           
            journals.ForEach(journalListInfo =>
            {
                journals_List.Items.Add(journalListInfo.ToShortString());
            });
        }

        private void JournalsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_button.Enabled = true;
            showInfo_button.Enabled = true;
            delete_button.Enabled = true;
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Journal newJournal = new Journal();           
            JournalInfo journalModal = new JournalInfo(newJournal);
            if (journalModal.ShowDialog() == DialogResult.OK)
            {
                journals_List.Items.Add(newJournal.ToShortString());
                journals.Add(newJournal);
            }
            else
            {                               
                 MessageBox.Show("Changes was not saved");
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {            
            int selectedIndex = journals_List.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= journals.Count)
            {
                MessageBox.Show("You need to choose journal!");
                return;
            }
            JournalInfo journalModal = new JournalInfo(journals[journals_List.SelectedIndex]);
            if (journalModal.ShowDialog() == DialogResult.OK)
            {
                journals_List.Items[selectedIndex] = journals[journals_List.SelectedIndex].ToShortString();
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = journals_List.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= journals.Count)
            {
                MessageBox.Show("You need to choose journal!");
                return;
            }
            journals.RemoveAt(selectedIndex);
            journals_List.Items.RemoveAt(selectedIndex);
        }

        private void showInfo_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = journals_List.SelectedIndex;
            if(selectedIndex < 0 || selectedIndex >= journals.Count)
            {
                MessageBox.Show("You don`t choose a journal");
            }
            else
            {
                MessageBox.Show(journals[selectedIndex].ToString());
            }
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if(journals!= null)
            {
                Journal.WriteJournalsToFile("journals", journals);
                MessageBox.Show("Saved successfully!");
            }
            else
            {
                MessageBox.Show("There are nothing to save");
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && DialogResult != DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);        
                if (result == DialogResult.Yes)
                {
                    Journal.WriteJournalsToFile("journals", journals);
                    MessageBox.Show("Saved successfully!");
                }               
            }
               
        }
    }
}
