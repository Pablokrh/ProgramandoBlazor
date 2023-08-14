
namespace WF__ValidacionesYSQL
{
    partial class MenuPrincipal
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
            this.tbEliminar = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbConsultar = new System.Windows.Forms.TabPage();
            this.panConsultar = new System.Windows.Forms.Panel();
            this.panEliminar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbConsultar.SuspendLayout();
            this.panConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEliminar
            // 
            this.tbEliminar.Location = new System.Drawing.Point(4, 22);
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbEliminar.Size = new System.Drawing.Size(792, 424);
            this.tbEliminar.TabIndex = 1;
            this.tbEliminar.Text = "Eliminar";
            this.tbEliminar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbConsultar);
            this.tabControl1.Controls.Add(this.tbEliminar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tbConsultar
            // 
            this.tbConsultar.Controls.Add(this.panConsultar);
            this.tbConsultar.Location = new System.Drawing.Point(4, 22);
            this.tbConsultar.Name = "tbConsultar";
            this.tbConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultar.Size = new System.Drawing.Size(792, 424);
            this.tbConsultar.TabIndex = 0;
            this.tbConsultar.Text = "Consultar";
            this.tbConsultar.UseVisualStyleBackColor = true;
            // 
            // panConsultar
            // 
            this.panConsultar.Controls.Add(this.panEliminar);
            this.panConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panConsultar.Location = new System.Drawing.Point(3, 3);
            this.panConsultar.Name = "panConsultar";
            this.panConsultar.Size = new System.Drawing.Size(786, 418);
            this.panConsultar.TabIndex = 0;
            // 
            // panEliminar
            // 
            this.panEliminar.AutoSize = true;
            this.panEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panEliminar.Location = new System.Drawing.Point(0, 0);
            this.panEliminar.Name = "panEliminar";
            this.panEliminar.Size = new System.Drawing.Size(35, 13);
            this.panEliminar.TabIndex = 0;
            this.panEliminar.Text = "label1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tbConsultar.ResumeLayout(false);
            this.panConsultar.ResumeLayout(false);
            this.panConsultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbEliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbConsultar;
        private System.Windows.Forms.Panel panConsultar;
        private System.Windows.Forms.Label panEliminar;
    }
}