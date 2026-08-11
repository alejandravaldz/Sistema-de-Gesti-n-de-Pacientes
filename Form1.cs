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
            paciente.Estado =  cmb_Estado.SelectedItem.ToString();
            paciente.Diagnostico = txt_Diagnostico.Text;
            paciente.Fecha = DateTime.Now;

            dgv_Paciente.Rows.Add(paciente.Cedula, paciente.Nombre, paciente.Edad, paciente.Sexo, paciente.Estado,paciente.Diagnostico, paciente.Fecha.ToString("dd/MM/yyyy HH:mm:ss"));


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

            dgv_Paciente.Rows.RemoveAt(dgv_Paciente.CurrentRow.Index);

        }

        private void cbm_Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

