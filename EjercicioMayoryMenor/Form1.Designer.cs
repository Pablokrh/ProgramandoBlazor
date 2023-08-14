
namespace EjercicioMayoryMenor
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
            this.txtTercero = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.txtPrimero = new System.Windows.Forms.TextBox();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTercero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTercero
            // 
            this.txtTercero.Location = new System.Drawing.Point(141, 107);
            this.txtTercero.Name = "txtTercero";
            this.txtTercero.Size = new System.Drawing.Size(100, 20);
            this.txtTercero.TabIndex = 1;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(141, 68);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(100, 20);
            this.txtSegundo.TabIndex = 2;
            // 
            // txtPrimero
            // 
            this.txtPrimero.Location = new System.Drawing.Point(141, 32);
            this.txtPrimero.Name = "txtPrimero";
            this.txtPrimero.Size = new System.Drawing.Size(100, 20);
            this.txtPrimero.TabIndex = 4;
            // 
            // lblPrimero
            // 
            this.lblPrimero.AutoSize = true;
            this.lblPrimero.Location = new System.Drawing.Point(59, 35);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(74, 13);
            this.lblPrimero.TabIndex = 5;
            this.lblPrimero.Text = "Primer número";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(47, 71);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(88, 13);
            this.lblSegundo.TabIndex = 8;
            this.lblSegundo.Text = "Segundo número";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(71, 157);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTercero
            // 
            this.lblTercero.AutoSize = true;
            this.lblTercero.Location = new System.Drawing.Point(45, 110);
            this.lblTercero.Name = "lblTercero";
            this.lblTercero.Size = new System.Drawing.Size(76, 13);
            this.lblTercero.TabIndex = 10;
            this.lblTercero.Text = "Tercer número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 231);
            this.Controls.Add(this.lblTercero);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrimero);
            this.Controls.Add(this.txtPrimero);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtTercero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTercero;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.TextBox txtPrimero;
        private System.Windows.Forms.Label lblPrimero;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTercero;
    }
}

