
namespace ListadoDeMercadería
{
    partial class txtPromocion
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
            this.listCarritoDeCompras = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboProctos = new System.Windows.Forms.ComboBox();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.lblPromo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCarritoDeCompras
            // 
            this.listCarritoDeCompras.FormattingEnabled = true;
            this.listCarritoDeCompras.Location = new System.Drawing.Point(25, 44);
            this.listCarritoDeCompras.Name = "listCarritoDeCompras";
            this.listCarritoDeCompras.Size = new System.Drawing.Size(130, 147);
            this.listCarritoDeCompras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(214, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(319, 84);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cboProctos
            // 
            this.cboProctos.FormattingEnabled = true;
            this.cboProctos.Location = new System.Drawing.Point(214, 44);
            this.cboProctos.Name = "cboProctos";
            this.cboProctos.Size = new System.Drawing.Size(180, 21);
            this.cboProctos.TabIndex = 3;
            // 
            // lblPromocion
            // 
            this.lblPromocion.Location = new System.Drawing.Point(0, 0);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(100, 23);
            this.lblPromocion.TabIndex = 7;
            // 
            // txtPromo
            // 
            this.txtPromo.Location = new System.Drawing.Point(291, 145);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(103, 20);
            this.txtPromo.TabIndex = 6;
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(175, 148);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(107, 13);
            this.lblPromo.TabIndex = 8;
            this.lblPromo.Text = "Código de promoción";
            // 
            // txtPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 212);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.txtPromo);
            this.Controls.Add(this.lblPromocion);
            this.Controls.Add(this.cboProctos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listCarritoDeCompras);
            this.Name = "txtPromocion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCarritoDeCompras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboProctos;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.Label lblPromo;
    }
}

