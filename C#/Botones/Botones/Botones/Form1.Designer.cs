
namespace Botones
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
            this.botonesPersonalizados1 = new Botones.BotonesPersonalizados();
            this.botonesPersonalizados2 = new Botones.BotonesPersonalizados();
            this.SuspendLayout();
            // 
            // botonesPersonalizados1
            // 
            this.botonesPersonalizados1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonesPersonalizados1.FlatAppearance.BorderSize = 0;
            this.botonesPersonalizados1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesPersonalizados1.ForeColor = System.Drawing.Color.White;
            this.botonesPersonalizados1.Location = new System.Drawing.Point(60, 29);
            this.botonesPersonalizados1.Name = "botonesPersonalizados1";
            this.botonesPersonalizados1.Size = new System.Drawing.Size(150, 40);
            this.botonesPersonalizados1.TabIndex = 0;
            this.botonesPersonalizados1.Text = "botonesPersonalizados1";
            this.botonesPersonalizados1.UseVisualStyleBackColor = false;
            // 
            // botonesPersonalizados2
            // 
            this.botonesPersonalizados2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botonesPersonalizados2.BackGround = System.Drawing.Color.CornflowerBlue;
            this.botonesPersonalizados2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonesPersonalizados2.BorderRadius = 197;
            this.botonesPersonalizados2.BorderSize = 1;
            this.botonesPersonalizados2.FlatAppearance.BorderSize = 0;
            this.botonesPersonalizados2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesPersonalizados2.ForeColor = System.Drawing.Color.White;
            this.botonesPersonalizados2.Location = new System.Drawing.Point(175, 184);
            this.botonesPersonalizados2.Name = "botonesPersonalizados2";
            this.botonesPersonalizados2.Size = new System.Drawing.Size(207, 197);
            this.botonesPersonalizados2.TabIndex = 1;
            this.botonesPersonalizados2.Text = "botonesPersonalizados2";
            this.botonesPersonalizados2.TextColor = System.Drawing.Color.White;
            this.botonesPersonalizados2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonesPersonalizados2);
            this.Controls.Add(this.botonesPersonalizados1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BotonesPersonalizados botonesPersonalizados1;
        private BotonesPersonalizados botonesPersonalizados2;
    }
}

