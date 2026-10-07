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

        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m;
        private const int EDAD_MINIMA = 14;

        private decimal PrecioMensual = 0m;
        decimal PorcentajeDescuento = 0m;
        decimal PorcentajeAjustePago = 0m;

        public frmGimnasioSiglo()
        {
            InitializeComponent();
        }
        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = 0;
            cmoTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;

            txtNombre.Focus();


        }
        public struct SOCIO
        {
            public string Nombre;
            public int Edad;
            public string Categoria;
            public string Plan;
            public string Horario;
            public int Meses;
            public string FormaPago;
            public decimal Total;
            public decimal ValorCuota;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Edad, Meses;
            string Nombre;
            decimal Subtotal = 0m;
            decimal Total = 0m;
            decimal ValorCuota = 0m;
            if (string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtMeses.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos numéricos.");
                return;
            }


            Edad = int.Parse(txtEdad.Text);
            Meses = int.Parse(txtMeses.Text);



            string planElegido = cboPlan.SelectedItem.ToString();

            switch (planElegido)
            {
                case "Musculacion":
                    PrecioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    PrecioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    PrecioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("Plan inválido.");
                    return;
            }


            string horarioTurno = "";

            switch (cmoTurno.SelectedIndex)
            {
                case 0:
                    horarioTurno = "Mañana";
                    break;
                case 1:
                    horarioTurno = "Tarde";
                    break;
                case 2:
                    horarioTurno = "Noche";
                    break;

            }
            if (Edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad mínima para registrarse es de 14 años.");
                return;
            }
            if (Meses < 1 || Meses > 12)
            {
                MessageBox.Show("El número de meses debe estar entre 1 y 12.");
                return;
            }
            if (chkCasillero.Checked) PrecioMensual += PRECIO_CASILLERO;
            Subtotal = PrecioMensual * Meses;

            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
            decimal importeConDescuento = Subtotal - (Subtotal * PorcentajeDescuento / 100m);

            // Determinar categoría y forma de pago antes de crear el struct
            string categoria = (Edad < 18) ? "Menor" : "Mayor";
            string textoPago = string.Empty;

            if (rbtEfectivo.Checked)
            {
                // Efectivo tiene 10% de descuento
                Total = importeConDescuento - (importeConDescuento * 0.10m);
                ValorCuota = Total; // 1 sola cuota por ser efectivo
                textoPago = "Efectivo";
            }
            else
            {
                int cuotas = int.Parse(cboCuotas.Text);

                decimal recargo = 0m;
                if (cuotas == 3)
                {
                    recargo = 0.10m; // +10%
                }
                else if (cuotas == 6)
                {
                    recargo = 0.20m; // +20%
                }

                Total = importeConDescuento + (importeConDescuento * recargo);
                ValorCuota = Total / cuotas;
                textoPago = $"Tarjeta en {cuotas} cuotas";
            }

            SOCIO unSocio;
            unSocio.Nombre = txtNombre.Text;
            unSocio.Edad = Edad;
            unSocio.Categoria = categoria;
            unSocio.Plan = planElegido;
            unSocio.Horario = horarioTurno;
            unSocio.Meses = Meses;
            unSocio.FormaPago = textoPago;
            unSocio.Total = Total;
            unSocio.ValorCuota = ValorCuota;

            string mensaje = $" DETALLE DE INSCRIPCIÓN " +
                 $"  Nombre: {unSocio.Nombre}  " +
                 $"  Edad: {unSocio.Edad} ({unSocio.Categoria})  " +
                 $"  Plan: {unSocio.Plan} - Turno: {unSocio.Horario}  " +
                 $"  Meses: {unSocio.Meses}  " +
                 $"  Forma de pago: {unSocio.FormaPago}  " +
                 $"  Total a pagar: {unSocio.Total.ToString()}  " +
                 $"  Valor de cuota: {unSocio.ValorCuota.ToString()}  ";
            MessageBox.Show(mensaje, "  Gimnasio Siglo - Resultado  "
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstadoInicial();
        }

        private void frmGimnasioSiglo_Load(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmoTurno_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}

