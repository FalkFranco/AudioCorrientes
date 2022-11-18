using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design.GroupSort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DVentas
{
    public partial class Imprimir : DevExpress.XtraEditors.XtraForm
    {
        public Imprimir()
        {
            InitializeComponent();
        }

        public void ImprimirFactura()
        {
            Factura factura = new Factura();
            //foreach (DevExpress.XtraReports.Parameters p in factura.Parameters)
            //    p.Visible = false;
            documentViewer1.DocumentSource = factura;
            factura.CreateDocument();
        }
    }
}