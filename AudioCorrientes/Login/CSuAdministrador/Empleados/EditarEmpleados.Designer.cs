﻿namespace Login.CSuAdministrador.Empleados
{
    partial class EditarEmpleados
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
            this.btnVerPass = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnSalirMenuPrincipal = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnVerPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerPass
            // 
            this.btnVerPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPass.Image = global::Login.Properties.Resources.mostrar_contrasena;
            this.btnVerPass.Location = new System.Drawing.Point(20, 211);
            this.btnVerPass.Name = "btnVerPass";
            this.btnVerPass.Size = new System.Drawing.Size(44, 36);
            this.btnVerPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerPass.TabIndex = 57;
            this.btnVerPass.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(320, 288);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(161, 20);
            this.txtDireccion.TabIndex = 54;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(320, 227);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(161, 20);
            this.txtTel.TabIndex = 53;
            // 
            // btnSalirMenuPrincipal
            // 
            this.btnSalirMenuPrincipal.Location = new System.Drawing.Point(320, 460);
            this.btnSalirMenuPrincipal.Name = "btnSalirMenuPrincipal";
            this.btnSalirMenuPrincipal.Size = new System.Drawing.Size(161, 44);
            this.btnSalirMenuPrincipal.TabIndex = 52;
            this.btnSalirMenuPrincipal.Text = "Salir";
            this.btnSalirMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Location = new System.Drawing.Point(90, 460);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(161, 44);
            this.btnEditarEmpleado.TabIndex = 51;
            this.btnEditarEmpleado.Text = "Editar";
            this.btnEditarEmpleado.UseVisualStyleBackColor = true;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Id Rol";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Guitarras Electricas",
            "Guitarras Acusticas",
            "Baterias",
            "Bajos",
            "Amplificadores"});
            this.comboBoxRol.Location = new System.Drawing.Point(320, 168);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(161, 21);
            this.comboBoxRol.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(90, 345);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 20);
            this.txtApellido.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 288);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 43;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 20);
            this.txtPassword.TabIndex = 42;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(90, 168);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(161, 20);
            this.txtDni.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Editar Empleado";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 540);
            this.Controls.Add(this.btnVerPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnSalirMenuPrincipal);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Name = "EditarEmpleados";
            this.Text = "EditarEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.btnVerPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnVerPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnSalirMenuPrincipal;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}