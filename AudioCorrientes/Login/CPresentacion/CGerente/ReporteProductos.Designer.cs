namespace Login.CGerente
{
    partial class ReporteProductos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProductoTitle = new System.Windows.Forms.Label();
            this.chartTop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.ChatTopMarcas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChatTopCat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatTopMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatTopCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbProductoTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 67);
            this.panel1.TabIndex = 3;
            // 
            // lbProductoTitle
            // 
            this.lbProductoTitle.AutoSize = true;
            this.lbProductoTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductoTitle.Location = new System.Drawing.Point(61, 24);
            this.lbProductoTitle.Name = "lbProductoTitle";
            this.lbProductoTitle.Size = new System.Drawing.Size(196, 25);
            this.lbProductoTitle.TabIndex = 0;
            this.lbProductoTitle.Text = "Reporte Productos";
            // 
            // chartTop5
            // 
            chartArea13.Name = "ChartArea1";
            this.chartTop5.ChartAreas.Add(chartArea13);
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend13.Name = "Legend1";
            this.chartTop5.Legends.Add(legend13);
            this.chartTop5.Location = new System.Drawing.Point(794, 202);
            this.chartTop5.Name = "chartTop5";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series13.IsValueShownAsLabel = true;
            series13.LabelForeColor = System.Drawing.Color.White;
            series13.Legend = "Legend1";
            series13.Name = "Productos";
            this.chartTop5.Series.Add(series13);
            this.chartTop5.Size = new System.Drawing.Size(320, 507);
            this.chartTop5.TabIndex = 5;
            this.chartTop5.Text = "chart2";
            title13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title13.Name = "Title1";
            title13.Text = "Top 5 Productos";
            this.chartTop5.Titles.Add(title13);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(303, 97);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(107, 23);
            this.btnCustom.TabIndex = 26;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnAño
            // 
            this.btnAño.Location = new System.Drawing.Point(168, 136);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(107, 23);
            this.btnAño.TabIndex = 25;
            this.btnAño.Text = "Este Año";
            this.btnAño.UseVisualStyleBackColor = true;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(36, 136);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(107, 23);
            this.btnMes.TabIndex = 24;
            this.btnMes.Text = "Este Mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.Location = new System.Drawing.Point(168, 97);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(107, 23);
            this.btnSemana.TabIndex = 23;
            this.btnSemana.Text = "Ultimos 7 días";
            this.btnSemana.UseVisualStyleBackColor = true;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(36, 97);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(107, 23);
            this.btnHoy.TabIndex = 22;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(541, 135);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 19;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(541, 100);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 18;
            // 
            // ChatTopMarcas
            // 
            chartArea14.Name = "ChartArea1";
            this.ChatTopMarcas.ChartAreas.Add(chartArea14);
            legend14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend14.Name = "Legend1";
            this.ChatTopMarcas.Legends.Add(legend14);
            this.ChatTopMarcas.Location = new System.Drawing.Point(421, 202);
            this.ChatTopMarcas.Name = "ChatTopMarcas";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.IsValueShownAsLabel = true;
            series14.LabelForeColor = System.Drawing.Color.White;
            series14.Legend = "Legend1";
            series14.Name = "Marcas";
            this.ChatTopMarcas.Series.Add(series14);
            this.ChatTopMarcas.Size = new System.Drawing.Size(320, 507);
            this.ChatTopMarcas.TabIndex = 27;
            this.ChatTopMarcas.Text = "chart2";
            title14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title14.Name = "Title1";
            title14.Text = "Top 5 Marcas";
            this.ChatTopMarcas.Titles.Add(title14);
            // 
            // ChatTopCat
            // 
            chartArea15.Name = "ChartArea1";
            this.ChatTopCat.ChartAreas.Add(chartArea15);
            legend15.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend15.Name = "Legend1";
            this.ChatTopCat.Legends.Add(legend15);
            this.ChatTopCat.Location = new System.Drawing.Point(36, 202);
            this.ChatTopCat.Name = "ChatTopCat";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series15.IsValueShownAsLabel = true;
            series15.LabelForeColor = System.Drawing.Color.White;
            series15.Legend = "Legend1";
            series15.Name = "Categorias";
            this.ChatTopCat.Series.Add(series15);
            this.ChatTopCat.Size = new System.Drawing.Size(320, 507);
            this.ChatTopCat.TabIndex = 28;
            this.ChatTopCat.Text = "chart2";
            title15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title15.Name = "Title1";
            title15.Text = "Top 5 Categorias";
            this.ChatTopCat.Titles.Add(title15);
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 721);
            this.Controls.Add(this.ChatTopCat);
            this.Controls.Add(this.ChatTopMarcas);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnAño);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnSemana);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.chartTop5);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteProductos";
            this.Text = "ReporteProductos";
            this.Load += new System.EventHandler(this.ReporteProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatTopMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatTopCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbProductoTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChatTopMarcas;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChatTopCat;
    }
}