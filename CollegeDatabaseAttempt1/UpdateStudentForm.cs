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
    public partial class UpdateStudentForm : Form
    {

        public PersonManager pm { get; set; }
        Student s = new Student();
        public UpdateStudentForm(Student s)
        {
            this.s = s;
            InitializeComponent();

            NameTextBox.Text = s.name;
            NameTextBox.ReadOnly = true;
            AddressTextBox.Text = s.address;
            gpaTextBox.Text = s.gpa;

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            s.address = AddressTextBox.Text;
            s.gpa = gpaTextBox.Text;
            pm.UpdateStudent(s, s.name);//Can not update name because that is how it searches for a match
        }
    }
}
