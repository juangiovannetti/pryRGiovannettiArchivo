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
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
        }

        private void frmArchivo_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
        }
        private void comprobar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "") 
            {
                btnCargar.Enabled = true;
            }
            else 
            { 
                btnCargar.Enabled = false;
            }
                
        
        }

        clsArchivo arc = new clsArchivo();    
        private void btnCargar_Click(object sender, EventArgs e)
        {
            arc.Grabar(txtCodigo.Text ,txtNombre.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("Datos grabados");

            //Limpio los controles una ves se hayan cargado
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
            txtLimite.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }
    }
}
