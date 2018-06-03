using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bookingsByBita1._0
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEdit newAddEdit = new addEdit();
            newAddEdit.Show();
            this.Hide();
        }

        private void btnSched_Click(object sender, EventArgs e)
        {
            chkAppt newAppt = new chkAppt();
            newAppt.Show();
            this.Hide();
        }

        private void btnAppt_Click(object sender, EventArgs e)
        {          
            Appt seeAppt = new Appt();
            seeAppt.Show();
            this.Hide();
        }

       
        private void mainMenu_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hairSalonDataSet.spShowTodaySchedule' table. You can move, or remove it, as needed.
            this.spShowTodayScheduleTableAdapter.Fill(this.hairSalonDataSet.spShowTodaySchedule);

        }
    }
}
