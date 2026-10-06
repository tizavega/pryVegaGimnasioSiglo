using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryVegaGimnasioSiglo
{
    public partial class frmGimnasioSiglo : Form
    {
        public frmGimnasioSiglo()
        {
            InitializeComponent();
        }
        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Clear();
            cboCuotas.Items.Clear();
            cboPlan.Items.Clear();
            cmoTurno.Items.Clear();
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            txtNombre.Focus();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();    
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
