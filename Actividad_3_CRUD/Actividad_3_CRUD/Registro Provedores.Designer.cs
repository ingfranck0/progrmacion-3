namespace Actividad_3_CRUD
{
    partial class Registro_Provedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Provedores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNif = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DGVProvedores = new System.Windows.Forms.DataGridView();
            this.empresaDataSet1 = new Actividad_3_CRUD.empresaDataSet1();
            this.pROVEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVEDORESTableAdapter = new Actividad_3_CRUD.empresaDataSet1TableAdapters.PROVEDORESTableAdapter();
            this.nifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProvedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEDORESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNif);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nif";
            // 
            // TxtNif
            // 
            this.TxtNif.Location = new System.Drawing.Point(61, 20);
            this.TxtNif.Name = "TxtNif";
            this.TxtNif.Size = new System.Drawing.Size(325, 20);
            this.TxtNif.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(61, 67);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(325, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(61, 112);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(325, 20);
            this.TxtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegresar.Location = new System.Drawing.Point(491, 221);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(209, 45);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMostrar.Location = new System.Drawing.Point(491, 145);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(209, 45);
            this.BtnMostrar.TabIndex = 9;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(624, 79);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(105, 38);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnModificar.Location = new System.Drawing.Point(409, 79);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(209, 45);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(515, 12);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(209, 45);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DGVProvedores
            // 
            this.DGVProvedores.AutoGenerateColumns = false;
            this.DGVProvedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProvedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nifDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.DGVProvedores.DataSource = this.pROVEDORESBindingSource;
            this.DGVProvedores.Location = new System.Drawing.Point(3, 210);
            this.DGVProvedores.Name = "DGVProvedores";
            this.DGVProvedores.Size = new System.Drawing.Size(392, 228);
            this.DGVProvedores.TabIndex = 11;
            // 
            // empresaDataSet1
            // 
            this.empresaDataSet1.DataSetName = "empresaDataSet1";
            this.empresaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVEDORESBindingSource
            // 
            this.pROVEDORESBindingSource.DataMember = "PROVEDORES";
            this.pROVEDORESBindingSource.DataSource = this.empresaDataSet1;
            // 
            // pROVEDORESTableAdapter
            // 
            this.pROVEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // nifDataGridViewTextBoxColumn
            // 
            this.nifDataGridViewTextBoxColumn.DataPropertyName = "Nif";
            this.nifDataGridViewTextBoxColumn.HeaderText = "Nif";
            this.nifDataGridViewTextBoxColumn.Name = "nifDataGridViewTextBoxColumn";
            this.nifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // Registro_Provedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVProvedores);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Provedores";
            this.Text = "Registro_Provedores";
            this.Load += new System.EventHandler(this.Registro_Provedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProvedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEDORESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DGVProvedores;
        private empresaDataSet1 empresaDataSet1;
        private System.Windows.Forms.BindingSource pROVEDORESBindingSource;
        private empresaDataSet1TableAdapters.PROVEDORESTableAdapter pROVEDORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}