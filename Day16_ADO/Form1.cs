﻿using System;
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
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboTestScore.Text = "---Select Range---";
            comboTestScore.Items.Add("41 to 50");
            comboTestScore.Items.Add("51 to 60");
            comboTestScore.Items.Add("61 to 70");
            comboTestScore.Items.Add("71 to 80");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select cCandidateCode,vFirstName,vLastName,cCollegeCode, siTestScore from ExternalCandidate", con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Ext");
                    DataView dv = ds.Tables["Ext"].DefaultView;
                    
                    if (comboTestScore.SelectedIndex == 0)
                    {
                        dv.RowFilter = "siTestScore > 41 AND siTestScore <= 50";
                    }
                    else if(comboTestScore.SelectedIndex == 1)
                    {
                        dv.RowFilter = "siTestScore > 51 AND siTestScore <= 60";
                    }
                    else if(comboTestScore.SelectedIndex == 2)
                    {
                        dv.RowFilter = "siTestScore > 61 AND siTestScore <= 70";
                    }
                    else
                    {
                        dv.RowFilter = "siTestScore > 71 AND siTestScore <= 80";
                    }
                    dv.Sort = "siTestScore DESC";

                    GridCandidates.DataSource = dv;
                }
            }
        }
    }
}
