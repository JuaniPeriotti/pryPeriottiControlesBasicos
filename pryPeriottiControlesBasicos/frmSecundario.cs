using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPeriottiControlesBasicos
{
    public partial class frmSecundario : Form
    {
        public frmSecundario()
        {
            InitializeComponent();
        }

        private void optRojo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optRojo.Checked == true) 
            {
                lblCopiado.ForeColor = Color.Red;
                txtTexto.ForeColor = Color.Red;
            } 
            

            if (optAzul.Checked == true)
            {
                lblCopiado.ForeColor = Color.Blue;
                txtTexto.ForeColor = Color.Blue;
            }

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            lblCopiado.Text = txtTexto.Text;
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            lblCopiado.Text = "";
            if (chkMayonesa.Checked)
            {
                lblCopiado.Text += "Mayonesa ";
            }
            if (chkChimichurri.Checked)
            {
                lblCopiado.Text += "Chimichurri ";
            }
            if (chkKetchup.Checked)
            {
                lblCopiado.Text += "Ketchup";
            }
            

        }

        private void lblCopiado_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
