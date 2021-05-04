namespace Lab4
{
    partial class ArticleInfo
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
            this.authors_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pagesNumber_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.honorarium_textBox = new System.Windows.Forms.TextBox();
            this.create_author = new System.Windows.Forms.Button();
            this.edit_author_info = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authors_comboBox
            // 
            this.authors_comboBox.FormattingEnabled = true;
            this.authors_comboBox.Location = new System.Drawing.Point(12, 50);
            this.authors_comboBox.Name = "authors_comboBox";
            this.authors_comboBox.Size = new System.Drawing.Size(234, 21);
            this.authors_comboBox.TabIndex = 1;
            this.authors_comboBox.SelectedIndexChanged += new System.EventHandler(this.authors_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(12, 184);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(234, 20);
            this.title_textBox.TabIndex = 4;
            this.title_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.title_textBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pages number:";
            // 
            // pagesNumber_textBox
            // 
            this.pagesNumber_textBox.Location = new System.Drawing.Point(12, 261);
            this.pagesNumber_textBox.Name = "pagesNumber_textBox";
            this.pagesNumber_textBox.Size = new System.Drawing.Size(234, 20);
            this.pagesNumber_textBox.TabIndex = 5;
            this.pagesNumber_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.pagesNumber_textBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Honorarium:";
            // 
            // honorarium_textBox
            // 
            this.honorarium_textBox.Location = new System.Drawing.Point(12, 328);
            this.honorarium_textBox.Name = "honorarium_textBox";
            this.honorarium_textBox.Size = new System.Drawing.Size(234, 20);
            this.honorarium_textBox.TabIndex = 6;
            this.honorarium_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.honorarium_textBox_Validating);
            // 
            // create_author
            // 
            this.create_author.Location = new System.Drawing.Point(155, 99);
            this.create_author.Name = "create_author";
            this.create_author.Size = new System.Drawing.Size(91, 28);
            this.create_author.TabIndex = 3;
            this.create_author.Text = "Create author";
            this.create_author.UseVisualStyleBackColor = true;
            this.create_author.Click += new System.EventHandler(this.create_author_Click);
            // 
            // edit_author_info
            // 
            this.edit_author_info.Location = new System.Drawing.Point(13, 99);
            this.edit_author_info.Name = "edit_author_info";
            this.edit_author_info.Size = new System.Drawing.Size(91, 28);
            this.edit_author_info.TabIndex = 2;
            this.edit_author_info.Text = "Edit author info";
            this.edit_author_info.UseVisualStyleBackColor = true;
            this.edit_author_info.Click += new System.EventHandler(this.edit_author_info_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 377);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(91, 34);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(155, 377);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(91, 34);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ArticleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 423);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.edit_author_info);
            this.Controls.Add(this.create_author);
            this.Controls.Add(this.honorarium_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pagesNumber_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authors_comboBox);
            this.Name = "ArticleInfo";
            this.Text = "ArticleInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArticleInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox authors_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pagesNumber_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox honorarium_textBox;
        private System.Windows.Forms.Button create_author;
        private System.Windows.Forms.Button edit_author_info;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}