using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CollegeDatabaseAttempt1
{
    public partial class DisplayDecisionForm : Form
    {
        public DisplayDecisionForm()
        {
            InitializeComponent();
        }
        
        public PersonManager pm { get; set; }
        public Professor x { get; set; }
        public Student s { get; set; }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            
            namesListBox.Items.Clear();
            for (int i = 0; i < pm.DisplayByName(nameTextBox.Text.ToLower()).Count; i++)
            {
                namesListBox.Items.Add(pm.DisplayByName(nameTextBox.Text.ToLower())[i]);
            }
            nameTextBox.Clear();
        }

        private void namesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sortRadioButton_Click(object sender, EventArgs e)
        {

            namesListBox.Items.Clear();
            if (AllRadioButton.Checked)
            {
                for (int i = 0; i < pm.DisplayAll().Count; i++)
                {
                    namesListBox.Items.Add(pm.DisplayAll()[i]);
                }
            }
            else if (studentRadioButton.Checked)
            {
                
                for (int i = 0; i < pm.DisplayAllStudents().Count;i++)
                {
                    namesListBox.Items.Add(pm.DisplayAllStudents()[i]);
                }
            }
            else if (ProfessorRadioButton.Checked)
            {

                for (int i = 0; i < pm.DisplayAllProfessors().Count; i++)
                {
                    namesListBox.Items.Add(pm.DisplayAllProfessors()[i]);
                }
            }
        }

        private void RemoveByNameButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();
            namesListBox.Items.Add(pm.RemoveByName(nameTextBox.Text.ToLower()));
            nameTextBox.Clear();
        }
       private void UpdateByNameButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();
            if (pm.GetObjType(nameTextBox.Text.ToLower()) == "Student")
            {

                s = pm.GetStudentByName(nameTextBox.Text.ToLower());
                UpdateStudentForm us = new UpdateStudentForm(s);
                us.pm = this.pm;
                us.Show();

                this.Close();

            }
            else if (pm.GetObjType(nameTextBox.Text.ToLower()) == "Professor")
            {


                x = pm.GetProfessorByName(nameTextBox.Text);
                UpdateProfessorForm up = new UpdateProfessorForm(x);
                up.pm = this.pm;
                up.Show();

                this.Close();
            }
        }
















//Dead
        private void namesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }        
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox1(object sender, EventArgs e)
        { 
        }

        private void textBox1_TextChanged_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
