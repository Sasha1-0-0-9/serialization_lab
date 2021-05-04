namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.journals_List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.showInfo_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // journals_List
            // 
            this.journals_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journals_List.FormattingEnabled = true;
            this.journals_List.ItemHeight = 16;
            this.journals_List.Location = new System.Drawing.Point(12, 47);
            this.journals_List.Name = "journals_List";
            this.journals_List.Size = new System.Drawing.Size(380, 180);
            this.journals_List.TabIndex = 2;
            this.journals_List.SelectedIndexChanged += new System.EventHandler(this.JournalsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Journals list";
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(302, 252);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(90, 27);
            this.create_button.TabIndex = 6;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(14, 252);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(90, 28);
            this.edit_button.TabIndex = 3;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // save_button
            // 
            this.save_button.Image = ((System.Drawing.Image)(resources.GetObject("save_button.Image")));
            this.save_button.Location = new System.Drawing.Point(355, 6);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(37, 34);
            this.save_button.TabIndex = 1;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // showInfo_button
            // 
            this.showInfo_button.Location = new System.Drawing.Point(206, 251);
            this.showInfo_button.Name = "showInfo_button";
            this.showInfo_button.Size = new System.Drawing.Size(90, 28);
            this.showInfo_button.TabIndex = 5;
            this.showInfo_button.Text = "Show info";
            this.showInfo_button.UseVisualStyleBackColor = true;
            this.showInfo_button.Click += new System.EventHandler(this.showInfo_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(110, 251);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(90, 28);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 296);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.showInfo_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.journals_List);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox journals_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button showInfo_button;
        private System.Windows.Forms.Button delete_button;
    }
}

