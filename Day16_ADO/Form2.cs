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
using System.Configuration;

namespace Day16_ADO
{
    public partial class Form2 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
       
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_DisplaySalary", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.AddWithValue("@dPayStartDate", DtFromDate.Value);
                   cmd.Parameters.AddWithValue("@dPayEndDate", DTToDate.Value);
                    //if (con.State == ConnectionState.Closed)
                    //{
                    //    con.Open();
                    //}
                    //cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridSalary.DataSource = dt;
                    
                }
             }
            //MessageBox.Show("Display!!");
        }
     }
}

