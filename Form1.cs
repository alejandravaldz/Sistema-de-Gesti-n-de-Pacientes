namespace Sistema_de_Gestión_de_Pacientes
{
    public partial class Form1 : Form
    {
        enum sexo
        {
            //Probando probandooooooooooooooooooooo
            masculino,
            femenino
        }
        enum Estado
        {
            Ingresado,
            EnObservacion,
            DeAlta,
            Hospitalizado
            //A Milangel le hiede la boca
        }
        public Form1()
        {
            InitializeComponent();
            cmb_Estado.Items.AddRange(Enum.GetNames(typeof(Estado)));
            cbm_Sexo.Items.AddRange(Enum.GetNames(typeof(sexo)));

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            Paciente paciente = new Paciente();
            paciente.Cedula = txt_Cedula.Text;
            paciente.Nombre = txt_Nombre.Text;
            paciente.Sexo = cbm_Sexo.SelectedItem.ToString();
            paciente.Estado = cmb_Estado.SelectedItem.ToString();
            paciente.Diagnostico = txt_Diagnostico.Text;
            paciente.Fecha = DateTime.Now;

            dgv_Paciente.Rows.Add(paciente.Cedula, paciente.Nombre, paciente.Edad, paciente.Sexo, paciente.Estado, paciente.Diagnostico, paciente.Fecha.ToString("dd/MM/yyyy HH:mm:ss"));


        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

            txt_Cedula.Text = "";
            txt_Nombre.Text = "";
            cbm_Sexo.SelectedIndex = -1;
            txt_Diagnostico.Text = "";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DataGridView tabla = null;

            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    tabla = (DataGridView)control;
                    break;
                }
            }

            if (tabla != null && tabla.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de querer eliminar los datos de este paciente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    tabla.Rows.Remove(tabla.CurrentRow);
                }
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un paciente para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void cbm_Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_Paciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

