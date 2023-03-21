using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_StoredProcedure
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());
            SqlCommand cmd = new SqlCommand("sp_CustomerInsert", sqlConnection);
            cmd.Parameters.AddWithValue("CustomerID", txtMusteriNo.Text);
            cmd.Parameters.AddWithValue("CompanyName", txtMusteriAdi.Text);
            cmd.Parameters.AddWithValue("Phone", txtTelefon.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            this.Close();
        }
    }
}
