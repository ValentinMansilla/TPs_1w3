using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaPantallas
{
    public partial class FrmDetalleFactura : Form
    {
        public int NroFactura { get; set; }
        public FrmDetalleFactura(int nroFactura)
        {
            InitializeComponent();
            NroFactura = nroFactura;
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
