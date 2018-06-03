//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Threading;

//namespace bookingsByBita1._0
//{
//    public partial class empLookUp : Form
//    {
//        HairSalonDBContext db = new HairSalonDBContext();
//        public empLookUp()
//        {
          
//            InitializeComponent();

//        }

//        private void custUpdate_Load(object sender, EventArgs e)
//        {
//            dataGridViewCustomers2.DataSource = db.Employees.ToList();
//        }

//        private void dataGridViewCustomers2_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {
//                DataGridViewRow row = this.dataGridViewCustomers2.Rows[e.RowIndex];
//                txtCustomerID.Text = row.Cells["custIDDataGridViewTextBoxColumn"].Value.ToString();
//                txtCustFirstName.Text = row.Cells["custFirstNameDataGridViewTextBoxColumn"].Value.ToString();
//                txtCustLastName.Text = row.Cells["custLastNameDataGridViewTextBoxColumn"].Value.ToString();
//                txtCustPhone.Text = row.Cells["custPhoneDataGridViewTextBoxColumn"].Value.ToString();
//                txtCustEmail.Text = row.Cells["custEmailDataGridViewTextBoxColumn"].Value.ToString();
//            }
//        }

//        private void btnLogin_Click(object sender, EventArgs e) // code to check the password
//        {
            
//            this.Hide(); // hid the login screen
//            // database query for the daily schedule
//        }

//        private void btnExit_Click(object sender, EventArgs e)
//        {
//            addEdit back = new addEdit();
//            back.Show();
//            this.Hide();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("This is where you can add and update your customer information");
//        }

//        private void btnEditCustomer_Click(object sender, EventArgs e)
//        {
//            //update the customer record
//        }

//        private void btnAddCustomer_Click(object sender, EventArgs e)
//        {
//            // add new record
//            using (HairSalonDBContext context = new HairSalonDBContext())
//            {
//                Add Client
//                Employee emp = new Employee()
//                {
//                    CustFirstName = txtCustFirstName.Text,
//                    CustLastName = txtCustLastName.Text,
//                    CustPhone = txtCustPhone.Text,
//                    CustEmail = txtCustEmail.Text

//                };
//                context.Employees.Add(emp);
//                context.SaveChanges();
//                MessageBox.Show("Client is added successfully.");
//                //Clear texboxes values
//                txtCustFirstName.Clear();
//                txtCustLastName.Clear();
//                txtCustPhone.Clear();
//                txtCustEmail.Clear();

//                //Go back to Menu
//                //this.Hide();
//                //addEdit edit = new addEdit();
//                //edit.ShowDialog();

//            }
//        }

//        private void btnEditCustomer_Click_1(object sender, EventArgs e)
//        {            
//            using (HairSalonDBContext context = new HairSalonDBContext())
//            {

//                Employee emp = new Employee();
//                emp.CustFirstName = txtCustFirstName.Text;
//                emp.CustLastName = txtCustLastName.Text;
//                emp.CustPhone = txtCustPhone.Text;
//                emp.CustEmail = txtCustEmail.Text;

//                context.SaveChanges();
//                MessageBox.Show("Record is modified successfully.");

//                //Clear texboxes values
//                txtCustFirstName.Clear();
//                txtCustLastName.Clear();
//                txtCustPhone.Clear();
//                txtCustEmail.Clear();
//            }
//        }

//        private void txtSearchBox_TextChanged(object sender, EventArgs e)
//        {
//            dataGridViewCustomers2.DataSource = db.Employees.Where(x => x.CustLastName.Contains(txtSearchBox.Text) || x.CustFirstName.Contains(txtSearchBox.Text)).ToList();
//        }
//    }
//}
