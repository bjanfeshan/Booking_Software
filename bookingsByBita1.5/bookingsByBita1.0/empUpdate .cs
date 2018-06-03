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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace bookingsByBita1._0
{
    public partial class empUpdate : Form      
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

        //Fill combobox Method
        public void FillCombobox()
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=HairSalon;Integrated Security=True"))
            {
                string query = "Select * from Employees";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboEmpID.Items.Add(dr["EmpID"].ToString());
                }
            }
        }
        public empUpdate()
        {
          
            InitializeComponent();

        }

        private void custUpdate_Load(object sender, EventArgs e)
        {
            FillCombobox();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=HairSalon;Integrated Security=True"))
            {
                string query = "Select * from Employees where EmpID = '" + comboEmpID.SelectedItem.ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtEmpFirstName.Text = dr["EmpFirstName"].ToString();
                    txtEmpLastName.Text = dr["EmpLastName"].ToString();
                    txtPhone.Text = dr["Phone"].ToString();
                    txtEmpEmail.Text = dr["Email"].ToString();
                    txtPass.Text = dr["Pass"].ToString();
                    txtPosition.Text = dr["Position"].ToString();
                    txtAvailability.Text = dr["DaysAvailable"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();

                }
            }

            if(comboEmpID.SelectedItem.ToString() == "")
            {
                txtEmpFirstName.Clear();
                txtEmpLastName.Clear();
                txtPhone.Clear();
                txtEmpEmail.Clear();
                txtPass.Clear();
                txtPosition.Clear();
                txtAvailability.Clear();
                txtSalary.Clear();

                //txtEmpFirstName.Text = "";
                //txtEmpLastName.Text = "";
                //txtPhone.Text = "";
                //txtEmpEmail.Text = "";
                //txtPass.Text = "";
                //txtPosition.Text = "";
                //txtAvailability.Text = "";
                //txtSalary.Text = "";
            }
        }
             
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            addEdit back = new addEdit();
            back.Show();
            this.Hide();
        }
              
       

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // add new record
                using (HairSalonDBContext context = new HairSalonDBContext())
                {
                    //Input Validation
                    if (txtEmpFirstName.Text == "" || txtEmpLastName.Text == "")
                    {
                        MessageBox.Show("First name and last name are required.");
                    }
                    else if (!Regex.IsMatch(txtEmpFirstName.Text, @"^([a-zA-Z]+$)") || !Regex.IsMatch(txtEmpLastName.Text, @"^([a-zA-Z]+$)"))
                    {
                        MessageBox.Show("First and last names must only contain letters.");
                    }
                    else if (!IsEmailValid(txtEmpEmail.Text))
                    {
                        MessageBox.Show("Please enter a valid email address.");
                    }
                    else if (txtPhone.Text == "" && !Regex.IsMatch(txtPhone.Text, @"^([1-9]{1}[0-9]{9}$)"))
                    {
                        MessageBox.Show("Phone number cand only contain numbers and 10 digits long.");
                    }
                    else
                    {
                        //Add Emploee
                        Employee emp = new Employee()
                        {
                            EmpID = txtNewEmpID.Text,
                            EmpFirstName = txtEmpFirstName.Text,
                            EmpLastName = txtEmpLastName.Text,
                            Phone = txtPhone.Text,
                            Email = txtEmpEmail.Text,
                            Pass = txtPass.Text,
                            Position = txtPosition.Text,
                            DaysAvailable = txtAvailability.Text,
                            Salary = Convert.ToInt32(txtSalary.Text)

                        };

                        context.Employees.Add(emp);
                        context.SaveChanges();
                        MessageBox.Show("Employee is added successfully.");
                        //Clear texboxes values
                        txtNewEmpID.Clear();
                        txtEmpFirstName.Clear();
                        txtEmpLastName.Clear();
                        txtPhone.Clear();
                        txtEmpEmail.Clear();
                        txtPass.Clear();
                        txtPosition.Clear();
                        txtAvailability.Clear();
                        txtSalary.Clear();


                    }
                }
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            //update the employee record
            using (HairSalonDBContext context = new HairSalonDBContext())
            {
                string id = comboEmpID.SelectedItem.ToString();
                Employee emp = context.Employees.Where(r => r.EmpID == id).FirstOrDefault();
                emp.EmpFirstName = txtEmpFirstName.Text;
                emp.EmpLastName = txtEmpLastName.Text;
                emp.Phone = txtPhone.Text;
                emp.Email = txtEmpEmail.Text;
                emp.Pass = txtPass.Text;
                emp.Position = txtPosition.Text;
                emp.DaysAvailable = txtAvailability.Text;
                emp.Salary = Convert.ToDecimal(txtSalary.Text);

                context.SaveChanges();
                MessageBox.Show("Record is modified successfully.");

                //Clear texboxes values
                txtEmpFirstName.Clear();
                txtEmpLastName.Clear();
                txtPhone.Clear();
                txtEmpEmail.Clear();
                txtPass.Clear();
                txtPosition.Clear();
                txtAvailability.Clear();
                txtSalary.Clear();

            }
        }
    }
}
