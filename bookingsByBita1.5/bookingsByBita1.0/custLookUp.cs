using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace bookingsByBita1._0
{
    public partial class custLookUp : Form
    {
        HairSalonDBContext db = new HairSalonDBContext();

        //Method to valdate email inputs
        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        
        public custLookUp()
        {
          
            InitializeComponent();

        }

        private void custUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCustomers2.DataSource = db.Customers.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridViewCustomers2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewCustomers2.Rows[e.RowIndex];
                    txtCustomerID.Text = row.Cells["custIDDataGridViewTextBoxColumn"].Value.ToString();
                    txtCustFirstName.Text = row.Cells["custFirstNameDataGridViewTextBoxColumn"].Value.ToString();
                    txtCustLastName.Text = row.Cells["custLastNameDataGridViewTextBoxColumn"].Value.ToString();
                    txtCustPhone.Text = row.Cells["custPhoneDataGridViewTextBoxColumn"].Value.ToString();
                    txtCustEmail.Text = row.Cells["custEmailDataGridViewTextBoxColumn"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) // code to check the password
        {
            
            this.Hide(); // hid the login screen
            // database query for the daily schedule
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            addEdit back = new addEdit();
            back.Show();
            this.Hide();
        }
         
                        
        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCustomers2.DataSource = db.Customers.Where(x => x.CustLastName.Contains(txtSearchBox.Text) || x.CustFirstName.Contains(txtSearchBox.Text)).ToList();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            //update the customer record
            try
            {
                using (HairSalonDBContext context = new HairSalonDBContext())
                {
                    int id = Convert.ToInt32(txtCustomerID.Text);
                    Customer cust = context.Customers.Where(r => r.CustID == id).FirstOrDefault();
                    cust.CustFirstName = txtCustFirstName.Text;
                    cust.CustLastName = txtCustLastName.Text;
                    cust.CustPhone = txtCustPhone.Text;
                    cust.CustEmail = txtCustEmail.Text;

                    context.SaveChanges();
                    MessageBox.Show("Record is modified successfully.");

                    //Clear texboxes values
                    txtSearchBox.Clear();
                    txtCustFirstName.Clear();
                    txtCustLastName.Clear();
                    txtCustPhone.Clear();
                    txtCustEmail.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The system could not connect to database. Please check the database connection settings.");
                throw ex;
            }
        }
    }
}
