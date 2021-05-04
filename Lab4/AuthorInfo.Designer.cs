namespace Lab4
{
    partial class AuthorInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.birthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(16, 41);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(250, 20);
            this.firstName_textBox.TabIndex = 1;
            this.firstName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstName_textBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name:";
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(16, 121);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(250, 20);
            this.lastName_textBox.TabIndex = 2;
            this.lastName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastName_textBox_Validating);
            // 
            // birthday_dateTimePicker
            // 
            this.birthday_dateTimePicker.Location = new System.Drawing.Point(16, 202);
            this.birthday_dateTimePicker.Name = "birthday_dateTimePicker";
            this.birthday_dateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.birthday_dateTimePicker.TabIndex = 3;
            this.birthday_dateTimePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthday:";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 251);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(88, 24);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(178, 251);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(88, 24);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "Cancel ";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // AuthorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 299);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthday_dateTimePicker);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName_textBox);
            this.Controls.Add(this.label1);
            this.Name = "AuthorInfo";
            this.Text = "AuthorInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.DateTimePicker birthday_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}