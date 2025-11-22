namespace Actividad_3_CRUD
{
    partial class REGISTRO_CLIENTES
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRO_CLIENTES));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTPfecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.empresaDataSet = new Actividad_3_CRUD.empresaDataSet();
            this.empresaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESTableAdapter = new Actividad_3_CRUD.empresaDataSetTableAdapters.CLIENTESTableAdapter();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTPfecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // DTPfecha
            // 
            this.DTPfecha.Location = new System.Drawing.Point(189, 306);
            this.DTPfecha.Name = "DTPfecha";
            this.DTPfecha.Size = new System.Drawing.Size(337, 21);
            this.DTPfecha.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(189, 246);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(337, 21);
            this.txttelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(189, 170);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(337, 21);
            this.txtApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido(s)";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(189, 113);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(337, 21);
            this.txtNombres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre(s)";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(189, 58);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(337, 21);
            this.txtDNI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(668, 50);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(209, 45);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnModificar.Location = new System.Drawing.Point(562, 117);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(209, 45);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(777, 117);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(105, 38);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMostrar.Location = new System.Drawing.Point(644, 183);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(209, 45);
            this.BtnMostrar.TabIndex = 4;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegresar.Location = new System.Drawing.Point(644, 259);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(209, 45);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToOrderColumns = true;
            this.DGVClientes.AutoGenerateColumns = false;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn,
            this.tlfnDataGridViewTextBoxColumn});
            this.DGVClientes.DataSource = this.cLIENTESBindingSource;
            this.DGVClientes.Location = new System.Drawing.Point(562, 319);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.RowHeadersWidth = 62;
            this.DGVClientes.Size = new System.Drawing.Size(559, 175);
            this.DGVClientes.TabIndex = 6;
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "empresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaDataSetBindingSource
            // 
            this.empresaDataSetBindingSource.DataSource = this.empresaDataSet;
            this.empresaDataSetBindingSource.Position = 0;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.empresaDataSetBindingSource;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // fechaNacDataGridViewTextBoxColumn
            // 
            this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac";
            this.fechaNacDataGridViewTextBoxColumn.HeaderText = "FechaNac";
            this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
            // 
            // tlfnDataGridViewTextBoxColumn
            // 
            this.tlfnDataGridViewTextBoxColumn.DataPropertyName = "Tlfn";
            this.tlfnDataGridViewTextBoxColumn.HeaderText = "Tlfn";
            this.tlfnDataGridViewTextBoxColumn.Name = "tlfnDataGridViewTextBoxColumn";
            // 
            // REGISTRO_CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 506);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REGISTRO_CLIENTES";
            this.Text = "REGISTRO_CLIENTES";
            this.Load += new System.EventHandler(this.REGISTRO_CLIENTES_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTPfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.BindingSource empresaDataSetBindingSource;
        private empresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private empresaDataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfnDataGridViewTextBoxColumn;
    }
}