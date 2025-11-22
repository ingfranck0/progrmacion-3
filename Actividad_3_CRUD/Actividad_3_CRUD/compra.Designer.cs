namespace Actividad_3_CRUD
{
    partial class compra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbcodprodcuto = new System.Windows.Forms.ComboBox();
            this.cmbdni = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.dniClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet3 = new Actividad_3_CRUD.empresaDataSet3();
            this.cOMPRATableAdapter = new Actividad_3_CRUD.empresaDataSet3TableAdapters.COMPRATableAdapter();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbcodprodcuto);
            this.groupBox1.Controls.Add(this.cmbdni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra";
            // 
            // cmbcodprodcuto
            // 
            this.cmbcodprodcuto.FormattingEnabled = true;
            this.cmbcodprodcuto.Location = new System.Drawing.Point(82, 43);
            this.cmbcodprodcuto.Name = "cmbcodprodcuto";
            this.cmbcodprodcuto.Size = new System.Drawing.Size(161, 21);
            this.cmbcodprodcuto.TabIndex = 4;
            // 
            // cmbdni
            // 
            this.cmbdni.FormattingEnabled = true;
            this.cmbdni.Location = new System.Drawing.Point(69, 20);
            this.cmbdni.Name = "cmbdni";
            this.cmbdni.Size = new System.Drawing.Size(174, 21);
            this.cmbdni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CodProducto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DniCliente";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AutoGenerateColumns = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniClienteDataGridViewTextBoxColumn,
            this.codProductoDataGridViewTextBoxColumn});
            this.dgvCompra.DataSource = this.cOMPRABindingSource;
            this.dgvCompra.Location = new System.Drawing.Point(23, 101);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(262, 150);
            this.dgvCompra.TabIndex = 1;
            // 
            // dniClienteDataGridViewTextBoxColumn
            // 
            this.dniClienteDataGridViewTextBoxColumn.DataPropertyName = "DniCliente";
            this.dniClienteDataGridViewTextBoxColumn.HeaderText = "DniCliente";
            this.dniClienteDataGridViewTextBoxColumn.Name = "dniClienteDataGridViewTextBoxColumn";
            // 
            // codProductoDataGridViewTextBoxColumn
            // 
            this.codProductoDataGridViewTextBoxColumn.DataPropertyName = "CodProducto";
            this.codProductoDataGridViewTextBoxColumn.HeaderText = "CodProducto";
            this.codProductoDataGridViewTextBoxColumn.Name = "codProductoDataGridViewTextBoxColumn";
            // 
            // cOMPRABindingSource
            // 
            this.cOMPRABindingSource.DataMember = "COMPRA";
            this.cOMPRABindingSource.DataSource = this.empresaDataSet3;
            // 
            // empresaDataSet3
            // 
            this.empresaDataSet3.DataSetName = "empresaDataSet3";
            this.empresaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPRATableAdapter
            // 
            this.cOMPRATableAdapter.ClearBeforeFill = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegresar.Location = new System.Drawing.Point(347, 219);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(209, 45);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMostrar.Location = new System.Drawing.Point(347, 143);
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
            this.BtnEliminar.Location = new System.Drawing.Point(506, 71);
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
            this.BtnModificar.Location = new System.Drawing.Point(291, 68);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(209, 45);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(363, 12);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(209, 45);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 331);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.groupBox1);
            this.Name = "compra";
            this.Text = "compra";
            this.Load += new System.EventHandler(this.compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCompra;
        private empresaDataSet3 empresaDataSet3;
        private System.Windows.Forms.BindingSource cOMPRABindingSource;
        private empresaDataSet3TableAdapters.COMPRATableAdapter cOMPRATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox cmbcodprodcuto;
        private System.Windows.Forms.ComboBox cmbdni;
    }
}