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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection oCon = new SqlConnection("Data Source=LAPTOP-EHB7IG9Q;Initial Catalog=MoonShop;Integrated Security=True");
        SqlCommand cmd1;
        SqlCommand cmd2;

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            double precio = 0;
            int cantidad;
            double total = 0;

            if (prod1.Checked)
            {
                nombre = "PS5";
                cantidad = Convert.ToInt32(ps5Qty.Value.ToString());
                precio = 30000.00;
                total = cantidad * precio;
                this.dataGridView1.Rows.Add(nombre, precio, cantidad, total);
            }

            if (prod2.Checked)
            {
                nombre = "MacBook Pro";
                cantidad = Convert.ToInt32(macQty.Value.ToString());
                precio = 167841.65;
                total = cantidad * precio;
                this.dataGridView1.Rows.Add(nombre, precio, cantidad, total);
            }

            if (prod3.Checked)
            {
                nombre = "Monitor Asus";
                cantidad = Convert.ToInt32(monitorQty.Value.ToString());
                precio = 17034.50;
                total = cantidad * precio;
                this.dataGridView1.Rows.Add(nombre, precio, cantidad, total);
            }

            if (prod4.Checked)
            {
                nombre = "Smart TV";
                cantidad = Convert.ToInt32(tvQty.Value.ToString());
                precio = 7000.00;
                total = cantidad * precio;
                this.dataGridView1.Rows.Add(nombre, precio, cantidad, total);
            }

            if (prod5.Checked)
            {
                nombre = "Nevera LG";
                cantidad = Convert.ToInt32(neveraQty.Value.ToString());
                precio = 60000.00;
                total = cantidad * precio;
                this.dataGridView1.Rows.Add(nombre, precio, cantidad, total);
            }

            if (prod6.Checked)
            {       
                nombre = "Laptop Asus Rog";
                cantidad = Convert.ToInt32(asusQty.Value.ToString());
                precio = 32000.00;
                total = cantidad * precio;
                this.dataGridView1.Rows.Add(nombre, precio, cantidad, total);
            }

            double suma = 0;
            for(int fila = 0;  fila < dataGridView1.Rows.Count; fila++)
            {
                suma = suma + Convert.ToDouble(dataGridView1.Rows[fila].Cells[3].Value);
            }

            txtTotal.Text = suma.ToString();

        }

        private void prod1_CheckedChanged(object sender, EventArgs e)
        {
            ps5Qty.Value = 1;
            if (prod1.Checked == false)
            {
                ps5Qty.Value = 0;
            }
        }

        private void prod2_CheckedChanged(object sender, EventArgs e)
        {
            macQty.Value = 1;
            if (prod2.Checked == false)
            {
                macQty.Value = 0;
            }
        }

        private void prod3_CheckedChanged(object sender, EventArgs e)
        {
            monitorQty.Value = 1;
            if (prod3.Checked == false)
            {
                monitorQty.Value = 0;
            }
        }

        private void prod4_CheckedChanged(object sender, EventArgs e)
        {
            tvQty.Value = 1;
            if (prod4.Checked == false)
            {
                tvQty.Value = 0;
            }
        }

        private void prod5_CheckedChanged(object sender, EventArgs e)
        {
            neveraQty.Value = 1;
            if (prod5.Checked == false)
            {
                neveraQty.Value = 0;
            }
        }

        private void prod6_CheckedChanged(object sender, EventArgs e)
        {
            asusQty.Value = 1;
            if (prod6.Checked == false)
            {
                asusQty.Value = 0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["eliminar"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);

                double suma = 0;
                for (int fila = 0; fila < dataGridView1.Rows.Count; fila++)
                {
                    suma = suma + Convert.ToDouble(dataGridView1.Rows[fila].Cells[3].Value);
                }

                txtTotal.Text = suma.ToString();

            }
        }

        // Guardar Datos
        public void GuardarVenta()
        {
            string total = txtTotal.Text;
            string pago = txtPago.Text;
            string bal = txtBalance.Text;
            string sql1;
            string sql2;

            sql1 = "insert into Ventas(SubTotal, Pago, Balance) values (@subtotal, @pago, @balance) select @@identity;";
            oCon.Open();

            cmd1 = new SqlCommand(sql1, oCon);
            cmd1.Parameters.AddWithValue("@subtotal", total);
            cmd1.Parameters.AddWithValue("@pago", pago);
            cmd1.Parameters.AddWithValue("@balance", bal);
            int id = Convert.ToInt32(cmd1.ExecuteScalar().ToString());



            string nombreProd;
            double precio = 0;
            int cantidad = 0;
            double _total = 0;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                nombreProd = dataGridView1.Rows[row].Cells[0].Value.ToString();
                precio = double.Parse(dataGridView1.Rows[row].Cells[1].Value.ToString());
                cantidad = int.Parse(dataGridView1.Rows[row].Cells[2].Value.ToString());
                _total = double.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                
                sql2 = "insert into ProductoVenta (IdVenta, NombreProd, Precio, Cantidad, Total) values (@idventa ,@nombreprod, @precio, @cantidad, @total);";
                cmd2 = new SqlCommand(sql2, oCon);
                cmd2.Parameters.AddWithValue("@idventa", id);
                cmd2.Parameters.AddWithValue("@nombreprod", nombreProd);
                cmd2.Parameters.AddWithValue("@precio", precio);
                cmd2.Parameters.AddWithValue("@cantidad", cantidad);
                cmd2.Parameters.AddWithValue("@total", _total);

                cmd2.ExecuteNonQuery();
            }

            MessageBox.Show("Pago Completado!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }







        private void button2_Click(object sender, EventArgs e)
        {
            double pago = Convert.ToDouble(txtPago.Text);
            double total = Convert.ToDouble(txtTotal.Text);
            double bal = pago - total;

            GuardarVenta();

            txtBalance.Text = bal.ToString();

           
        }
    }
}
