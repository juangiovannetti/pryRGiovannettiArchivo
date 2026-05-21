using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRGiovannettiArchivo
{
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            x.ListarDeudores(dgvClientesDeudores);
            lblCantidadClientes.Text = x.ClientesDeudores().ToString();
            lblTotal.Text = x.DeudaClientes().ToString();
            lblPromedio.Text = x.PromedioDeuda().ToString();
        }
    }
}
