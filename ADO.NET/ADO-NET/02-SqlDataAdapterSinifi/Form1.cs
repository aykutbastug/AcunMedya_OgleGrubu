using System.Data;
using System.Data.SqlClient;

namespace _02_SqlDataAdapterSinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "server=AYKUTBASTUG-ZEN; database=Northwind;Trusted_Connection=true;";
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[View_MusteriListesi]", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //comboBox1.DataSource = null;
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "CustomerID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show($"Müşteri Id = {comboBox1.SelectedValue}\nMüşteri Adı = {comboBox1.Text}");
                //--OrderId, OrderDate, ShippedDate, Freight, SiparişToplamTutar, ÜrünAdedi

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //SqlDataAdapter da = new SqlDataAdapter("select * from dbo.view_MusteriSiparisListesi where CustomerId='"+ comboBox1.SelectedValue + "'", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter("select * from dbo.view_MusteriSiparisListesi where CustomerId=@customerId", sqlConnection);
                da.SelectCommand.Parameters.AddWithValue("customerId", comboBox1.SelectedValue);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);


                gridViewOrders.DataSource = null;
                gridViewOrders.DataSource = dataTable;
                gridViewOrders.Columns[6].Visible = false;
            }
            catch {; }


            //ürün adı, miktarı, birim fiyatı, toplam
        }

        private void gridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            gridViewOrderDetails.DataSource = null;

            if (gridViewOrders.CurrentRow == null)
                return;

            SqlConnection cn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.view_SiparisDetaylari where OrderId=@orderId", cn);
            da.SelectCommand.Parameters.AddWithValue("orderId", gridViewOrders.CurrentRow.Cells[0].Value);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gridViewOrderDetails.DataSource = dt;

        }
    }
}