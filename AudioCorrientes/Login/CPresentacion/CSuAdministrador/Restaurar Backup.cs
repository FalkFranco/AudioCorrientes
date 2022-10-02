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
    public partial class Restaurar_Backup : Form
    {
        public Restaurar_Backup()
        {
            InitializeComponent();
        }
        

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                var backupOk = false;

                // Displays the MessageBox.
                result = MessageBox.Show("¿Seguro que desea realizar una restauracion del backup de la base de datos?", "Restauracion Backup", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Funcion Backup
                    backupOk = true;
                    if (backupOk == true)
                    {
                        MessageBox.Show("Restauración de Backup realizado con exito", "Restauración Backup Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe selaccionar un archivo a restaurar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool validarCampos()
        {
            bool ok = true;
            if (txtLoc.Text == "")
            {
                btnRestaurar.Enabled = false;
                ok = false;
            }
            btnRestaurar.Enabled = true;
            return ok;
        }

    }
}
