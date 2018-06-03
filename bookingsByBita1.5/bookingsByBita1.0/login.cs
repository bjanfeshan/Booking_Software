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

namespace bookingsByBita1._0
{
    public partial class login : Form
    {
        public login()
        {
            try
            {
                Thread t = new Thread(new ThreadStart(logoDisplay));
                t.Start();
                Thread.Sleep(5000);

                InitializeComponent();

                t.Abort();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public void logoDisplay()  
        {
            Application.Run(new logo());
        }

        

        private void btnLogin_Click(object sender, EventArgs e) // code to check the password
        {
            try {
                using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=HairSalon;Integrated Security=True"))
                {
                    string query = "Select EmpID, Pass from Employees where EmpID = '" + txtUserName.Text + "' and Pass = '" + txtPassword.Text + "'";
                    //SqlCommand cmd = new SqlCommand("Select EmpID, Pass from dbo.Employees where EmpID = '" + txtEmpID.Text + "' and Pass = '" + txtPassword.Text + "'", sqlcon)
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count == 1)
                    {
                        mainMenu menuObj = new mainMenu();
                        this.Hide();
                        menuObj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Check your Employee ID and Password");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
