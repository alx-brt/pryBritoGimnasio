namespace pryBritoGimnasio
{
    partial class frmInscripcion
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
            gboDatosPersonales = new GroupBox();
            gboPlan = new GroupBox();
            gboFormaDePago = new GroupBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            chkEstudiante = new CheckBox();
            lblNombre = new Label();
            label2 = new Label();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            txtMeses = new TextBox();
            chkCasillero = new CheckBox();
            lblPlan = new Label();
            lblTurno = new Label();
            lblMeses = new Label();
            gboMetodo = new GroupBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            cboCuotas = new ComboBox();
            lblCuotas = new Label();
            gboDatosPersonales.SuspendLayout();
            gboPlan.SuspendLayout();
            gboFormaDePago.SuspendLayout();
            gboMetodo.SuspendLayout();
            SuspendLayout();
            // 
            // gboDatosPersonales
            // 
            gboDatosPersonales.Controls.Add(label2);
            gboDatosPersonales.Controls.Add(lblNombre);
            gboDatosPersonales.Controls.Add(chkEstudiante);
            gboDatosPersonales.Controls.Add(txtEdad);
            gboDatosPersonales.Controls.Add(txtNombre);
            gboDatosPersonales.Location = new Point(12, 12);
            gboDatosPersonales.Name = "gboDatosPersonales";
            gboDatosPersonales.Size = new Size(162, 151);
            gboDatosPersonales.TabIndex = 0;
            gboDatosPersonales.TabStop = false;
            gboDatosPersonales.Text = "Datos Personales";
            // 
            // gboPlan
            // 
            gboPlan.Controls.Add(lblMeses);
            gboPlan.Controls.Add(lblTurno);
            gboPlan.Controls.Add(lblPlan);
            gboPlan.Controls.Add(chkCasillero);
            gboPlan.Controls.Add(txtMeses);
            gboPlan.Controls.Add(cboTurno);
            gboPlan.Controls.Add(cboPlan);
            gboPlan.Location = new Point(180, 12);
            gboPlan.Name = "gboPlan";
            gboPlan.Size = new Size(162, 151);
            gboPlan.TabIndex = 1;
            gboPlan.TabStop = false;
            gboPlan.Text = "Plan";
            // 
            // gboFormaDePago
            // 
            gboFormaDePago.Controls.Add(lblCuotas);
            gboFormaDePago.Controls.Add(cboCuotas);
            gboFormaDePago.Controls.Add(gboMetodo);
            gboFormaDePago.Location = new Point(348, 12);
            gboFormaDePago.Name = "gboFormaDePago";
            gboFormaDePago.Size = new Size(162, 151);
            gboFormaDePago.TabIndex = 1;
            gboFormaDePago.TabStop = false;
            gboFormaDePago.Text = "Forma de Pago";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(71, 29);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(76, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(71, 68);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(49, 23);
            txtEdad.TabIndex = 2;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(39, 112);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 3;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 71);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Edad";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(74, 22);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(71, 23);
            cboPlan.TabIndex = 1;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(74, 51);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(71, 23);
            cboTurno.TabIndex = 2;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(74, 80);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(71, 23);
            txtMeses.TabIndex = 3;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(11, 115);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 4;
            chkCasillero.Text = "Casillero  ($3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(22, 25);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 4;
            lblPlan.Text = "Plan";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(22, 54);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 5;
            lblTurno.Text = "Turno";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(22, 83);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 6;
            lblMeses.Text = "Meses";
            // 
            // gboMetodo
            // 
            gboMetodo.Controls.Add(rbtTarjeta);
            gboMetodo.Controls.Add(rbtEfectivo);
            gboMetodo.Location = new Point(6, 25);
            gboMetodo.Name = "gboMetodo";
            gboMetodo.Size = new Size(150, 78);
            gboMetodo.TabIndex = 0;
            gboMetodo.TabStop = false;
            gboMetodo.Text = "Metodo";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(42, 21);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(42, 46);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(435, 171);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(348, 171);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(73, 113);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(64, 23);
            cboCuotas.TabIndex = 0;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(23, 116);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 2;
            lblCuotas.Text = "Cuotas";
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 206);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gboFormaDePago);
            Controls.Add(gboPlan);
            Controls.Add(gboDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo -- Inscripción";
            Load += frmInscripcion_Load;
            gboDatosPersonales.ResumeLayout(false);
            gboDatosPersonales.PerformLayout();
            gboPlan.ResumeLayout(false);
            gboPlan.PerformLayout();
            gboFormaDePago.ResumeLayout(false);
            gboFormaDePago.PerformLayout();
            gboMetodo.ResumeLayout(false);
            gboMetodo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboDatosPersonales;
        private GroupBox gboPlan;
        private GroupBox gboFormaDePago;
        private CheckBox chkEstudiante;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label label2;
        private Label lblNombre;
        private ComboBox cboPlan;
        private Label lblMeses;
        private Label lblTurno;
        private Label lblPlan;
        private CheckBox chkCasillero;
        private TextBox txtMeses;
        private ComboBox cboTurno;
        private GroupBox gboMetodo;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblCuotas;
        private ComboBox cboCuotas;
    }
}