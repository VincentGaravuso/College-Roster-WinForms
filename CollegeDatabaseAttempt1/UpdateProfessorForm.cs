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
    public partial class UpdateProfessorForm : Form
    {
        public PersonManager pm { get; set; }
        Professor x = new Professor();
        public UpdateProfessorForm(Professor x)
        {
            this.x = x;
            InitializeComponent();
            textBox1.Text = x.name;
            textBox1.ReadOnly = true;
            textBox2.Text = x.address;
            textBox3.Text = x.salary;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x.address = textBox2.Text;
            x.salary = textBox3.Text;
            pm.UpdateProfessor(x, x.name);//Can not update name because that is how it searches for a match
        }
    }
}
