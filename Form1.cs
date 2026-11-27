
namespace boletindecalificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Agregar asignaturas
            cmbAsignatura.Items.Add("Matemática");
            cmbAsignatura.Items.Add("Español");
            cmbAsignatura.Items.Add("Ciencias Naturales");
            cmbAsignatura.Items.Add("Ciencias Sociales");
            cmbAsignatura.Items.Add("Informática");

            cmbAsignatura.SelectedIndex = 0;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtEstudiante.Text.Trim() == "" ||
                cmbAsignatura.SelectedIndex == -1)
            {
                MessageBox.Show("Complete el nombre y seleccione una asignatura.");
                return;
            }

            if (!rdbMatutina.Checked && !rdbVespertina.Checked)
            {
                MessageBox.Show("Seleccione la tanda.");
                return;
            }

            if (!chkAsistencia.Checked)
            {
                MessageBox.Show("No cumple con la asistencia mínima del 80%.");
                return;
            }

            double p1, p2, p3, p4;

            if (!double.TryParse(txtP1.Text, out p1) ||
                !double.TryParse(txtP2.Text, out p2) ||
                !double.TryParse(txtP3.Text, out p3) ||
                !double.TryParse(txtP4.Text, out p4))
            {
                MessageBox.Show("Escriba las cuatro calificaciones.");
                return;
            }

            if (p1 < 0 || p1 > 100 || p2 < 0 || p2 > 100 ||
                p3 < 0 || p3 > 100 || p4 < 0 || p4 > 100)
            {
                MessageBox.Show("Las calificaciones deben estar entre 0 y 100.");
                return;
            }

            double promedio = (p1 + p2 + p3 + p4) / 4;

            string estado;

            if (promedio >= 70)
                estado = "Aprobada";
            else if (promedio >= 60)
                estado = "En recuperación";
            else
                estado = "Reprobada";

            string tanda = rdbMatutina.Checked ? "Matutina" : "Vespertina";

            lstBoletin.Items.Add(
                txtEstudiante.Text + " | " +
                cmbAsignatura.Text + " | " +
                tanda + " | Promedio: " +
                promedio.ToString("0.00") + " | " + estado
            );

            MessageBox.Show("Asignatura registrada.");

            cmbAsignatura.SelectedIndex = -1;
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtP4.Clear();
            chkAsistencia.Checked = false;
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (lstBoletin.Items.Count == 0)
            {
                MessageBox.Show("No hay asignaturas registradas.");
                return;
            }

            int aprobadas = 0;
            int recuperacion = 0;
            int reprobadas = 0;
            double suma = 0;

            foreach (string registro in lstBoletin.Items)
            {
                string[] partes = registro.Split('|');

                string promedioTexto = partes[3].Replace("Promedio:", "").Trim();
                double promedio = double.Parse(promedioTexto);

                suma += promedio;

                if (promedio >= 70)
                    aprobadas++;
                else if (promedio >= 60)
                    recuperacion++;
                else
                    reprobadas++;
            }

            double promedioGeneral = suma / lstBoletin.Items.Count;

            lblPromedio.Text = promedioGeneral.ToString("0.00");
            lblCantAprobadas.Text = aprobadas.ToString();
            lblCantRecuperacion.Text = recuperacion.ToString();
            lblCantReprobadas.Text = reprobadas.ToString();

            if (reprobadas > 0)
                lblEstadoGeneral.Text = "Reprobado";
            else if (recuperacion > 0)
                lblEstadoGeneral.Text = "En recuperación";
            else
                lblEstadoGeneral.Text = "Aprobado";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEstudiante.Clear();
            cmbAsignatura.SelectedIndex = 0;

            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtP4.Clear();

            rdbMatutina.Checked = false;
            rdbVespertina.Checked = false;
            chkAsistencia.Checked = false;

            lstBoletin.Items.Clear();

            lblPromedio.Text = "0.00";
            lblCantAprobadas.Text = "0";
            lblCantRecuperacion.Text = "0";
            lblCantReprobadas.Text = "0";
            lblEstadoGeneral.Text = "Sin Registrar";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del programa?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
