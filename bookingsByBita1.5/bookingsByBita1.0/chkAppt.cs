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
    public partial class chkAppt : Form
    {
        HairSalonDBContext db = new HairSalonDBContext();
        public chkAppt()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainMenu back = new mainMenu();
            this.Hide();
            back.Show();
        }                       

        private void chkAppt_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=HairSalon;Integrated Security=True"))
                {
                    SqlCommand cmdd = new SqlCommand("spSearch", sqlcon);
                    cmdd.CommandType = CommandType.StoredProcedure;
                    cmdd.Parameters.AddWithValue("@lastname", textBoxCustName.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmdd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewAppt.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The system could not connect to database. Please check the database connection settings." + ex.Message);
                
            }

        }
       
        private void textBoxCustName_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=HairSalon;Integrated Security=True"))
            {
                SqlCommand cmdd = new SqlCommand("spSearch", sqlcon);
                cmdd.CommandType = CommandType.StoredProcedure;
                cmdd.Parameters.AddWithValue("@lastname", textBoxCustName.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmdd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAppt.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=HairSalon;Integrated Security=True"))
            {
                SqlCommand cmdd = new SqlCommand("spSearch", sqlcon);
                cmdd.CommandType = CommandType.StoredProcedure;
                cmdd.Parameters.AddWithValue("@lastname", textBoxCustName.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmdd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAppt.DataSource = dt;

            }

        }
    }
}
