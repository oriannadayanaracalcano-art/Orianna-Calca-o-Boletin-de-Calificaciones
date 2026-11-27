namespace boletindecalificaciones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpDatosEstudiante = new GroupBox();
            rdbVespertina = new RadioButton();
            rdbMatutina = new RadioButton();
            IbITanda = new Label();
            txtEstudiante = new TextBox();
            lblNombre = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            grpRegistro = new GroupBox();
            btnRegistrar = new Button();
            chkAsistencia = new CheckBox();
            txtP4 = new TextBox();
            txtP3 = new TextBox();
            txtP2 = new TextBox();
            txtP1 = new TextBox();
            IbIP4 = new Label();
            IbIP3 = new Label();
            IbIP2 = new Label();
            IbIP1 = new Label();
            lblCalificaciones = new Label();
            cmbAsignatura = new ComboBox();
            lblAsignatura = new Label();
            btnResumen = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            grpBoletin = new GroupBox();
            lstBoletin = new ListBox();
            grpResumen = new GroupBox();
            lblEstadoGeneral = new Label();
            lblSituacion = new Label();
            lblCantRecuperacion = new Label();
            lblCantAprobadas = new Label();
            lblPromedio = new Label();
            lblCantReprobadas = new Label();
            lblRecuperacion = new Label();
            IbIAprobadas = new Label();
            lblPromedioGeneral = new Label();
            grpDatosEstudiante.SuspendLayout();
            grpRegistro.SuspendLayout();
            grpBoletin.SuspendLayout();
            grpResumen.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // grpDatosEstudiante
            // 
            grpDatosEstudiante.Controls.Add(rdbVespertina);
            grpDatosEstudiante.Controls.Add(rdbMatutina);
            grpDatosEstudiante.Controls.Add(IbITanda);
            grpDatosEstudiante.Controls.Add(txtEstudiante);
            grpDatosEstudiante.Controls.Add(lblNombre);
            grpDatosEstudiante.Location = new Point(12, 12);
            grpDatosEstudiante.Name = "grpDatosEstudiante";
            grpDatosEstudiante.Size = new Size(274, 125);
            grpDatosEstudiante.TabIndex = 0;
            grpDatosEstudiante.TabStop = false;
            grpDatosEstudiante.Text = "Datos del estudiante";
            // 
            // rdbVespertina
            // 
            rdbVespertina.AutoSize = true;
            rdbVespertina.Location = new Point(141, 65);
            rdbVespertina.Name = "rdbVespertina";
            rdbVespertina.Size = new Size(79, 19);
            rdbVespertina.TabIndex = 3;
            rdbVespertina.TabStop = true;
            rdbVespertina.Text = "Vespertina";
            rdbVespertina.UseVisualStyleBackColor = true;
            // 
            // rdbMatutina
            // 
            rdbMatutina.AutoSize = true;
            rdbMatutina.Location = new Point(57, 65);
            rdbMatutina.Name = "rdbMatutina";
            rdbMatutina.Size = new Size(73, 19);
            rdbMatutina.TabIndex = 1;
            rdbMatutina.TabStop = true;
            rdbMatutina.Text = "Matutina";
            rdbMatutina.UseVisualStyleBackColor = true;
            // 
            // IbITanda
            // 
            IbITanda.AutoSize = true;
            IbITanda.Location = new Point(7, 65);
            IbITanda.Name = "IbITanda";
            IbITanda.Size = new Size(44, 15);
            IbITanda.TabIndex = 2;
            IbITanda.Text = "Tanda :";
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(70, 28);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(165, 23);
            txtEstudiante.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(7, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre :";
            lblNombre.Click += lblNombre_Click;
            // 
            // grpRegistro
            // 
            grpRegistro.Controls.Add(btnRegistrar);
            grpRegistro.Controls.Add(chkAsistencia);
            grpRegistro.Controls.Add(txtP4);
            grpRegistro.Controls.Add(txtP3);
            grpRegistro.Controls.Add(txtP2);
            grpRegistro.Controls.Add(txtP1);
            grpRegistro.Controls.Add(IbIP4);
            grpRegistro.Controls.Add(IbIP3);
            grpRegistro.Controls.Add(IbIP2);
            grpRegistro.Controls.Add(IbIP1);
            grpRegistro.Controls.Add(lblCalificaciones);
            grpRegistro.Controls.Add(cmbAsignatura);
            grpRegistro.Controls.Add(lblAsignatura);
            grpRegistro.Location = new Point(17, 161);
            grpRegistro.Name = "grpRegistro";
            grpRegistro.Size = new Size(280, 234);
            grpRegistro.TabIndex = 1;
            grpRegistro.TabStop = false;
            grpRegistro.Text = "Registro de asignatura";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Cornsilk;
            btnRegistrar.Location = new Point(21, 183);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(194, 28);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar asignatura";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // chkAsistencia
            // 
            chkAsistencia.AutoSize = true;
            chkAsistencia.Location = new Point(7, 158);
            chkAsistencia.Name = "chkAsistencia";
            chkAsistencia.Size = new Size(237, 19);
            chkAsistencia.TabIndex = 2;
            chkAsistencia.Text = "Cumple con la asistencia mínima (80 %)";
            chkAsistencia.UseVisualStyleBackColor = true;
            // 
            // txtP4
            // 
            txtP4.Location = new Point(189, 119);
            txtP4.Name = "txtP4";
            txtP4.Size = new Size(41, 23);
            txtP4.TabIndex = 10;
            // 
            // txtP3
            // 
            txtP3.Location = new Point(120, 118);
            txtP3.Name = "txtP3";
            txtP3.Size = new Size(40, 23);
            txtP3.TabIndex = 9;
            // 
            // txtP2
            // 
            txtP2.Location = new Point(68, 118);
            txtP2.Name = "txtP2";
            txtP2.Size = new Size(35, 23);
            txtP2.TabIndex = 8;
            // 
            // txtP1
            // 
            txtP1.Location = new Point(14, 119);
            txtP1.Name = "txtP1";
            txtP1.Size = new Size(38, 23);
            txtP1.TabIndex = 7;
            // 
            // IbIP4
            // 
            IbIP4.AutoSize = true;
            IbIP4.Location = new Point(195, 100);
            IbIP4.Name = "IbIP4";
            IbIP4.Size = new Size(20, 15);
            IbIP4.TabIndex = 6;
            IbIP4.Text = "P4";
            // 
            // IbIP3
            // 
            IbIP3.AutoSize = true;
            IbIP3.Location = new Point(129, 100);
            IbIP3.Name = "IbIP3";
            IbIP3.Size = new Size(20, 15);
            IbIP3.TabIndex = 5;
            IbIP3.Text = "P3";
            // 
            // IbIP2
            // 
            IbIP2.AutoSize = true;
            IbIP2.Location = new Point(68, 100);
            IbIP2.Name = "IbIP2";
            IbIP2.Size = new Size(20, 15);
            IbIP2.TabIndex = 4;
            IbIP2.Text = "P2";
            // 
            // IbIP1
            // 
            IbIP1.AutoSize = true;
            IbIP1.Location = new Point(14, 101);
            IbIP1.Name = "IbIP1";
            IbIP1.Size = new Size(20, 15);
            IbIP1.TabIndex = 3;
            IbIP1.Text = "P1";
            // 
            // lblCalificaciones
            // 
            lblCalificaciones.AutoSize = true;
            lblCalificaciones.Location = new Point(8, 69);
            lblCalificaciones.Name = "lblCalificaciones";
            lblCalificaciones.Size = new Size(198, 15);
            lblCalificaciones.TabIndex = 2;
            lblCalificaciones.Text = "Calificaciones por período (0 a 100) :";
            lblCalificaciones.Click += label1_Click;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(83, 29);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(167, 23);
            cmbAsignatura.TabIndex = 1;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(7, 29);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(70, 15);
            lblAsignatura.TabIndex = 0;
            lblAsignatura.Text = "Asignatura :";
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(19, 413);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(242, 30);
            btnResumen.TabIndex = 2;
            btnResumen.Text = "Mostrar resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(286, 413);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(217, 30);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(529, 413);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(233, 28);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // grpBoletin
            // 
            grpBoletin.Controls.Add(lstBoletin);
            grpBoletin.Location = new Point(310, 24);
            grpBoletin.Name = "grpBoletin";
            grpBoletin.Size = new Size(425, 166);
            grpBoletin.TabIndex = 5;
            grpBoletin.TabStop = false;
            grpBoletin.Text = "Boletín del estudiante";
            // 
            // lstBoletin
            // 
            lstBoletin.FormattingEnabled = true;
            lstBoletin.Location = new Point(11, 26);
            lstBoletin.Name = "lstBoletin";
            lstBoletin.Size = new Size(393, 124);
            lstBoletin.TabIndex = 0;
            // 
            // grpResumen
            // 
            grpResumen.Controls.Add(lblEstadoGeneral);
            grpResumen.Controls.Add(lblSituacion);
            grpResumen.Controls.Add(lblCantRecuperacion);
            grpResumen.Controls.Add(lblCantAprobadas);
            grpResumen.Controls.Add(lblPromedio);
            grpResumen.Controls.Add(lblCantReprobadas);
            grpResumen.Controls.Add(lblRecuperacion);
            grpResumen.Controls.Add(IbIAprobadas);
            grpResumen.Controls.Add(lblPromedioGeneral);
            grpResumen.Location = new Point(313, 205);
            grpResumen.Name = "grpResumen";
            grpResumen.Size = new Size(422, 190);
            grpResumen.TabIndex = 6;
            grpResumen.TabStop = false;
            grpResumen.Text = "Resumen";
            // 
            // lblEstadoGeneral
            // 
            lblEstadoGeneral.AutoSize = true;
            lblEstadoGeneral.Location = new Point(91, 148);
            lblEstadoGeneral.Name = "lblEstadoGeneral";
            lblEstadoGeneral.Size = new Size(72, 15);
            lblEstadoGeneral.TabIndex = 9;
            lblEstadoGeneral.Text = "Sin Registrar";
            // 
            // lblSituacion
            // 
            lblSituacion.AutoSize = true;
            lblSituacion.Location = new Point(23, 148);
            lblSituacion.Name = "lblSituacion";
            lblSituacion.Size = new Size(62, 15);
            lblSituacion.TabIndex = 8;
            lblSituacion.Text = "Situacion :";
            // 
            // lblCantRecuperacion
            // 
            lblCantRecuperacion.AutoSize = true;
            lblCantRecuperacion.Location = new Point(148, 88);
            lblCantRecuperacion.Name = "lblCantRecuperacion";
            lblCantRecuperacion.Size = new Size(13, 15);
            lblCantRecuperacion.TabIndex = 6;
            lblCantRecuperacion.Text = "0";
            // 
            // lblCantAprobadas
            // 
            lblCantAprobadas.AutoSize = true;
            lblCantAprobadas.Location = new Point(149, 62);
            lblCantAprobadas.Name = "lblCantAprobadas";
            lblCantAprobadas.Size = new Size(13, 15);
            lblCantAprobadas.TabIndex = 5;
            lblCantAprobadas.Text = "0";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(150, 31);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(28, 15);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "0.00";
            // 
            // lblCantReprobadas
            // 
            lblCantReprobadas.AutoSize = true;
            lblCantReprobadas.Location = new Point(18, 118);
            lblCantReprobadas.Name = "lblCantReprobadas";
            lblCantReprobadas.Size = new Size(75, 15);
            lblCantReprobadas.TabIndex = 3;
            lblCantReprobadas.Text = "Reprobadas :";
            // 
            // lblRecuperacion
            // 
            lblRecuperacion.AutoSize = true;
            lblRecuperacion.Location = new Point(16, 88);
            lblRecuperacion.Name = "lblRecuperacion";
            lblRecuperacion.Size = new Size(101, 15);
            lblRecuperacion.TabIndex = 2;
            lblRecuperacion.Text = "En Recuperacion :";
            // 
            // IbIAprobadas
            // 
            IbIAprobadas.AutoSize = true;
            IbIAprobadas.Location = new Point(15, 60);
            IbIAprobadas.Name = "IbIAprobadas";
            IbIAprobadas.Size = new Size(70, 15);
            IbIAprobadas.TabIndex = 1;
            IbIAprobadas.Text = "Aprobadas :";
            // 
            // lblPromedioGeneral
            // 
            lblPromedioGeneral.AutoSize = true;
            lblPromedioGeneral.Location = new Point(15, 33);
            lblPromedioGeneral.Name = "lblPromedioGeneral";
            lblPromedioGeneral.Size = new Size(108, 15);
            lblPromedioGeneral.TabIndex = 0;
            lblPromedioGeneral.Text = "Promedio General :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 503);
            Controls.Add(grpResumen);
            Controls.Add(grpBoletin);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnResumen);
            Controls.Add(grpRegistro);
            Controls.Add(grpDatosEstudiante);
            Name = "Form1";
            Text = "Boletin de calificaciones";
            grpDatosEstudiante.ResumeLayout(false);
            grpDatosEstudiante.PerformLayout();
            grpRegistro.ResumeLayout(false);
            grpRegistro.PerformLayout();
            grpBoletin.ResumeLayout(false);
            grpResumen.ResumeLayout(false);
            grpResumen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpDatosEstudiante;
        private RadioButton rdbVespertina;
        private RadioButton rdbMatutina;
        private Label IbITanda;
        private TextBox txtEstudiante;
        private Label lblNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GroupBox grpRegistro;
        private Label lblCalificaciones;
        private ComboBox cmbAsignatura;
        private Label lblAsignatura;
        private Label IbIP2;
        private Label IbIP1;
        private TextBox txtP4;
        private TextBox txtP3;
        private TextBox txtP2;
        private TextBox txtP1;
        private Label IbIP4;
        private Label IbIP3;
        private Button btnRegistrar;
        private CheckBox chkAsistencia;
        private Button btnResumen;
        private Button btnLimpiar;
        private Button btnSalir;
        private GroupBox grpBoletin;
        private ListBox lstBoletin;
        private GroupBox grpResumen;
        private Label label4;
        private Label lblRecuperacion;
        private Label IbIAprobadas;
        private Label lblPromedioGeneral;
        private Label lblSituacion;
        private Label lblCantReprobadas;
        private Label lblCantRecuperacion;
        private Label lblCantAprobadas;
        private Label lblPromedio;
        private Label lblEstadoGeneral;
    }
}
