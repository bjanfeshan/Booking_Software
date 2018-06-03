using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookingsByBita1._0
{
    public partial class addEdit : Form
    {
        public addEdit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainMenu newEmp = new mainMenu();
            newEmp.Show();
            this.Hide();
        }

                private void btnSched_Click(object sender, EventArgs e)
        {
            empUpdate newEmp = new empUpdate();
            newEmp.Show();
            this.Hide();
        }

        private void btnAppt_Click(object sender, EventArgs e)
        {
            custUpdate newCust = new custUpdate();
            newCust.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            this.Hide();
            menu.Show();
        }
    }
}
