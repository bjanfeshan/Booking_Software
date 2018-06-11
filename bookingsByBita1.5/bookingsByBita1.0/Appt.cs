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
    public partial class Appt : Form
    {
        HairSalonDBContext db = new HairSalonDBContext();
        public Appt()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            mainMenu back = new mainMenu();
            this.Hide();
            back.Show();
        }

        private void Appt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hairSalonDataSet.spShowAllHairStylist' table. You can move, or remove it, as needed.
            this.spShowAllHairStylistTableAdapter.Fill(this.hairSalonDataSet.spShowAllHairStylist);
            
            try
            {
                dataGridViewCustomers.DataSource = db.Customers.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource = db.Customers.Where(x => x.CustLastName.Contains(txtSearchBox.Text) || x.CustFirstName.Contains(txtSearchBox.Text)).ToList();
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewCustomers.Rows[e.RowIndex];
                    txtCustID.Text = row.Cells["custIDDataGridViewTextBoxColumn"].Value.ToString();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cboHairStylist_SelectedIndexChanged(object sender, EventArgs e)
        {

           // txtEmpID.Text = cboHairStylist.ValueMember.ToString();
        }

        private void btnSched_Click(object sender, EventArgs e)
        {
            try
            {
                //insert record into database
                using (HairSalonDBContext context = new HairSalonDBContext())
                {
                    //Add appoinment
                    Appointment appt = new Appointment()
                    {
                        EmpID = txtEmpID.Text,
                        CustID = Convert.ToInt32(txtCustID.Text),
                        AptDate = (dtpDate.Value),
                        AptTime = (dateTimePicker2).Value.TimeOfDay
                        // AptTime = TimeSpan.Parse(txtTime.Text)

                    };

                    context.Appointments.Add(appt);
                    context.SaveChanges();
                    MessageBox.Show("The Appointment Is Added");
                    //mainMenu main = new mainMenu();
                    //this.Hide();
                    //main.Show();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("The Appointment was not added! Please check database connection settings." + ex.Message);
                
            }
            
        }

       
    }
}
