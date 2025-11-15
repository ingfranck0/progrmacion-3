namespace Actividad2
{
    partial class Informacion_personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacion_personal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CBEjercicio = new System.Windows.Forms.ComboBox();
            this.CBOperacion = new System.Windows.Forms.ComboBox();
            this.CBAlergias = new System.Windows.Forms.ComboBox();
            this.CBEnfermedad = new System.Windows.Forms.ComboBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.RBEj = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.RBO = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.RBA = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.RBE = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.CBEstado);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dTPFecha);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TxtCiudad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TxtDireccion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtApellido);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(499, 143);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 24);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mujer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(367, 143);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sexo";
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "viudo"});
            this.CBEstado.Location = new System.Drawing.Point(392, 92);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(121, 28);
            this.CBEstado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado Civil";
            // 
            // dTPFecha
            // 
            this.dTPFecha.Location = new System.Drawing.Point(455, 38);
            this.dTPFecha.Name = "dTPFecha";
            this.dTPFecha.Size = new System.Drawing.Size(200, 26);
            this.dTPFecha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciudad";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(139, 229);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(100, 26);
            this.TxtCiudad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(139, 159);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(100, 26);
            this.TxtDireccion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(139, 92);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 26);
            this.TxtApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(139, 38);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 26);
            this.TxtNombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CBEjercicio);
            this.tabPage2.Controls.Add(this.CBOperacion);
            this.tabPage2.Controls.Add(this.CBAlergias);
            this.tabPage2.Controls.Add(this.CBEnfermedad);
            this.tabPage2.Controls.Add(this.radioButton11);
            this.tabPage2.Controls.Add(this.radioButton12);
            this.tabPage2.Controls.Add(this.RBEj);
            this.tabPage2.Controls.Add(this.radioButton10);
            this.tabPage2.Controls.Add(this.RBO);
            this.tabPage2.Controls.Add(this.radioButton8);
            this.tabPage2.Controls.Add(this.RBA);
            this.tabPage2.Controls.Add(this.radioButton6);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.RBE);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Clinicos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CBEjercicio
            // 
            this.CBEjercicio.FormattingEnabled = true;
            this.CBEjercicio.Items.AddRange(new object[] {
            "atletismo",
            " baloncesto",
            "boxeo",
            " ciclismo",
            " esgrima",
            "fútbol",
            "gimnasia",
            " halterofilia",
            "hockey",
            " judo",
            "natación",
            "tenis",
            " tenis de mesa",
            "golf"});
            this.CBEjercicio.Location = new System.Drawing.Point(571, 213);
            this.CBEjercicio.Name = "CBEjercicio";
            this.CBEjercicio.Size = new System.Drawing.Size(121, 28);
            this.CBEjercicio.TabIndex = 18;
            // 
            // CBOperacion
            // 
            this.CBOperacion.FormattingEnabled = true;
            this.CBOperacion.Items.AddRange(new object[] {
            "cabeza",
            "pies ",
            "manos",
            "espalda"});
            this.CBOperacion.Location = new System.Drawing.Point(571, 145);
            this.CBOperacion.Name = "CBOperacion";
            this.CBOperacion.Size = new System.Drawing.Size(121, 28);
            this.CBOperacion.TabIndex = 17;
            // 
            // CBAlergias
            // 
            this.CBAlergias.FormattingEnabled = true;
            this.CBAlergias.Items.AddRange(new object[] {
            "el polen",
            " los ácaros del polvo",
            " las mascotas",
            " los alimentos (como leche, huevo, cacahuetes y mariscos)",
            " los medicamentos",
            "el moho",
            "las picaduras de insectos",
            "el látex",
            " los cosméticos ",
            " las fragancias"});
            this.CBAlergias.Location = new System.Drawing.Point(571, 76);
            this.CBAlergias.Name = "CBAlergias";
            this.CBAlergias.Size = new System.Drawing.Size(121, 28);
            this.CBAlergias.TabIndex = 16;
            // 
            // CBEnfermedad
            // 
            this.CBEnfermedad.FormattingEnabled = true;
            this.CBEnfermedad.Items.AddRange(new object[] {
            "Resfriado y gripe.",
            "Conjuntivitis.",
            "Infecciones del tracto urinario.",
            "Gastroenteritis.",
            "Infecciones respiratorias.",
            "Mononucleosis.",
            "Migraña y dolores de cabeza."});
            this.CBEnfermedad.Location = new System.Drawing.Point(571, 24);
            this.CBEnfermedad.Name = "CBEnfermedad";
            this.CBEnfermedad.Size = new System.Drawing.Size(121, 28);
            this.CBEnfermedad.TabIndex = 15;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(313, 272);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(50, 24);
            this.radioButton11.TabIndex = 14;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "SI";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(471, 272);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(57, 24);
            this.radioButton12.TabIndex = 13;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "NO";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // RBEj
            // 
            this.RBEj.AutoSize = true;
            this.RBEj.Location = new System.Drawing.Point(313, 209);
            this.RBEj.Name = "RBEj";
            this.RBEj.Size = new System.Drawing.Size(50, 24);
            this.RBEj.TabIndex = 12;
            this.RBEj.TabStop = true;
            this.RBEj.Text = "SI";
            this.RBEj.UseVisualStyleBackColor = true;
            this.RBEj.CheckedChanged += new System.EventHandler(this.RBEj_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(480, 209);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(57, 24);
            this.radioButton10.TabIndex = 11;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "NO";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // RBO
            // 
            this.RBO.AutoSize = true;
            this.RBO.Location = new System.Drawing.Point(313, 141);
            this.RBO.Name = "RBO";
            this.RBO.Size = new System.Drawing.Size(50, 24);
            this.RBO.TabIndex = 10;
            this.RBO.TabStop = true;
            this.RBO.Text = "SI";
            this.RBO.UseVisualStyleBackColor = true;
            this.RBO.CheckedChanged += new System.EventHandler(this.RBO_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(480, 145);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(57, 24);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "NO";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // RBA
            // 
            this.RBA.AutoSize = true;
            this.RBA.Location = new System.Drawing.Point(313, 76);
            this.RBA.Name = "RBA";
            this.RBA.Size = new System.Drawing.Size(50, 24);
            this.RBA.TabIndex = 8;
            this.RBA.TabStop = true;
            this.RBA.Text = "SI";
            this.RBA.UseVisualStyleBackColor = true;
            this.RBA.CheckedChanged += new System.EventHandler(this.RBA_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(480, 76);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(57, 24);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "NO";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(480, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "NO";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // RBE
            // 
            this.RBE.AutoSize = true;
            this.RBE.Location = new System.Drawing.Point(313, 29);
            this.RBE.Name = "RBE";
            this.RBE.Size = new System.Drawing.Size(50, 24);
            this.RBE.TabIndex = 5;
            this.RBE.TabStop = true;
            this.RBE.Text = "SI";
            this.RBE.UseVisualStyleBackColor = true;
            this.RBE.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "5. ¿Padeces de depresión?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "4. ¿Haces ejercicio?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "3. ¿Alguna vez te han operado?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "2. ¿Tienes alergias?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "1. ¿Padeces de alguna enfermedad?";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(452, 470);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(257, 45);
            this.BtnRegresar.TabIndex = 1;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Informacion_personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(848, 527);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informacion_personal";
            this.Text = "Informacion_personal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton RBEj;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton RBO;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton RBA;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton RBE;
        private System.Windows.Forms.ComboBox CBEjercicio;
        private System.Windows.Forms.ComboBox CBOperacion;
        private System.Windows.Forms.ComboBox CBAlergias;
        private System.Windows.Forms.ComboBox CBEnfermedad;
        private System.Windows.Forms.Button BtnRegresar;
    }
}