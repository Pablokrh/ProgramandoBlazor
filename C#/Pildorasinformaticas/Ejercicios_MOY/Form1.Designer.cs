
namespace Ejercicios_MOY
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
            this.Btn_Cambiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label_Edad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Cambiar
            // 
            this.Btn_Cambiar.Location = new System.Drawing.Point(152, 137);
            this.Btn_Cambiar.Name = "Btn_Cambiar";
            this.Btn_Cambiar.Size = new System.Drawing.Size(93, 26);
            this.Btn_Cambiar.TabIndex = 1;
            this.Btn_Cambiar.Text = "Cambiar";
            this.Btn_Cambiar.UseVisualStyleBackColor = true;
            this.Btn_Cambiar.Click += new System.EventHandler(this.Btn_Cambiar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(266, 144);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Hola Mundo";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(242, 181);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // label_Edad
            // 
            this.label_Edad.AutoSize = true;
            this.label_Edad.Location = new System.Drawing.Point(193, 184);
            this.label_Edad.Name = "label_Edad";
            this.label_Edad.Size = new System.Drawing.Size(32, 13);
            this.label_Edad.TabIndex = 4;
            this.label_Edad.Text = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Edad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Btn_Cambiar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cambiar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label_Edad;
    }
}

