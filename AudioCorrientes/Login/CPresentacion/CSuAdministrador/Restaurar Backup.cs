using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if (restaurarBackup())
            {
                MessageBox.Show("El Backup ha sido restaurado con exito!");
            }
            else
            {
                MessageBox.Show("Error al restaurar!");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLoc.Text = dlg.FileName;
                btnRestaurar.Enabled = true;
            }
        }


        public bool restaurarBackup()
        {
            SqlCommand cmd;
            SqlCommand cmd1;
            SqlCommand cmd2;

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            conexion.Open();

            try
            {
                string str1= string.Format("ALTER DATABASE AudioCorrientes SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                cmd = new SqlCommand(str1, conexion);
                cmd.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE AudioCorrientes FROM DISK='"+txtLoc.Text+"' WITH REPLACE;";
                cmd1 = new SqlCommand(str2, conexion);
                cmd1.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE AudioCorrientes SET MULTI_USER");
                cmd2 = new SqlCommand(str3, conexion);
                cmd2.ExecuteNonQuery();

                conexion.Close();
                btnRestaurar.Enabled = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
                return false;
            }
            
        }
    }
}
