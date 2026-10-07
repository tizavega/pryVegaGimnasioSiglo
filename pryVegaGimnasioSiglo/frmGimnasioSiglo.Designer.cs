namespace pryVegaGimnasioSiglo
{
    partial class frmGimnasioSiglo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGimnasioSiglo));
            btnCalcular = new Button();
            tabControl1 = new TabControl();
            tpRegistrarse = new TabPage();
            cmoTurno = new ComboBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            chkEstudiante = new CheckBox();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            lblTurno = new Label();
            tbPago = new TabPage();
            gpbMedioPago = new GroupBox();
            lblMeses = new Label();
            txtMeses = new TextBox();
            chkCasillero = new CheckBox();
            cboCuotas = new ComboBox();
            lblPago = new Label();
            txtCuotas = new Label();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            btnLimpiar = new Button();
            tabControl1.SuspendLayout();
            tpRegistrarse.SuspendLayout();
            tbPago.SuspendLayout();
            gpbMedioPago.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(201, 274);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(78, 25);
            btnCalcular.TabIndex = 24;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpRegistrarse);
            tabControl1.Controls.Add(tbPago);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(277, 260);
            tabControl1.TabIndex = 0;
            // 
            // tpRegistrarse
            // 
            tpRegistrarse.Controls.Add(cmoTurno);
            tpRegistrarse.Controls.Add(lblNombre);
            tpRegistrarse.Controls.Add(txtNombre);
            tpRegistrarse.Controls.Add(lblEdad);
            tpRegistrarse.Controls.Add(txtEdad);
            tpRegistrarse.Controls.Add(chkEstudiante);
            tpRegistrarse.Controls.Add(lblPlan);
            tpRegistrarse.Controls.Add(cboPlan);
            tpRegistrarse.Controls.Add(lblTurno);
            tpRegistrarse.Location = new Point(4, 24);
            tpRegistrarse.Name = "tpRegistrarse";
            tpRegistrarse.Padding = new Padding(3);
            tpRegistrarse.Size = new Size(269, 232);
            tpRegistrarse.TabIndex = 0;
            tpRegistrarse.Text = "Registrarse";
            tpRegistrarse.UseVisualStyleBackColor = true;
            // 
            // cmoTurno
            // 
            cmoTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmoTurno.FormattingEnabled = true;
            cmoTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cmoTurno.Location = new Point(93, 149);
            cmoTurno.Name = "cmoTurno";
            cmoTurno.Size = new Size(109, 23);
            cmoTurno.TabIndex = 10;
            cmoTurno.SelectedIndexChanged += cmoTurno_SelectedIndexChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(74, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(21, 56);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(93, 53);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(74, 23);
            txtEdad.TabIndex = 5;
            txtEdad.TextChanged += txtEdad_TextChanged;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(21, 82);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 6;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(21, 117);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 7;
            lblPlan.Text = "Plan";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natación" });
            cboPlan.Location = new Point(93, 114);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(109, 23);
            cboPlan.TabIndex = 8;
            cboPlan.SelectedIndexChanged += cboPlan_SelectedIndexChanged;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(21, 152);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 9;
            lblTurno.Text = "Turno";
            // 
            // tbPago
            // 
            tbPago.Controls.Add(gpbMedioPago);
            tbPago.Location = new Point(4, 24);
            tbPago.Name = "tbPago";
            tbPago.Padding = new Padding(3);
            tbPago.Size = new Size(269, 232);
            tbPago.TabIndex = 1;
            tbPago.Text = "Pago";
            tbPago.UseVisualStyleBackColor = true;
            // 
            // gpbMedioPago
            // 
            gpbMedioPago.Controls.Add(lblMeses);
            gpbMedioPago.Controls.Add(txtMeses);
            gpbMedioPago.Controls.Add(chkCasillero);
            gpbMedioPago.Controls.Add(cboCuotas);
            gpbMedioPago.Controls.Add(lblPago);
            gpbMedioPago.Controls.Add(txtCuotas);
            gpbMedioPago.Controls.Add(rbtEfectivo);
            gpbMedioPago.Controls.Add(rbtTarjeta);
            gpbMedioPago.Location = new Point(6, 4);
            gpbMedioPago.Name = "gpbMedioPago";
            gpbMedioPago.Size = new Size(257, 222);
            gpbMedioPago.TabIndex = 23;
            gpbMedioPago.TabStop = false;
            gpbMedioPago.Text = "Medios de Pago";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(20, 32);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 11;
            lblMeses.Text = "Meses";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(92, 29);
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(75, 23);
            txtMeses.TabIndex = 12;
            txtMeses.TextChanged += txtMeses_TextChanged;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(20, 67);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(139, 19);
            chkCasillero.TabIndex = 14;
            chkCasillero.Text = "Casillero ($3000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "Un Pago", "3 Meses", "6 Meses" });
            cboCuotas.Location = new Point(92, 130);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(76, 23);
            cboCuotas.TabIndex = 19;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(20, 102);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(34, 15);
            lblPago.TabIndex = 15;
            lblPago.Text = "Pago";
            // 
            // txtCuotas
            // 
            txtCuotas.AutoSize = true;
            txtCuotas.Location = new Point(20, 133);
            txtCuotas.Name = "txtCuotas";
            txtCuotas.Size = new Size(44, 15);
            txtCuotas.TabIndex = 18;
            txtCuotas.Text = "Cuotas";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Checked = true;
            rbtEfectivo.Location = new Point(98, 101);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 16;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(185, 102);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 17;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(111, 274);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(78, 25);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmGimnasioSiglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 318);
            Controls.Add(btnCalcular);
            Controls.Add(tabControl1);
            Controls.Add(btnLimpiar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmGimnasioSiglo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo ";
            Load += frmGimnasioSiglo_Load;
            tabControl1.ResumeLayout(false);
            tpRegistrarse.ResumeLayout(false);
            tpRegistrarse.PerformLayout();
            tbPago.ResumeLayout(false);
            gpbMedioPago.ResumeLayout(false);
            gpbMedioPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalcular;
        private TabControl tabControl1;
        private TabPage tpRegistrarse;
        private ComboBox cmoTurno;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEdad;
        private TextBox txtEdad;
        private CheckBox chkEstudiante;
        private Label lblPlan;
        private ComboBox cboPlan;
        private Label lblTurno;
        private TabPage tbPago;
        private GroupBox gpbMedioPago;
        private Label lblMeses;
        private TextBox txtMeses;
        private CheckBox chkCasillero;
        private ComboBox cboCuotas;
        private Label lblPago;
        private Label txtCuotas;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private Button btnLimpiar;
    }
}