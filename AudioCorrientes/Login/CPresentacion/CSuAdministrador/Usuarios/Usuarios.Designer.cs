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
            this.chbNombreE = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Activar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.chbNombre = new System.Windows.Forms.CheckBox();
            this.chbDni = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.EditarUsuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.EliminarUsuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.chbNombreU = new System.Windows.Forms.CheckBox();
            this.chbDniU = new System.Windows.Forms.CheckBox();
            this.txtBuscarU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEmpleadosEliminados = new System.Windows.Forms.DataGridView();
            this.ActivarEmpleado = new System.Windows.Forms.DataGridViewImageColumn();
            this.chbNombreEl = new System.Windows.Forms.CheckBox();
            this.chbDniE = new System.Windows.Forms.CheckBox();
            this.txtBuscarE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvUsuariosEliminados = new System.Windows.Forms.DataGridView();
            this.ActivarUsuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnActualizarUsuElim = new System.Windows.Forms.Button();
            this.chbNombreUE = new System.Windows.Forms.CheckBox();
            this.chbDniUE = new System.Windows.Forms.CheckBox();
            this.txtBuscarUE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.chbNombreE.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosEliminados)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosEliminados)).BeginInit();
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
            // chbNombreE
            // 
            this.chbNombreE.Controls.Add(this.tabPage1);
            this.chbNombreE.Controls.Add(this.tabPage2);
            this.chbNombreE.Controls.Add(this.tabPage3);
            this.chbNombreE.Controls.Add(this.tabPage4);
            this.chbNombreE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbNombreE.Location = new System.Drawing.Point(0, 67);
            this.chbNombreE.Name = "chbNombreE";
            this.chbNombreE.SelectedIndex = 0;
            this.chbNombreE.Size = new System.Drawing.Size(1126, 542);
            this.chbNombreE.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnActualizar);
            this.tabPage1.Controls.Add(this.dgvEmpleados);
            this.tabPage1.Controls.Add(this.chbNombre);
            this.tabPage1.Controls.Add(this.chbDni);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Empleados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1021, 57);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.Usuarios_Load);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Activar,
            this.Editar});
            this.dgvEmpleados.Location = new System.Drawing.Point(26, 101);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(1070, 377);
            this.dgvEmpleados.TabIndex = 14;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
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
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
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
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
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
            this.tabPage2.Controls.Add(this.btnActualizar2);
            this.tabPage2.Controls.Add(this.dgvUsuarios);
            this.tabPage2.Controls.Add(this.chbNombreU);
            this.tabPage2.Controls.Add(this.chbDniU);
            this.tabPage2.Controls.Add(this.txtBuscarU);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 516);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Listado Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.Location = new System.Drawing.Point(1010, 57);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar2.TabIndex = 18;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = true;
            this.btnActualizar2.Click += new System.EventHandler(this.Usuarios_Load);
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
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
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
            // chbNombreU
            // 
            this.chbNombreU.AutoSize = true;
            this.chbNombreU.Location = new System.Drawing.Point(213, 17);
            this.chbNombreU.Name = "chbNombreU";
            this.chbNombreU.Size = new System.Drawing.Size(63, 17);
            this.chbNombreU.TabIndex = 12;
            this.chbNombreU.Text = "Nombre";
            this.chbNombreU.UseVisualStyleBackColor = true;
            this.chbNombreU.Click += new System.EventHandler(this.chbNombreE_Click);
            // 
            // chbDniU
            // 
            this.chbDniU.AutoSize = true;
            this.chbDniU.Checked = true;
            this.chbDniU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDniU.Location = new System.Drawing.Point(147, 17);
            this.chbDniU.Name = "chbDniU";
            this.chbDniU.Size = new System.Drawing.Size(45, 17);
            this.chbDniU.TabIndex = 11;
            this.chbDniU.Text = "DNI";
            this.chbDniU.UseVisualStyleBackColor = true;
            this.chbDniU.Click += new System.EventHandler(this.chbDniE_Click);
            // 
            // txtBuscarU
            // 
            this.txtBuscarU.Location = new System.Drawing.Point(26, 57);
            this.txtBuscarU.Name = "txtBuscarU";
            this.txtBuscarU.Size = new System.Drawing.Size(848, 20);
            this.txtBuscarU.TabIndex = 3;
            this.txtBuscarU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarE_KeyPress);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dgvEmpleadosEliminados);
            this.tabPage3.Controls.Add(this.chbNombreEl);
            this.tabPage3.Controls.Add(this.chbDniE);
            this.tabPage3.Controls.Add(this.txtBuscarE);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1118, 516);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Empleados Eliminados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1015, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleadosEliminados
            // 
            this.dgvEmpleadosEliminados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleadosEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosEliminados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivarEmpleado});
            this.dgvEmpleadosEliminados.Location = new System.Drawing.Point(31, 102);
            this.dgvEmpleadosEliminados.Name = "dgvEmpleadosEliminados";
            this.dgvEmpleadosEliminados.Size = new System.Drawing.Size(1059, 394);
            this.dgvEmpleadosEliminados.TabIndex = 24;
            this.dgvEmpleadosEliminados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuElim_CellClick);
            // 
            // ActivarEmpleado
            // 
            this.ActivarEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActivarEmpleado.HeaderText = "Activar";
            this.ActivarEmpleado.Image = global::Login.Properties.Resources.editar25x25;
            this.ActivarEmpleado.Name = "ActivarEmpleado";
            // 
            // chbNombreEl
            // 
            this.chbNombreEl.AutoSize = true;
            this.chbNombreEl.Location = new System.Drawing.Point(218, 21);
            this.chbNombreEl.Name = "chbNombreEl";
            this.chbNombreEl.Size = new System.Drawing.Size(63, 17);
            this.chbNombreEl.TabIndex = 23;
            this.chbNombreEl.Text = "Nombre";
            this.chbNombreEl.UseVisualStyleBackColor = true;
            this.chbNombreEl.Click += new System.EventHandler(this.chbNombreEl_Click);
            // 
            // chbDniE
            // 
            this.chbDniE.AutoSize = true;
            this.chbDniE.Checked = true;
            this.chbDniE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDniE.Location = new System.Drawing.Point(152, 21);
            this.chbDniE.Name = "chbDniE";
            this.chbDniE.Size = new System.Drawing.Size(45, 17);
            this.chbDniE.TabIndex = 22;
            this.chbDniE.Text = "DNI";
            this.chbDniE.UseVisualStyleBackColor = true;
            this.chbDniE.Click += new System.EventHandler(this.chbDniE_Click_1);
            // 
            // txtBuscarE
            // 
            this.txtBuscarE.Location = new System.Drawing.Point(31, 61);
            this.txtBuscarE.Name = "txtBuscarE";
            this.txtBuscarE.Size = new System.Drawing.Size(848, 20);
            this.txtBuscarE.TabIndex = 21;
            this.txtBuscarE.TextChanged += new System.EventHandler(this.txtBuscarE_TextChanged_1);
            this.txtBuscarE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarE_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Buscar Empleado por:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvUsuariosEliminados);
            this.tabPage4.Controls.Add(this.btnActualizarUsuElim);
            this.tabPage4.Controls.Add(this.chbNombreUE);
            this.tabPage4.Controls.Add(this.chbDniUE);
            this.tabPage4.Controls.Add(this.txtBuscarUE);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1118, 516);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Usuarios Eliminados";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvUsuariosEliminados
            // 
            this.dgvUsuariosEliminados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosEliminados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivarUsuario});
            this.dgvUsuariosEliminados.Location = new System.Drawing.Point(31, 104);
            this.dgvUsuariosEliminados.Name = "dgvUsuariosEliminados";
            this.dgvUsuariosEliminados.Size = new System.Drawing.Size(1059, 394);
            this.dgvUsuariosEliminados.TabIndex = 26;
            this.dgvUsuariosEliminados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosEliminados_CellClick);
            // 
            // ActivarUsuario
            // 
            this.ActivarUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActivarUsuario.HeaderText = "ActivarUsuario";
            this.ActivarUsuario.Image = global::Login.Properties.Resources.basura25x25;
            this.ActivarUsuario.Name = "ActivarUsuario";
            // 
            // btnActualizarUsuElim
            // 
            this.btnActualizarUsuElim.Location = new System.Drawing.Point(1015, 61);
            this.btnActualizarUsuElim.Name = "btnActualizarUsuElim";
            this.btnActualizarUsuElim.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUsuElim.TabIndex = 25;
            this.btnActualizarUsuElim.Text = "Actualizar";
            this.btnActualizarUsuElim.UseVisualStyleBackColor = true;
            this.btnActualizarUsuElim.Click += new System.EventHandler(this.btnActualizarUsuElim_Click);
            // 
            // chbNombreUE
            // 
            this.chbNombreUE.AutoSize = true;
            this.chbNombreUE.Location = new System.Drawing.Point(218, 21);
            this.chbNombreUE.Name = "chbNombreUE";
            this.chbNombreUE.Size = new System.Drawing.Size(63, 17);
            this.chbNombreUE.TabIndex = 23;
            this.chbNombreUE.Text = "Nombre";
            this.chbNombreUE.UseVisualStyleBackColor = true;
            this.chbNombreUE.Click += new System.EventHandler(this.chbNombreUE_Click);
            // 
            // chbDniUE
            // 
            this.chbDniUE.AutoSize = true;
            this.chbDniUE.Checked = true;
            this.chbDniUE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDniUE.Location = new System.Drawing.Point(152, 21);
            this.chbDniUE.Name = "chbDniUE";
            this.chbDniUE.Size = new System.Drawing.Size(45, 17);
            this.chbDniUE.TabIndex = 22;
            this.chbDniUE.Text = "DNI";
            this.chbDniUE.UseVisualStyleBackColor = true;
            this.chbDniUE.Click += new System.EventHandler(this.chbDniUE_Click);
            // 
            // txtBuscarUE
            // 
            this.txtBuscarUE.Location = new System.Drawing.Point(31, 61);
            this.txtBuscarUE.Name = "txtBuscarUE";
            this.txtBuscarUE.Size = new System.Drawing.Size(848, 20);
            this.txtBuscarUE.TabIndex = 21;
            this.txtBuscarUE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarUE_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Buscar Empleado por:";
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
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 609);
            this.Controls.Add(this.chbNombreE);
            this.Controls.Add(this.panel1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chbNombreE.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosEliminados)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosEliminados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbProductoTitle;
        private System.Windows.Forms.TabControl chbNombreE;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chbNombre;
        private System.Windows.Forms.CheckBox chbDni;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chbNombreU;
        private System.Windows.Forms.CheckBox chbDniU;
        private System.Windows.Forms.TextBox txtBuscarU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewImageColumn EditarUsuario;
        private System.Windows.Forms.DataGridViewImageColumn EliminarUsuario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnActualizarUsuElim;
        private System.Windows.Forms.CheckBox chbNombreUE;
        private System.Windows.Forms.CheckBox chbDniUE;
        private System.Windows.Forms.TextBox txtBuscarUE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsuariosEliminados;
        private System.Windows.Forms.DataGridViewImageColumn ActivarUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEmpleadosEliminados;
        private System.Windows.Forms.CheckBox chbNombreEl;
        private System.Windows.Forms.CheckBox chbDniE;
        private System.Windows.Forms.TextBox txtBuscarE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn ActivarEmpleado;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Activar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}