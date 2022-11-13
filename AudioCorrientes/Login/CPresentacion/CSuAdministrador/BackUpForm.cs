using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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
                        generarBackup();
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
            if (txtDest.Text == "")
            {
                
                ok = false;
            }
            
            return ok;
        }
        public void generarBackup()
        {
            SqlCommand cmd;

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("BACKUP DATABASE AudioCorrientes TO DISK = '"+txtDest.Text + "\\"+ "AudioCorrientes"+ "-"+ DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".bak'", conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            btnGenerarBackUp.Enabled = false;
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtDest.Text = dlg.SelectedPath;
                btnGenerarBackUp.Enabled = true;
            }
        }

    }
}

