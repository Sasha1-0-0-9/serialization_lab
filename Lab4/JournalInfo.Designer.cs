namespace Lab4
{
    partial class JournalInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.articles_list = new System.Windows.Forms.ListBox();
            this.create_article = new System.Windows.Forms.Button();
            this.edit_Article = new System.Windows.Forms.Button();
            this.journal_name = new System.Windows.Forms.TextBox();
            this.journal_full_info = new System.Windows.Forms.Label();
            this.total_pages_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.periodicity_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // articles_list
            // 
            this.articles_list.FormattingEnabled = true;
            this.articles_list.Location = new System.Drawing.Point(12, 192);
            this.articles_list.Name = "articles_list";
            this.articles_list.Size = new System.Drawing.Size(292, 186);
            this.articles_list.TabIndex = 3;
            this.articles_list.SelectedIndexChanged += new System.EventHandler(this.articles_list_SelectedIndexChanged);
            // 
            // create_article
            // 
            this.create_article.Location = new System.Drawing.Point(310, 192);
            this.create_article.Name = "create_article";
            this.create_article.Size = new System.Drawing.Size(91, 34);
            this.create_article.TabIndex = 4;
            this.create_article.Text = "Create";
            this.create_article.UseVisualStyleBackColor = true;
            this.create_article.Click += new System.EventHandler(this.create_article_Click);
            // 
            // edit_Article
            // 
            this.edit_Article.Location = new System.Drawing.Point(312, 304);
            this.edit_Article.Name = "edit_Article";
            this.edit_Article.Size = new System.Drawing.Size(91, 34);
            this.edit_Article.TabIndex = 5;
            this.edit_Article.Text = "Edit";
            this.edit_Article.UseVisualStyleBackColor = true;
            this.edit_Article.Click += new System.EventHandler(this.edit_Article_Click);
            // 
            // journal_name
            // 
            this.journal_name.Location = new System.Drawing.Point(12, 56);
            this.journal_name.Name = "journal_name";
            this.journal_name.Size = new System.Drawing.Size(391, 20);
            this.journal_name.TabIndex = 1;
            // 
            // journal_full_info
            // 
            this.journal_full_info.AutoSize = true;
            this.journal_full_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journal_full_info.Location = new System.Drawing.Point(13, 172);
            this.journal_full_info.Name = "journal_full_info";
            this.journal_full_info.Size = new System.Drawing.Size(139, 17);
            this.journal_full_info.TabIndex = 6;
            this.journal_full_info.Text = "Total pages number:";
            // 
            // total_pages_label
            // 
            this.total_pages_label.AutoSize = true;
            this.total_pages_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_pages_label.Location = new System.Drawing.Point(158, 172);
            this.total_pages_label.Name = "total_pages_label";
            this.total_pages_label.Size = new System.Drawing.Size(13, 17);
            this.total_pages_label.TabIndex = 7;
            this.total_pages_label.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Journal name:";
            // 
            // periodicity_comboBox
            // 
            this.periodicity_comboBox.FormattingEnabled = true;
            this.periodicity_comboBox.Location = new System.Drawing.Point(12, 131);
            this.periodicity_comboBox.Name = "periodicity_comboBox";
            this.periodicity_comboBox.Size = new System.Drawing.Size(210, 21);
            this.periodicity_comboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Peridiocity:";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 400);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(103, 34);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save and exit";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(298, 398);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(103, 36);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Cancel and exit";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(312, 344);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(91, 34);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Delete ";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // JournalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 452);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.periodicity_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_pages_label);
            this.Controls.Add(this.journal_full_info);
            this.Controls.Add(this.journal_name);
            this.Controls.Add(this.edit_Article);
            this.Controls.Add(this.create_article);
            this.Controls.Add(this.articles_list);
            this.Name = "JournalInfo";
            this.Text = "JournalInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JournalInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox articles_list;
        private System.Windows.Forms.Button create_article;
        private System.Windows.Forms.Button edit_Article;
        private System.Windows.Forms.TextBox journal_name;
        private System.Windows.Forms.Label journal_full_info;
        private System.Windows.Forms.Label total_pages_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox periodicity_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button delete_button;
    }
}