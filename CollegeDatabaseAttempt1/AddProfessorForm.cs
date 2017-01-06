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
    public partial class AddProfessorForm : Form
    {
        public AddProfessorForm()
        {
            InitializeComponent();
        }

        public PersonManager pm { get; set; }
        

        private void AddProfessorForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Professor x = new Professor();
            x.name = nameTextBox.Text;
            x.salary = salaryTextBox.Text;
            x.address = addressTextBox.Text;
            pm.p.Add(x);
            this.Close();
        }

    }
}
