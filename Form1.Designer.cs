namespace Sistema_de_Gestión_de_Pacientes
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            groupBox1 = new GroupBox();
            lbl_Estado = new Label();
            label1 = new Label();
            cmb_Estado = new ComboBox();
            txt_Nombre = new TextBox();
            txt_ = new TextBox();
            txt_Cedula = new TextBox();
            cbm_Sexo = new ComboBox();
            lb_diagnosti = new Label();
            txt_Diagnostico = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Guardar = new Button();
            btn_Salir = new Button();
            btn_Limpiar = new Button();
            btn_Eliminar = new Button();
            dgv_Paciente = new DataGridView();
            Cedula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            txt_Edad = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Diagnostico = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Paciente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 915);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(33, 637);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(33, 534);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 4;
            button3.Text = "Consulta";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(33, 436);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "Paciente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(33, 340);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Medico";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(359, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1308, 82);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(523, 21);
            label7.Name = "label7";
            label7.Size = new Size(196, 32);
            label7.TabIndex = 7;
            label7.Text = "Registro Paciente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_Estado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmb_Estado);
            groupBox1.Controls.Add(txt_Nombre);
            groupBox1.Controls.Add(txt_);
            groupBox1.Controls.Add(txt_Cedula);
            groupBox1.Controls.Add(cbm_Sexo);
            groupBox1.Controls.Add(lb_diagnosti);
            groupBox1.Controls.Add(txt_Diagnostico);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(441, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1145, 299);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Location = new Point(367, 204);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(84, 32);
            lbl_Estado.TabIndex = 19;
            lbl_Estado.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 205);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 18;
            // 
            // cmb_Estado
            // 
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Location = new Point(472, 192);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(242, 40);
            cmb_Estado.TabIndex = 15;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(472, 78);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(200, 39);
            txt_Nombre.TabIndex = 17;
            // 
            // txt_
            // 
            txt_.Location = new Point(115, 203);
            txt_.Name = "txt_";
            txt_.Size = new Size(200, 39);
            txt_.TabIndex = 16;
            // 
            // txt_Cedula
            // 
            txt_Cedula.Location = new Point(115, 80);
            txt_Cedula.Name = "txt_Cedula";
            txt_Cedula.Size = new Size(200, 39);
            txt_Cedula.TabIndex = 14;
            // 
            // cbm_Sexo
            // 
            cbm_Sexo.FormattingEnabled = true;
            cbm_Sexo.Location = new Point(794, 71);
            cbm_Sexo.Name = "cbm_Sexo";
            cbm_Sexo.Size = new Size(242, 40);
            cbm_Sexo.TabIndex = 13;
            cbm_Sexo.SelectedIndexChanged += cbm_Sexo_SelectedIndexChanged;
            // 
            // lb_diagnosti
            // 
            lb_diagnosti.AutoSize = true;
            lb_diagnosti.Location = new Point(753, 189);
            lb_diagnosti.Name = "lb_diagnosti";
            lb_diagnosti.Size = new Size(140, 32);
            lb_diagnosti.TabIndex = 12;
            lb_diagnosti.Text = "Diagnostico";
            // 
            // txt_Diagnostico
            // 
            txt_Diagnostico.Location = new Point(908, 179);
            txt_Diagnostico.Name = "txt_Diagnostico";
            txt_Diagnostico.Size = new Size(200, 39);
            txt_Diagnostico.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 206);
            label6.Name = "label6";
            label6.Size = new Size(66, 32);
            label6.TabIndex = 5;
            label6.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 78);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 192);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(716, 74);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 2;
            label3.Text = "Sexo";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(708, 510);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(150, 46);
            btn_Guardar.TabIndex = 3;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(1235, 510);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(150, 46);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(883, 510);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(150, 46);
            btn_Limpiar.TabIndex = 4;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(1054, 510);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(150, 46);
            btn_Eliminar.TabIndex = 5;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // dgv_Paciente
            // 
            dgv_Paciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Paciente.Columns.AddRange(new DataGridViewColumn[] { Cedula, Nombre, txt_Edad, Sexo, Diagnostico, Fecha });
            dgv_Paciente.Location = new Point(418, 605);
            dgv_Paciente.Name = "dgv_Paciente";
            dgv_Paciente.RowHeadersWidth = 82;
            dgv_Paciente.Size = new Size(1217, 324);
            dgv_Paciente.TabIndex = 6;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 10;
            Cedula.Name = "Cedula";
            Cedula.Width = 200;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            Nombre.Width = 200;
            // 
            // txt_Edad
            // 
            txt_Edad.HeaderText = "Edad";
            txt_Edad.MinimumWidth = 10;
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Width = 200;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 10;
            Sexo.Name = "Sexo";
            Sexo.Width = 200;
            // 
            // Diagnostico
            // 
            Diagnostico.HeaderText = "Diagnostico";
            Diagnostico.MinimumWidth = 10;
            Diagnostico.Name = "Diagnostico";
            Diagnostico.Width = 200;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 10;
            Fecha.Name = "Fecha";
            Fecha.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1669, 964);
            Controls.Add(dgv_Paciente);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Guardar);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Paciente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_Guardar;
        private Button btn_Salir;
        private Button btn_Limpiar;
        private Button btn_Eliminar;
        private ComboBox comboBox1;
        private DataGridView dgv_Paciente;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txt_Diagnostico;
        private TextBox textBox1;
        private Label lb_diagnosti;
        private ComboBox cbm_Sexo;
        private TextBox txt_Cedula;
        private ComboBox cmb_Estado;
        private Label label1;
        private TextBox txt_Nombre;
        private TextBox txt_;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn txt_Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Diagnostico;
        private DataGridViewTextBoxColumn Fecha;
        private Label lbl_Estado;
    }
}
