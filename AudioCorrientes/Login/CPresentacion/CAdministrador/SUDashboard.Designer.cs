namespace Login.CSuAdministrador
{
    partial class SUDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCantProductos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCantProv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCantClientes = new System.Windows.Forms.Label();
            this.lbTotalVent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBajoStock = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTotVentas = new System.Windows.Forms.Label();
            this.lbTotVentasNro = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCategorias
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCategorias.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartCategorias.Legends.Add(legend1);
            this.chartCategorias.Location = new System.Drawing.Point(12, 107);
            this.chartCategorias.Name = "chartCategorias";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategorias.Series.Add(series1);
            this.chartCategorias.Size = new System.Drawing.Size(799, 326);
            this.chartCategorias.TabIndex = 0;
            this.chartCategorias.Text = "chart1";
            // 
            // chartTop5
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTop5.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartTop5.Legends.Add(legend2);
            this.chartTop5.Location = new System.Drawing.Point(817, 107);
            this.chartTop5.Name = "chartTop5";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTop5.Series.Add(series2);
            this.chartTop5.Size = new System.Drawing.Size(320, 595);
            this.chartTop5.TabIndex = 1;
            this.chartTop5.Text = "chart2";
            title1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Top 5 Productos";
            this.chartTop5.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbCantProductos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbCantProv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbCantClientes);
            this.panel1.Controls.Add(this.lbTotalVent);
            this.panel1.Location = new System.Drawing.Point(12, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 245);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Login.Properties.Resources.product;
            this.pictureBox6.Location = new System.Drawing.Point(6, 180);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(79, 54);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Login.Properties.Resources.delivery1;
            this.pictureBox5.Location = new System.Drawing.Point(6, 107);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(79, 54);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Login.Properties.Resources.evaluation;
            this.pictureBox4.Location = new System.Drawing.Point(6, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Totales";
            // 
            // lbCantProductos
            // 
            this.lbCantProductos.AutoSize = true;
            this.lbCantProductos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantProductos.Location = new System.Drawing.Point(87, 201);
            this.lbCantProductos.Name = "lbCantProductos";
            this.lbCantProductos.Size = new System.Drawing.Size(65, 30);
            this.lbCantProductos.TabIndex = 5;
            this.lbCantProductos.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad Productos";
            // 
            // lbCantProv
            // 
            this.lbCantProv.AutoSize = true;
            this.lbCantProv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantProv.Location = new System.Drawing.Point(86, 131);
            this.lbCantProv.Name = "lbCantProv";
            this.lbCantProv.Size = new System.Drawing.Size(65, 30);
            this.lbCantProv.TabIndex = 3;
            this.lbCantProv.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad Proveedores";
            // 
            // lbCantClientes
            // 
            this.lbCantClientes.AutoSize = true;
            this.lbCantClientes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantClientes.Location = new System.Drawing.Point(85, 57);
            this.lbCantClientes.Name = "lbCantClientes";
            this.lbCantClientes.Size = new System.Drawing.Size(65, 30);
            this.lbCantClientes.TabIndex = 1;
            this.lbCantClientes.Text = "1000";
            // 
            // lbTotalVent
            // 
            this.lbTotalVent.AutoSize = true;
            this.lbTotalVent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalVent.Location = new System.Drawing.Point(85, 36);
            this.lbTotalVent.Name = "lbTotalVent";
            this.lbTotalVent.Size = new System.Drawing.Size(153, 21);
            this.lbTotalVent.TabIndex = 0;
            this.lbTotalVent.Text = "Cantidad Clientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvBajoStock);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(300, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 245);
            this.panel2.TabIndex = 7;
            // 
            // dgvBajoStock
            // 
            this.dgvBajoStock.AllowUserToAddRows = false;
            this.dgvBajoStock.AllowUserToDeleteRows = false;
            this.dgvBajoStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajoStock.Location = new System.Drawing.Point(21, 34);
            this.dgvBajoStock.Name = "dgvBajoStock";
            this.dgvBajoStock.ReadOnly = true;
            this.dgvBajoStock.Size = new System.Drawing.Size(471, 200);
            this.dgvBajoStock.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, -5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Productos Stock Bajo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbTotVentas);
            this.panel3.Controls.Add(this.lbTotVentasNro);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 67);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.sales;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbTotVentas
            // 
            this.lbTotVentas.AutoSize = true;
            this.lbTotVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotVentas.Location = new System.Drawing.Point(107, 0);
            this.lbTotVentas.Name = "lbTotVentas";
            this.lbTotVentas.Size = new System.Drawing.Size(124, 21);
            this.lbTotVentas.TabIndex = 2;
            this.lbTotVentas.Text = "Ventas Totales";
            // 
            // lbTotVentasNro
            // 
            this.lbTotVentasNro.AutoSize = true;
            this.lbTotVentasNro.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotVentasNro.Location = new System.Drawing.Point(106, 21);
            this.lbTotVentasNro.Name = "lbTotVentasNro";
            this.lbTotVentasNro.Size = new System.Drawing.Size(65, 30);
            this.lbTotVentasNro.TabIndex = 1;
            this.lbTotVentasNro.Text = "1000";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(288, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 67);
            this.panel4.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.coins;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresos Brutos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "1000";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(716, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(421, 67);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Login.Properties.Resources.profit__1_;
            this.pictureBox3.Location = new System.Drawing.Point(7, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ganancia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "1000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SUDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 714);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartTop5);
            this.Controls.Add(this.chartCategorias);
            this.Name = "SUDashboard";
            this.Text = "MenuPrincipalSA";
            this.Load += new System.EventHandler(this.SUDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategorias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCantProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCantProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCantClientes;
        private System.Windows.Forms.Label lbTotalVent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBajoStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTotVentas;
        private System.Windows.Forms.Label lbTotVentasNro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button1;
    }
}