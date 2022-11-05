namespace Login.CVendedor
{
    partial class Vender
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
            this.lbVentas = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNroFactura = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbNomVen = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.SeleccionarCliente = new System.Windows.Forms.DataGridViewImageColumn();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridViewDetalle = new System.Windows.Forms.DataGridView();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProductoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProdL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantProL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarFacturacion = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbVentas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 67);
            this.panel1.TabIndex = 17;
            // 
            // lbVentas
            // 
            this.lbVentas.AutoSize = true;
            this.lbVentas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentas.Location = new System.Drawing.Point(61, 24);
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.Size = new System.Drawing.Size(133, 25);
            this.lbVentas.TabIndex = 0;
            this.lbVentas.Text = "Facturacion";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 631);
            this.tabControl1.TabIndex = 58;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facturacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(976, 599);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbNroFactura);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbTipoFactura);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lbNomVen);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.dtpFechaActual);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 60);
            this.panel2.TabIndex = 54;
            // 
            // lbNroFactura
            // 
            this.lbNroFactura.AutoSize = true;
            this.lbNroFactura.Location = new System.Drawing.Point(89, 25);
            this.lbNroFactura.Name = "lbNroFactura";
            this.lbNroFactura.Size = new System.Drawing.Size(49, 13);
            this.lbNroFactura.TabIndex = 52;
            this.lbNroFactura.Text = "0000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Factura Nro:";
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Location = new System.Drawing.Point(799, 22);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(113, 21);
            this.cbTipoFactura.TabIndex = 50;
            this.cbTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cbTipoFactura_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(708, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Tipo de Factura:";
            // 
            // lbNomVen
            // 
            this.lbNomVen.AutoSize = true;
            this.lbNomVen.Location = new System.Drawing.Point(582, 25);
            this.lbNomVen.Name = "lbNomVen";
            this.lbNomVen.Size = new System.Drawing.Size(75, 13);
            this.lbNomVen.TabIndex = 48;
            this.lbNomVen.Text = "NomVendedor";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(519, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Vendedor:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(306, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "Fecha:";
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Enabled = false;
            this.dtpFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaActual.Location = new System.Drawing.Point(352, 22);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaActual.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtIdCliente);
            this.panel3.Controls.Add(this.dgvClientes);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.txtNombreCliente);
            this.panel3.Controls.Add(this.txtdni);
            this.panel3.Location = new System.Drawing.Point(3, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 122);
            this.panel3.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Id Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(107, 22);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(156, 20);
            this.txtIdCliente.TabIndex = 53;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarCliente});
            this.dgvClientes.Location = new System.Drawing.Point(288, 11);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(628, 103);
            this.dgvClientes.TabIndex = 52;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // SeleccionarCliente
            // 
            this.SeleccionarCliente.HeaderText = "Seleccionar";
            this.SeleccionarCliente.Image = global::Login.Properties.Resources.venta;
            this.SeleccionarCliente.Name = "SeleccionarCliente";
            this.SeleccionarCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeleccionarCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Nombre Cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "DNI Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(106, 94);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(156, 20);
            this.txtNombreCliente.TabIndex = 41;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(107, 57);
            this.txtdni.Name = "txtdni";
            this.txtdni.ReadOnly = true;
            this.txtdni.Size = new System.Drawing.Size(156, 20);
            this.txtdni.TabIndex = 40;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbStock);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txtBuscarCliente);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.dgvProductos);
            this.panel7.Controls.Add(this.label24);
            this.panel7.Controls.Add(this.txtBuscarProd);
            this.panel7.Controls.Add(this.label25);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Controls.Add(this.txtCantidad);
            this.panel7.Controls.Add(this.txtPrecio);
            this.panel7.Controls.Add(this.txtNombre);
            this.panel7.Controls.Add(this.txtIdArticulo);
            this.panel7.Controls.Add(this.btnAgregarProducto);
            this.panel7.Location = new System.Drawing.Point(3, 197);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(954, 215);
            this.panel7.TabIndex = 57;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(51, 180);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(13, 13);
            this.lbStock.TabIndex = 57;
            this.lbStock.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Buscar Cliente por Apellido";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(621, 29);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(286, 20);
            this.txtBuscarCliente.TabIndex = 55;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(288, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "Buscar Producto por Nombre";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvProductos.Location = new System.Drawing.Point(291, 58);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(616, 143);
            this.dgvProductos.TabIndex = 51;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Image = global::Login.Properties.Resources.venta;
            this.Seleccionar.Name = "Seleccionar";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 138);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Cantidad";
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(291, 29);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(319, 20);
            this.txtBuscarProd.TabIndex = 53;
            this.txtBuscarProd.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 101);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Precio";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 23;
            this.label26.Text = "Nombre";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "IdArticulo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(106, 131);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(156, 20);
            this.txtCantidad.TabIndex = 21;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(106, 94);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(156, 20);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(106, 23);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.ReadOnly = true;
            this.txtIdArticulo.Size = new System.Drawing.Size(156, 20);
            this.txtIdArticulo.TabIndex = 18;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Location = new System.Drawing.Point(149, 166);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(113, 35);
            this.btnAgregarProducto.TabIndex = 27;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnCargarLista_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridViewDetalle);
            this.panel9.Controls.Add(this.btnCancelarFacturacion);
            this.panel9.Controls.Add(this.btnFacturar);
            this.panel9.Controls.Add(this.btnEliminarArticulo);
            this.panel9.Controls.Add(this.lbTotal);
            this.panel9.Controls.Add(this.label29);
            this.panel9.Controls.Add(this.label30);
            this.panel9.Location = new System.Drawing.Point(3, 418);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(976, 192);
            this.panel9.TabIndex = 59;
            // 
            // dataGridViewDetalle
            // 
            this.dataGridViewDetalle.AllowUserToAddRows = false;
            this.dataGridViewDetalle.AllowUserToDeleteRows = false;
            this.dataGridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.NombreProductoL,
            this.PrecioProdL,
            this.CantProL,
            this.SubTotL});
            this.dataGridViewDetalle.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewDetalle.Name = "dataGridViewDetalle";
            this.dataGridViewDetalle.ReadOnly = true;
            this.dataGridViewDetalle.Size = new System.Drawing.Size(716, 163);
            this.dataGridViewDetalle.TabIndex = 28;
            // 
            // idArticulo
            // 
            this.idArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idArticulo.HeaderText = "IdArticulo";
            this.idArticulo.Name = "idArticulo";
            // 
            // NombreProductoL
            // 
            this.NombreProductoL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProductoL.HeaderText = "Nombre";
            this.NombreProductoL.Name = "NombreProductoL";
            // 
            // PrecioProdL
            // 
            this.PrecioProdL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioProdL.HeaderText = "Precio";
            this.PrecioProdL.Name = "PrecioProdL";
            // 
            // CantProL
            // 
            this.CantProL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantProL.HeaderText = "Cantidad";
            this.CantProL.Name = "CantProL";
            // 
            // SubTotL
            // 
            this.SubTotL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotL.HeaderText = "Sub Total";
            this.SubTotL.Name = "SubTotL";
            // 
            // btnCancelarFacturacion
            // 
            this.btnCancelarFacturacion.BackColor = System.Drawing.Color.Red;
            this.btnCancelarFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFacturacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFacturacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarFacturacion.Location = new System.Drawing.Point(741, 130);
            this.btnCancelarFacturacion.Name = "btnCancelarFacturacion";
            this.btnCancelarFacturacion.Size = new System.Drawing.Size(225, 46);
            this.btnCancelarFacturacion.TabIndex = 57;
            this.btnCancelarFacturacion.Text = "Cancelar Facturación";
            this.btnCancelarFacturacion.UseVisualStyleBackColor = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFacturar.Location = new System.Drawing.Point(741, 78);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(225, 46);
            this.btnFacturar.TabIndex = 35;
            this.btnFacturar.Text = "Confirmar Facturación";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(765, 37);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(175, 35);
            this.btnEliminarArticulo.TabIndex = 54;
            this.btnEliminarArticulo.Text = "Eliminar Producto Seleccionado";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AccessibleDescription = "";
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbTotal.Location = new System.Drawing.Point(872, 9);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(54, 25);
            this.lbTotal.TabIndex = 37;
            this.lbTotal.Text = "0.00";
            // 
            // label29
            // 
            this.label29.AccessibleDescription = "";
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.DarkGreen;
            this.label29.Location = new System.Drawing.Point(852, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 25);
            this.label29.TabIndex = 38;
            this.label29.Text = "$";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(772, 13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 19);
            this.label30.TabIndex = 56;
            this.label30.Text = "Total:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 605);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Listado de Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 716);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Vender";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Vender_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVentas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNroFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbNomVen;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dataGridViewDetalle;
        private System.Windows.Forms.Button btnCancelarFacturacion;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridViewImageColumn Seleccionar;
        private System.Windows.Forms.DataGridViewImageColumn SeleccionarCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProductoL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProdL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantProL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotL;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label label3;
    }
}