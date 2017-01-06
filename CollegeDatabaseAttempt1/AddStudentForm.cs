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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        public PersonManager pm { get; set; }
        

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = nameTextBox.Text;
            s.gpa = gpaTextBox.Text;
            s.address = addressTextBox.Text;
            pm.p.Add(s);
            this.Close();

        }
    }
}
