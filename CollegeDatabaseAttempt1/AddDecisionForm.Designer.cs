namespace CollegeDatabaseAttempt1
{
    partial class AddDecisionForm
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
            this.StudentDecision = new System.Windows.Forms.RadioButton();
            this.ProfessorDecision = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.decisionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentDecision
            // 
            this.StudentDecision.AutoSize = true;
            this.StudentDecision.Location = new System.Drawing.Point(15, 78);
            this.StudentDecision.Name = "StudentDecision";
            this.StudentDecision.Size = new System.Drawing.Size(62, 17);
            this.StudentDecision.TabIndex = 0;
            this.StudentDecision.TabStop = true;
            this.StudentDecision.Text = "Student";
            this.StudentDecision.UseVisualStyleBackColor = true;
            this.StudentDecision.CheckedChanged += new System.EventHandler(this.StudentDecision_CheckedChanged);
            // 
            // ProfessorDecision
            // 
            this.ProfessorDecision.AutoSize = true;
            this.ProfessorDecision.Location = new System.Drawing.Point(15, 102);
            this.ProfessorDecision.Name = "ProfessorDecision";
            this.ProfessorDecision.Size = new System.Drawing.Size(69, 17);
            this.ProfessorDecision.TabIndex = 1;
            this.ProfessorDecision.TabStop = true;
            this.ProfessorDecision.Text = "Professor";
            this.ProfessorDecision.UseVisualStyleBackColor = true;
            this.ProfessorDecision.CheckedChanged += new System.EventHandler(this.ProfessorDecision_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check which you want to add:";
            // 
            // decisionButton
            // 
            this.decisionButton.Location = new System.Drawing.Point(197, 226);
            this.decisionButton.Name = "decisionButton";
            this.decisionButton.Size = new System.Drawing.Size(75, 23);
            this.decisionButton.TabIndex = 3;
            this.decisionButton.Text = "Next";
            this.decisionButton.UseVisualStyleBackColor = true;
            this.decisionButton.Click += new System.EventHandler(this.decisionButton_Click);
            // 
            // AddDecisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.decisionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfessorDecision);
            this.Controls.Add(this.StudentDecision);
            this.Name = "AddDecisionForm";
            this.Text = "DecisionForm";
            this.Load += new System.EventHandler(this.DecisionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton StudentDecision;
        private System.Windows.Forms.RadioButton ProfessorDecision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decisionButton;
    }
}