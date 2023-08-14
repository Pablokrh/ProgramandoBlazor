
namespace ConSQL
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
            this.Btn_Conectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Conectar
            // 
            this.Btn_Conectar.Location = new System.Drawing.Point(376, 158);
            this.Btn_Conectar.Name = "Btn_Conectar";
            this.Btn_Conectar.Size = new System.Drawing.Size(153, 61);
            this.Btn_Conectar.TabIndex = 0;
            this.Btn_Conectar.Text = "Conectar";
            this.Btn_Conectar.UseVisualStyleBackColor = true;
            this.Btn_Conectar.Click += new System.EventHandler(this.Btn_Conectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Conectar;
    }
}

