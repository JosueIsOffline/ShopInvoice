
namespace ShopInvoice
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.asusQty = new System.Windows.Forms.NumericUpDown();
            this.neveraQty = new System.Windows.Forms.NumericUpDown();
            this.tvQty = new System.Windows.Forms.NumericUpDown();
            this.monitorQty = new System.Windows.Forms.NumericUpDown();
            this.macQty = new System.Windows.Forms.NumericUpDown();
            this.ps5Qty = new System.Windows.Forms.NumericUpDown();
            this.prod6 = new System.Windows.Forms.CheckBox();
            this.prod5 = new System.Windows.Forms.CheckBox();
            this.prod4 = new System.Windows.Forms.CheckBox();
            this.prod3 = new System.Windows.Forms.CheckBox();
            this.prod2 = new System.Windows.Forms.CheckBox();
            this.prod1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtItbis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asusQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neveraQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ps5Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MoonShop";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.asusQty);
            this.groupBox1.Controls.Add(this.neveraQty);
            this.groupBox1.Controls.Add(this.tvQty);
            this.groupBox1.Controls.Add(this.monitorQty);
            this.groupBox1.Controls.Add(this.macQty);
            this.groupBox1.Controls.Add(this.ps5Qty);
            this.groupBox1.Controls.Add(this.prod6);
            this.groupBox1.Controls.Add(this.prod5);
            this.groupBox1.Controls.Add(this.prod4);
            this.groupBox1.Controls.Add(this.prod3);
            this.groupBox1.Controls.Add(this.prod2);
            this.groupBox1.Controls.Add(this.prod1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos Disponibles";
            // 
            // asusQty
            // 
            this.asusQty.Location = new System.Drawing.Point(456, 117);
            this.asusQty.Name = "asusQty";
            this.asusQty.Size = new System.Drawing.Size(50, 26);
            this.asusQty.TabIndex = 10;
            // 
            // neveraQty
            // 
            this.neveraQty.Location = new System.Drawing.Point(411, 76);
            this.neveraQty.Name = "neveraQty";
            this.neveraQty.Size = new System.Drawing.Size(50, 26);
            this.neveraQty.TabIndex = 9;
            // 
            // tvQty
            // 
            this.tvQty.Location = new System.Drawing.Point(401, 36);
            this.tvQty.Name = "tvQty";
            this.tvQty.Size = new System.Drawing.Size(50, 26);
            this.tvQty.TabIndex = 8;
            // 
            // monitorQty
            // 
            this.monitorQty.Location = new System.Drawing.Point(170, 117);
            this.monitorQty.Name = "monitorQty";
            this.monitorQty.Size = new System.Drawing.Size(50, 26);
            this.monitorQty.TabIndex = 7;
            // 
            // macQty
            // 
            this.macQty.Location = new System.Drawing.Point(170, 76);
            this.macQty.Name = "macQty";
            this.macQty.Size = new System.Drawing.Size(50, 26);
            this.macQty.TabIndex = 6;
            // 
            // ps5Qty
            // 
            this.ps5Qty.Location = new System.Drawing.Point(97, 35);
            this.ps5Qty.Name = "ps5Qty";
            this.ps5Qty.Size = new System.Drawing.Size(50, 26);
            this.ps5Qty.TabIndex = 2;
            this.ps5Qty.Tag = "";
            // 
            // prod6
            // 
            this.prod6.AutoSize = true;
            this.prod6.Location = new System.Drawing.Point(292, 117);
            this.prod6.Name = "prod6";
            this.prod6.Size = new System.Drawing.Size(167, 24);
            this.prod6.TabIndex = 5;
            this.prod6.Text = "Laptop Asus Rog";
            this.prod6.UseVisualStyleBackColor = true;
            this.prod6.CheckedChanged += new System.EventHandler(this.prod6_CheckedChanged);
            // 
            // prod5
            // 
            this.prod5.AutoSize = true;
            this.prod5.Location = new System.Drawing.Point(292, 78);
            this.prod5.Name = "prod5";
            this.prod5.Size = new System.Drawing.Size(113, 24);
            this.prod5.TabIndex = 4;
            this.prod5.Text = "Nevera LG";
            this.prod5.UseVisualStyleBackColor = true;
            this.prod5.CheckedChanged += new System.EventHandler(this.prod5_CheckedChanged);
            // 
            // prod4
            // 
            this.prod4.AutoSize = true;
            this.prod4.Location = new System.Drawing.Point(292, 37);
            this.prod4.Name = "prod4";
            this.prod4.Size = new System.Drawing.Size(103, 24);
            this.prod4.TabIndex = 3;
            this.prod4.Text = "Smart TV";
            this.prod4.UseVisualStyleBackColor = true;
            this.prod4.CheckedChanged += new System.EventHandler(this.prod4_CheckedChanged);
            // 
            // prod3
            // 
            this.prod3.AutoSize = true;
            this.prod3.Location = new System.Drawing.Point(31, 117);
            this.prod3.Name = "prod3";
            this.prod3.Size = new System.Drawing.Size(133, 24);
            this.prod3.TabIndex = 2;
            this.prod3.Text = "Monitor Asus";
            this.prod3.UseVisualStyleBackColor = true;
            this.prod3.CheckedChanged += new System.EventHandler(this.prod3_CheckedChanged);
            // 
            // prod2
            // 
            this.prod2.AutoSize = true;
            this.prod2.Location = new System.Drawing.Point(30, 78);
            this.prod2.Name = "prod2";
            this.prod2.Size = new System.Drawing.Size(134, 24);
            this.prod2.TabIndex = 1;
            this.prod2.Text = "MacBook Pro";
            this.prod2.UseVisualStyleBackColor = true;
            this.prod2.CheckedChanged += new System.EventHandler(this.prod2_CheckedChanged);
            // 
            // prod1
            // 
            this.prod1.AutoSize = true;
            this.prod1.Location = new System.Drawing.Point(30, 37);
            this.prod1.Name = "prod1";
            this.prod1.Size = new System.Drawing.Size(61, 24);
            this.prod1.TabIndex = 0;
            this.prod1.Text = "PS5";
            this.prod1.UseVisualStyleBackColor = true;
            this.prod1.CheckedChanged += new System.EventHandler(this.prod1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Articulo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(556, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(560, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pago:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(630, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Balance";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(616, 283);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 5;
            // 
            // txtPago
            // 
            this.txtPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(616, 418);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 21);
            this.txtPago.TabIndex = 6;
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(618, 487);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 21);
            this.txtBalance.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(602, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar al carrito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(602, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Imprimir Factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtItbis
            // 
            this.txtItbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItbis.Location = new System.Drawing.Point(616, 321);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(100, 21);
            this.txtItbis.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(556, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ITBIS:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(645, 386);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 21);
            this.txtSubtotal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(556, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sub Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(796, 536);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItbis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asusQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neveraQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ps5Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox prod1;
        private System.Windows.Forms.CheckBox prod3;
        private System.Windows.Forms.CheckBox prod2;
        private System.Windows.Forms.CheckBox prod4;
        private System.Windows.Forms.CheckBox prod5;
        private System.Windows.Forms.CheckBox prod6;
        private System.Windows.Forms.NumericUpDown ps5Qty;
        private System.Windows.Forms.NumericUpDown macQty;
        private System.Windows.Forms.NumericUpDown monitorQty;
        private System.Windows.Forms.NumericUpDown neveraQty;
        private System.Windows.Forms.NumericUpDown tvQty;
        private System.Windows.Forms.NumericUpDown asusQty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.TextBox txtItbis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
    }
}

