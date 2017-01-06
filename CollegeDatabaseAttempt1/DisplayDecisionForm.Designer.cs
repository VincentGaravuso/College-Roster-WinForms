namespace CollegeDatabaseAttempt1
{
    partial class DisplayDecisionForm
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
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.ProfessorRadioButton = new System.Windows.Forms.RadioButton();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortRadioButton = new System.Windows.Forms.Button();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.RemoveByNameButton = new System.Windows.Forms.Button();
            this.UpdateByNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(13, 44);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(67, 17);
            this.studentRadioButton.TabIndex = 0;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Students";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProfessorRadioButton
            // 
            this.ProfessorRadioButton.AutoSize = true;
            this.ProfessorRadioButton.Location = new System.Drawing.Point(13, 68);
            this.ProfessorRadioButton.Name = "ProfessorRadioButton";
            this.ProfessorRadioButton.Size = new System.Drawing.Size(74, 17);
            this.ProfessorRadioButton.TabIndex = 1;
            this.ProfessorRadioButton.TabStop = true;
            this.ProfessorRadioButton.Text = "Professors";
            this.ProfessorRadioButton.UseVisualStyleBackColor = true;
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Location = new System.Drawing.Point(13, 92);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.AllRadioButton.TabIndex = 2;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "All";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 205);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(144, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(13, 232);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(144, 23);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "Display info";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "To view a list of names \r\nclick one of the following:";
            // 
            // sortRadioButton
            // 
            this.sortRadioButton.Location = new System.Drawing.Point(13, 116);
            this.sortRadioButton.Name = "sortRadioButton";
            this.sortRadioButton.Size = new System.Drawing.Size(75, 23);
            this.sortRadioButton.TabIndex = 8;
            this.sortRadioButton.Text = "Sort";
            this.sortRadioButton.UseVisualStyleBackColor = true;
            this.sortRadioButton.Click += new System.EventHandler(this.sortRadioButton_Click);
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.HorizontalScrollbar = true;
            this.namesListBox.Location = new System.Drawing.Point(163, 9);
            this.namesListBox.MultiColumn = true;
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(248, 303);
            this.namesListBox.TabIndex = 9;
            this.namesListBox.SelectedIndexChanged += new System.EventHandler(this.namesListBox_SelectedIndexChanged_1);
            // 
            // RemoveByNameButton
            // 
            this.RemoveByNameButton.Location = new System.Drawing.Point(13, 261);
            this.RemoveByNameButton.Name = "RemoveByNameButton";
            this.RemoveByNameButton.Size = new System.Drawing.Size(144, 23);
            this.RemoveByNameButton.TabIndex = 10;
            this.RemoveByNameButton.Text = "Remove";
            this.RemoveByNameButton.UseVisualStyleBackColor = true;
            this.RemoveByNameButton.Click += new System.EventHandler(this.RemoveByNameButton_Click);
            // 
            // UpdateByNameButton
            // 
            this.UpdateByNameButton.Location = new System.Drawing.Point(13, 290);
            this.UpdateByNameButton.Name = "UpdateByNameButton";
            this.UpdateByNameButton.Size = new System.Drawing.Size(144, 23);
            this.UpdateByNameButton.TabIndex = 11;
            this.UpdateByNameButton.Text = "Update";
            this.UpdateByNameButton.UseVisualStyleBackColor = true;
            this.UpdateByNameButton.Click += new System.EventHandler(this.UpdateByNameButton_Click);
            // 
            // DisplayDecisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 317);
            this.Controls.Add(this.UpdateByNameButton);
            this.Controls.Add(this.RemoveByNameButton);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.sortRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.AllRadioButton);
            this.Controls.Add(this.ProfessorRadioButton);
            this.Controls.Add(this.studentRadioButton);
            this.Name = "DisplayDecisionForm";
            this.Text = "DisplayDecisionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton ProfessorRadioButton;
        private System.Windows.Forms.RadioButton AllRadioButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sortRadioButton;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.Button RemoveByNameButton;
        private System.Windows.Forms.Button UpdateByNameButton;
    }
}