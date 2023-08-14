
namespace Vista
{
    partial class FormPrincipal
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
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(234, 291);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(111, 59);
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "Agregar empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 417);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.dgvTabla);
            this.Name = "Form1";
            this.Text = "Sistema de gestión de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

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
    }
}

