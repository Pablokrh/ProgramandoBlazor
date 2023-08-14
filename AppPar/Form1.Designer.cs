
namespace AppPar
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
            this.lblIngresar = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnAveriguar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(41, 36);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(83, 13);
            this.lblIngresar.TabIndex = 0;
            this.lblIngresar.Text = "Ingresar número";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(29, 63);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // btnAveriguar
            // 
            this.btnAveriguar.Location = new System.Drawing.Point(44, 102);
            this.btnAveriguar.Name = "btnAveriguar";
            this.btnAveriguar.Size = new System.Drawing.Size(75, 23);
            this.btnAveriguar.TabIndex = 2;
            this.btnAveriguar.Text = "Averiguar";
            this.btnAveriguar.UseVisualStyleBackColor = true;
            this.btnAveriguar.Click += new System.EventHandler(this.btnAveriguar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 148);
            this.Controls.Add(this.btnAveriguar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnAveriguar;
    }
}

