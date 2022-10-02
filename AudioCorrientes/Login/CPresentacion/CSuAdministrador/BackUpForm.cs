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
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void btnGenerarBackUp_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                var backupOk = false;

                // Displays the MessageBox.
                result = MessageBox.Show("¿Seguro que desea realizar un backup de la base de datos?", "Backup", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Funcion Backup
                    backupOk = true;
                    if (backupOk == true)
                    {
                        MessageBox.Show("Backup realizado con exito", "Backup Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }else
            {
                MessageBox.Show("Debe selaccionar los archivos para generar", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos()
        {
            bool ok = true;
            if (txtLoc.Text == "" || txtLoc.Text == "")
            {
                btnGenerarBackUp.Enabled = false;
                ok = false;
            }
            btnGenerarBackUp.Enabled = true;
            return ok;
        }

    }
}
