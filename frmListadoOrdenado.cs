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
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        clsArchivo objOrden = new clsArchivo();
        private void btnListar_Click(object sender, EventArgs e)
        {
            cmbCampo.SelectedIndex = -1;
            cmbModo.SelectedIndex = -1;

            switch (cmbModo.SelectedIndex)
            {
                case 0:
                    if (cmbCampo.SelectedIndex == 0)
                    {
                        objOrden.OrdenarPorCodigoAscendente();
                    }
                    else
                    {
                        objOrden.OrdenarPorCodigoDescendente();
                    }
                    break;
                case 1:
                    if (cmbCampo.SelectedIndex == 1)
                    {
                        objOrden.OrdenarPorNombreAscendente();
                    }
                    else
                    {
                        objOrden.OrdenarPorNombreDescendente();
                    }
                    break;
                case 2:
                    if (cmbCampo.SelectedIndex == 2)
                    {
                        objOrden.OrdenarPorLimiteAscendente();
                    }
                    else
                    {
                        objOrden.OrdenarPorLimiteDescendente();
                    }
                    break;
                case 3:
                    if (cmbCampo.SelectedIndex == 3)
                    {
                        objOrden.OrdenarPorDeudaAscendente();
                    }
                    else
                    {
                        objOrden.OrdenarPorDeudaDescendente();
                    }
                    break;
            }
            
            objOrden.Listar(dgvListado);            
        }
        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            cmbCampo.Items.Add("Código");
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Deuda");
            cmbCampo.Items.Add("Limite Crédito");

            cmbModo.Items.Add("Ascendente");
            cmbModo.Items.Add("Descendente");
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedIndex != -1)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }

        private void cmbModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModo.SelectedIndex != -1)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }
    }
}
