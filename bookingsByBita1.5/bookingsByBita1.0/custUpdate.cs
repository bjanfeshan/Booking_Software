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
    public partial class custUpdate : Form
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

        public custUpdate()
        {
          
            InitializeComponent();

        }

        private void custUpdate_Load(object sender, EventArgs e)
        {
            
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

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you can add customer information");
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            //update the customer record
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                //Input Validation
                if (txtCustFirstName.Text == "" || txtCustLastName.Text == "")
                {
                    MessageBox.Show("First name and last name are required.");
                }
                else if (!Regex.IsMatch(txtCustFirstName.Text, @"^([a-zA-Z]+$)") || !Regex.IsMatch(txtCustLastName.Text, @"^([a-zA-Z]+$)"))
                {
                    MessageBox.Show("First and last names must only contain letters.");
                }
                else if (!IsEmailValid(txtCustEmail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.");
                }
                else if (txtCustPhone.Text == "" && !Regex.IsMatch(txtCustPhone.Text, @"^([1-9]{1}[0-9]{9}$)"))
                {
                    MessageBox.Show("Phone number cand only contain numbers and 10 digits long.");
                }
                else
                {
                    // add new record
                    using (HairSalonDBContext context = new HairSalonDBContext())
                    {
                        //Add Client
                        Customer cust = new Customer()
                        {
                            CustFirstName = txtCustFirstName.Text,
                            CustLastName = txtCustLastName.Text,
                            CustPhone = txtCustPhone.Text,
                            CustEmail = txtCustEmail.Text

                        };
                        context.Customers.Add(cust);
                        context.SaveChanges();
                        MessageBox.Show("Client is added successfully.");
                        //Clear texboxes values
                        txtCustFirstName.Clear();
                        txtCustLastName.Clear();
                        txtCustPhone.Clear();
                        txtCustEmail.Clear();
                        
                    }
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("The system could not connect to database. Please check the database connection settings.");
                throw ex;
            }
        }

        private void btnEditCustomer_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (HairSalonDBContext context = new HairSalonDBContext())
                {

                    Customer cust = new Customer();
                    cust.CustFirstName = txtCustFirstName.Text;
                    cust.CustLastName = txtCustLastName.Text;
                    cust.CustPhone = txtCustPhone.Text;
                    cust.CustEmail = txtCustEmail.Text;

                    context.SaveChanges();
                    MessageBox.Show("Record is Added successfully.");

                    //Clear texboxes values
                    txtCustFirstName.Clear();
                    txtCustLastName.Clear();
                    txtCustPhone.Clear();
                    txtCustEmail.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("The system could not connect to database. Please check the database connection settings.");
                throw ex;
            }
        }

        private void btnEditCustomer_Click_2(object sender, EventArgs e)
        {
            //Go back to Menu
            this.Hide();
            custLookUp edit = new custLookUp();
            edit.ShowDialog();
        }
    }
}
