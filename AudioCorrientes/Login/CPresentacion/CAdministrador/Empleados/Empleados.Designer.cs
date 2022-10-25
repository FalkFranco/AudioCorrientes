namespace Login.CSuAdministrador.Empleados
{
    partial class Empleados
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
            this.components = new System.ComponentModel.Container();
            this.lbProductoTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.chbNombreE = new System.Windows.Forms.CheckBox();
            this.chbDniE = new System.Windows.Forms.CheckBox();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductoTitle
            // 
            this.lbProductoTitle.AutoSize = true;
            this.lbProductoTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductoTitle.Location = new System.Drawing.Point(61, 24);
            this.lbProductoTitle.Name = "lbProductoTitle";
            this.lbProductoTitle.Size = new System.Drawing.Size(125, 25);
            this.lbProductoTitle.TabIndex = 0;
            this.lbProductoTitle.Text = "Empleados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbProductoTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 67);
            this.panel1.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 542);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.dgvEmpleados);
            this.tabPage2.Controls.Add(this.chbNombreE);
            this.tabPage2.Controls.Add(this.chbDniE);
            this.tabPage2.Controls.Add(this.btnAgregarE);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.btnBuscarE);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1115, 516);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Listado Empleados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(972, 57);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.Seleccionar});
            this.dgvEmpleados.Location = new System.Drawing.Point(26, 92);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(1070, 377);
            this.dgvEmpleados.TabIndex = 13;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Login.Properties.Resources.editar25x25;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Login.Properties.Resources.basura25x25;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 49;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Image = global::Login.Properties.Resources.carrito_de_compras;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chbNombreE
            // 
            this.chbNombreE.AutoSize = true;
            this.chbNombreE.Location = new System.Drawing.Point(213, 17);
            this.chbNombreE.Name = "chbNombreE";
            this.chbNombreE.Size = new System.Drawing.Size(63, 17);
            this.chbNombreE.TabIndex = 12;
            this.chbNombreE.Text = "Nombre";
            this.chbNombreE.UseVisualStyleBackColor = true;
            this.chbNombreE.Click += new System.EventHandler(this.chbNombreE_Click);
            // 
            // chbDniE
            // 
            this.chbDniE.AutoSize = true;
            this.chbDniE.Checked = true;
            this.chbDniE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDniE.Location = new System.Drawing.Point(147, 17);
            this.chbDniE.Name = "chbDniE";
            this.chbDniE.Size = new System.Drawing.Size(45, 17);
            this.chbDniE.TabIndex = 11;
            this.chbDniE.Text = "DNI";
            this.chbDniE.UseVisualStyleBackColor = true;
            this.chbDniE.Click += new System.EventHandler(this.chbDniE_Click);
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Location = new System.Drawing.Point(26, 475);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(123, 35);
            this.btnAgregarE.TabIndex = 4;
            this.btnAgregarE.Text = "Agregar Empleado";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(26, 57);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(848, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress_1);
            // 
            // btnBuscarE
            // 
            this.btnBuscarE.Location = new System.Drawing.Point(891, 57);
            this.btnBuscarE.Name = "btnBuscarE";
            this.btnBuscarE.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarE.TabIndex = 2;
            this.btnBuscarE.Text = "Buscar";
            this.btnBuscarE.UseVisualStyleBackColor = true;
            this.btnBuscarE.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buscar Empleado por:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 609);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbProductoTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chbNombreE;
        private System.Windows.Forms.CheckBox chbDniE;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscarE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Seleccionar;
        private System.Windows.Forms.Button btnActualizar;
    }
}