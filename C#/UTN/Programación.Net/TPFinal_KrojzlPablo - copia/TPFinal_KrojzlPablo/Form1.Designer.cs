
namespace TPFinal_KrojzlPablo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCasado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblBuscaNombre = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnTablaOrig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.columnaNombreCompleto,
            this.columnaDni,
            this.columnaEdad,
            this.columnaCasado,
            this.columnaSalario});
            this.dgvTabla.Location = new System.Drawing.Point(19, 66);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.ShowEditingIcon = false;
            this.dgvTabla.Size = new System.Drawing.Size(518, 191);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.TabStop = false;
            // 
            // columnaId
            // 
            this.columnaId.HeaderText = "Id";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            // 
            // columnaNombreCompleto
            // 
            this.columnaNombreCompleto.HeaderText = "Nombre Completo";
            this.columnaNombreCompleto.Name = "columnaNombreCompleto";
            this.columnaNombreCompleto.ReadOnly = true;
            // 
            // columnaDni
            // 
            this.columnaDni.HeaderText = "DNI";
            this.columnaDni.Name = "columnaDni";
            this.columnaDni.ReadOnly = true;
            // 
            // columnaEdad
            // 
            this.columnaEdad.HeaderText = "Edad";
            this.columnaEdad.Name = "columnaEdad";
            this.columnaEdad.ReadOnly = true;
            // 
            // columnaCasado
            // 
            this.columnaCasado.HeaderText = "Casado";
            this.columnaCasado.Name = "columnaCasado";
            this.columnaCasado.ReadOnly = true;
            // 
            // columnaSalario
            // 
            this.columnaSalario.HeaderText = "Salario";
            this.columnaSalario.Name = "columnaSalario";
            this.columnaSalario.ReadOnly = true;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(66, 288);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(111, 59);
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "Agregar empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(207, 288);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 59);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(369, 288);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 59);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(128, 39);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(186, 20);
            this.txtFiltrar.TabIndex = 4;
            // 
            // lblBuscaNombre
            // 
            this.lblBuscaNombre.AutoSize = true;
            this.lblBuscaNombre.Location = new System.Drawing.Point(40, 43);
            this.lblBuscaNombre.Name = "lblBuscaNombre";
            this.lblBuscaNombre.Size = new System.Drawing.Size(88, 13);
            this.lblBuscaNombre.TabIndex = 5;
            this.lblBuscaNombre.Text = "Filtar por nombre:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Location = new System.Drawing.Point(336, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(66, 36);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar Tabla";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnTablaOrig
            // 
            this.btnTablaOrig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablaOrig.Location = new System.Drawing.Point(428, 24);
            this.btnTablaOrig.Name = "btnTablaOrig";
            this.btnTablaOrig.Size = new System.Drawing.Size(92, 36);
            this.btnTablaOrig.TabIndex = 7;
            this.btnTablaOrig.Text = "Mostrar todos los empleados";
            this.btnTablaOrig.UseVisualStyleBackColor = true;
            this.btnTablaOrig.Click += new System.EventHandler(this.btnTablaOrig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 417);
            this.Controls.Add(this.btnTablaOrig);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblBuscaNombre);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.dgvTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCasado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSalario;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblBuscaNombre;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTablaOrig;
    }
}

