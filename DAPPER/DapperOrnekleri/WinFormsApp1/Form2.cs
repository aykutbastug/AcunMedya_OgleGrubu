using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("CustomerID", txtMusteriNo.Text);
            dynamicParameters.Add("CompanyName", txtMusteriAdi.Text);
            dynamicParameters.Add("Phone", txtTelefon.Text);

            //MySqlConnection.MyConnection.Execute("sp_CustomerInsert", param: new { CustomerId = txtMusteriNo.Text, CompanyName = txtMusteriAdi.Text, Phone = txtTelefon.Text }, commandType: CommandType.StoredProcedure);
            UygulamaAyarlari.MyConnection.Execute("sp_CustomerInsert", param: dynamicParameters, commandType: CommandType.StoredProcedure);
            this.Close();
        }
    }
}
