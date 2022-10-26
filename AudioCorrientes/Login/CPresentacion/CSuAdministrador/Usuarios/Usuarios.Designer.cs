namespace Login.CSuAdministrador.Usuarios
{
    partial class Usuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProductoTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Activar = new System.Windows.Forms.DataGridViewImageColumn();
            this.chbNombre = new System.Windows.Forms.CheckBox();
            this.chbDni = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.chbNombreE = new System.Windows.Forms.CheckBox();
            this.chbDniE = new System.Windows.Forms.CheckBox();
            this.txtBuscarE = new System.Windows.Forms.TextBox();
            this.btnBuscarE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditarUsuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.EliminarUsuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // lbProductoTitle
            // 
            this.lbProductoTitle.AutoSize = true;
            this.lbProductoTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductoTitle.Location = new System.Drawing.Point(61, 24);
            this.lbProductoTitle.Name = "lbProductoTitle";
            this.lbProductoTitle.Size = new System.Drawing.Size(96, 25);
            this.lbProductoTitle.TabIndex = 0;
            this.lbProductoTitle.Text = "Usuarios";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 542);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEmpleados);
            this.tabPage1.Controls.Add(this.chbNombre);
            this.tabPage1.Controls.Add(this.chbDni);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Empleados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.Activar});
            this.dgvEmpleados.Location = new System.Drawing.Point(26, 101);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(1070, 377);
            this.dgvEmpleados.TabIndex = 14;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
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
            // Activar
            // 
            this.Activar.HeaderText = "Activar";
            this.Activar.Image = global::Login.Properties.Resources.editar25x25;
            this.Activar.Name = "Activar";
            this.Activar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chbNombre
            // 
            this.chbNombre.AutoSize = true;
            this.chbNombre.Location = new System.Drawing.Point(198, 17);
            this.chbNombre.Name = "chbNombre";
            this.chbNombre.Size = new System.Drawing.Size(63, 17);
            this.chbNombre.TabIndex = 12;
            this.chbNombre.Text = "Nombre";
            this.chbNombre.UseVisualStyleBackColor = true;
            this.chbNombre.Click += new System.EventHandler(this.chbNombre_Click);
            // 
            // chbDni
            // 
            this.chbDni.AutoSize = true;
            this.chbDni.Checked = true;
            this.chbDni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDni.Location = new System.Drawing.Point(132, 17);
            this.chbDni.Name = "chbDni";
            this.chbDni.Size = new System.Drawing.Size(45, 17);
            this.chbDni.TabIndex = 11;
            this.chbDni.Text = "DNI";
            this.chbDni.UseVisualStyleBackColor = true;
            this.chbDni.Click += new System.EventHandler(this.chbDni_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(26, 57);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(848, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(891, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Usuario por:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvUsuarios);
            this.tabPage2.Controls.Add(this.chbNombreE);
            this.tabPage2.Controls.Add(this.chbDniE);
            this.tabPage2.Controls.Add(this.txtBuscarE);
            this.tabPage2.Controls.Add(this.btnBuscarE);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 516);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Listado Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarUsuario,
            this.EliminarUsuario});
            this.dgvUsuarios.Location = new System.Drawing.Point(26, 98);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(1059, 394);
            this.dgvUsuarios.TabIndex = 15;
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
            // txtBuscarE
            // 
            this.txtBuscarE.Location = new System.Drawing.Point(26, 57);
            this.txtBuscarE.Name = "txtBuscarE";
            this.txtBuscarE.Size = new System.Drawing.Size(848, 20);
            this.txtBuscarE.TabIndex = 3;
            this.txtBuscarE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarE_KeyPress);
            // 
            // btnBuscarE
            // 
            this.btnBuscarE.Location = new System.Drawing.Point(891, 57);
            this.btnBuscarE.Name = "btnBuscarE";
            this.btnBuscarE.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarE.TabIndex = 2;
            this.btnBuscarE.Text = "Buscar";
            this.btnBuscarE.UseVisualStyleBackColor = true;
            this.btnBuscarE.Click += new System.EventHandler(this.btnBuscarE_Click);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Login.Properties.Resources.editar25x25;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Login.Properties.Resources.basura25x25;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Activar";
            this.dataGridViewImageColumn3.Image = global::Login.Properties.Resources.editar25x25;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 489;
            // 
            // EditarUsuario
            // 
            this.EditarUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditarUsuario.HeaderText = "Editar";
            this.EditarUsuario.Image = global::Login.Properties.Resources.editar25x25;
            this.EditarUsuario.Name = "EditarUsuario";
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EliminarUsuario.HeaderText = "Eliminar";
            this.EliminarUsuario.Image = global::Login.Properties.Resources.basura25x25;
            this.EliminarUsuario.Name = "EliminarUsuario";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 609);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbProductoTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chbNombre;
        private System.Windows.Forms.CheckBox chbDni;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chbNombreE;
        private System.Windows.Forms.CheckBox chbDniE;
        private System.Windows.Forms.TextBox txtBuscarE;
        private System.Windows.Forms.Button btnBuscarE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Activar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewImageColumn EditarUsuario;
        private System.Windows.Forms.DataGridViewImageColumn EliminarUsuario;
    }
}