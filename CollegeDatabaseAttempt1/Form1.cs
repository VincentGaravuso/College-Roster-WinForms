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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PersonManager pm = new PersonManager();

        private void addButton_Click(object sender, EventArgs e)
        {
            AddDecisionForm d = new AddDecisionForm();
            d.pm = this.pm;
            d.Show();
        }


        //dead
        private void removeButton_Click(object sender, EventArgs e)
        {
            DisplayDecisionForm d = new DisplayDecisionForm();
            d.pm = this.pm;
            d.Show();
        }
        //dead
        private void updateButton_Click(object sender, EventArgs e)
        {
            DisplayDecisionForm d = new DisplayDecisionForm();
            d.pm = this.pm;
            d.Show();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DisplayDecisionForm d = new DisplayDecisionForm();
            d.pm = this.pm;
            d.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
