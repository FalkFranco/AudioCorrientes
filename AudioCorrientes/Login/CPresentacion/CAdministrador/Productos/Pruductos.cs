﻿using Login.CSuAdministrador.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CSuAdministrador
{
    public partial class Pruductos : Form
    {
        public Pruductos()
        {
            InitializeComponent();
        }
        //Eventos para abrir formularios
        private void button2_Click(object sender, EventArgs e)
        {
            AgregarProductos formAgregarProd = new AgregarProductos();
            formAgregarProd.ShowDialog();
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            AgregarCategoria formAddCat = new AgregarCategoria();
            formAddCat.ShowDialog();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarca formAddMarca = new AgregarMarca();
            formAddMarca.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProducto formEditarProducto = new EditarProducto();
            formEditarProducto.ShowDialog();
        }

        //Validaciones de Formularios
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                //Buscar
                if (chbId.Checked)
                {
                    MessageBox.Show("Buscando por Id");
                }
                else
                {
                    MessageBox.Show("Buscando por Nombre");
                }
            }

        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if(txtBuscar.Text == "")
            {
                ok = false;
                errorProviderBuscar.SetError(txtBuscar, "No puede estar vacio al realizar una busqueda");
            }
            if (txtBuscar.Text.Length <= 4)
            {
                ok = false;
                errorProviderBuscar.SetError(txtBuscar, "Ingrese mas de 4 caracteres");
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProviderBuscar.SetError(txtBuscar, "");
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chbId.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }


        private void chbId_Click(object sender, EventArgs e)
        {
            chbNombre.Checked = false;
            chbId.Checked = true;
        }

        private void chbNombre_Click(object sender, EventArgs e)
        {
            chbId.Checked = false;
            chbNombre.Checked = true;
        }

        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.ColumnIndex >= 0 && this.dgvProductos.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell cellBoton = this.dgvProductos.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

            }
        }


        //Listar Categorias
        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            BorrarMensajeProviderCM(txtBuscarC);
            if (ValidarCamposCM(txtBuscarC))
            {
                MessageBox.Show("Buscando Categoria");
            }
        }

        private bool ValidarCamposCM(TextBox textBox)
        {
            bool ok = true;
            if (textBox.Text == "")
            {
                ok = false;
                errorProviderBuscar.SetError(textBox, "No puede estar vacio");
            }
            if (textBox.Text.Length <= 4)
            {
                ok = false;
                errorProviderBuscar.SetError(textBox, "Ingrese mas de 4 caracteres");
            }
            return ok;
        }
        
        //Listar Marca
        private void BorrarMensajeProviderCM(TextBox textBox)
        {
            errorProviderBuscar.SetError(textBox, "");
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            BorrarMensajeProviderCM(txtBuscarM);
            if (ValidarCamposCM(txtBuscarM))
            {
                MessageBox.Show("Buscando Marca");
            }
        }
    }
}