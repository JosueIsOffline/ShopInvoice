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

namespace ShopInvoice
{
    public partial class Imprimir : Form
    {
        public Imprimir()
        {
            InitializeComponent();
        }
        SqlConnection oCon = new SqlConnection("Data Source=LAPTOP-EHB7IG9Q;Initial Catalog=MoonShop;Integrated Security=True");
        SqlCommand cmd1;
        SqlCommand cmd2;

        private int idventa;

        public int VentaId
        {
            get { return idventa; }
            set { idventa = value; }
        }




        private void Imprimir_Load(object sender, EventArgs e)
        {
            try
            {
                oCon.Open();
                DataTable dt = new DataTable();
                cmd1 = new SqlCommand($"select * from Ventas where IdVenta = '{VentaId}'", oCon);
                SqlDataAdapter dr = new SqlDataAdapter(cmd1);
                dr.Fill(dt);

                DataTable dt2 = new DataTable();
                cmd2 = new SqlCommand($"select * from ProductoVenta where IdVenta = '{VentaId}'", oCon);
                SqlDataAdapter dr2 = new SqlDataAdapter(cmd2);
                dr2.Fill(dt2);
                oCon.Close();

                

                CrystalReport1 cr1 = new CrystalReport1();
                cr1.Database.Tables["Ventas"].SetDataSource(dt);
                cr1.Database.Tables["ProductoVenta"].SetDataSource(dt2);
                this.crystalReportViewer1.ReportSource = cr1;
                cr1.PrintToPrinter(1,false, 0, 0);
                

            }
            catch (Exception)
            {

            } 
        }
    }
}
