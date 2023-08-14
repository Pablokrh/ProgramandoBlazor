
namespace Practica_1
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
            this.btn_Llamar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Llamar
            // 
            this.btn_Llamar.Location = new System.Drawing.Point(476, 161);
            this.btn_Llamar.Name = "btn_Llamar";
            this.btn_Llamar.Size = new System.Drawing.Size(237, 130);
            this.btn_Llamar.TabIndex = 0;
            this.btn_Llamar.Text = "Llamar";
            this.btn_Llamar.UseVisualStyleBackColor = true;
            this.btn_Llamar.Click += new System.EventHandler(this.btn_Llamar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Llamar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Llamar;
    }
}

