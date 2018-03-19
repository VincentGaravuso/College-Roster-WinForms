using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeDatabaseAttempt1
{
    public partial class AddDecisionForm : Form
    {
        public AddDecisionForm()
        {
            InitializeComponent();
        }
        public PersonManager pm { get; set; }

        private void DecisionForm_Load(object sender, EventArgs e)
        {

        }

        private void StudentDecision_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProfessorDecision_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void decisionButton_Click(object sender, EventArgs e)
        {
            if(StudentDecision.Checked == true)
            {
                AddStudentForm a = new AddStudentForm();
                a.pm = this.pm;
                a.Show();

                this.Close();
            }
            else if(ProfessorDecision.Checked == true)
            {
                AddProfessorForm x = new AddProfessorForm();
                x.pm = this.pm;
                x.Show();
                this.Close();
            }
        }
    }
}
