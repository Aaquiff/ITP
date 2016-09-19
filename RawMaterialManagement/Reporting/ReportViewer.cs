﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace RawMaterialManagement.Reporting
{
    public partial class ReportViewer : MetroForm
    {
        MySqlConnection con;
        public ReportViewer()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            this.raw_item_tabTableAdapter.Fill(this.DataSet1.raw_item_tab);
            
            this.reportViewer1.RefreshReport();
        }
    }
}