
namespace WF_Juego_Cartas
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_palo1 = new System.Windows.Forms.Label();
            this.lbl_palo2 = new System.Windows.Forms.Label();
            this.lbl_palo3 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_num3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lbl_palo1);
            this.panel1.Controls.Add(this.lbl_num1);
            this.panel1.Location = new System.Drawing.Point(41, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 148);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.lbl_num2);
            this.panel2.Controls.Add(this.lbl_palo2);
            this.panel2.Location = new System.Drawing.Point(189, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 148);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.lbl_num3);
            this.panel3.Controls.Add(this.lbl_palo3);
            this.panel3.Location = new System.Drawing.Point(330, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 148);
            this.panel3.TabIndex = 1;
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(29, 27);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(35, 13);
            this.lbl_num1.TabIndex = 0;
            this.lbl_num1.Text = "label1";
            // 
            // lbl_palo1
            // 
            this.lbl_palo1.AutoSize = true;
            this.lbl_palo1.Location = new System.Drawing.Point(47, 113);
            this.lbl_palo1.Name = "lbl_palo1";
            this.lbl_palo1.Size = new System.Drawing.Size(35, 13);
            this.lbl_palo1.TabIndex = 1;
            this.lbl_palo1.Text = "label2";
            // 
            // lbl_palo2
            // 
            this.lbl_palo2.AutoSize = true;
            this.lbl_palo2.Location = new System.Drawing.Point(59, 113);
            this.lbl_palo2.Name = "lbl_palo2";
            this.lbl_palo2.Size = new System.Drawing.Size(35, 13);
            this.lbl_palo2.TabIndex = 2;
            this.lbl_palo2.Text = "label2";
            // 
            // lbl_palo3
            // 
            this.lbl_palo3.AutoSize = true;
            this.lbl_palo3.Location = new System.Drawing.Point(63, 113);
            this.lbl_palo3.Name = "lbl_palo3";
            this.lbl_palo3.Size = new System.Drawing.Size(35, 13);
            this.lbl_palo3.TabIndex = 3;
            this.lbl_palo3.Text = "label2";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(24, 27);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(35, 13);
            this.lbl_num2.TabIndex = 2;
            this.lbl_num2.Text = "label1";
            // 
            // lbl_num3
            // 
            this.lbl_num3.AutoSize = true;
            this.lbl_num3.Location = new System.Drawing.Point(26, 27);
            this.lbl_num3.Name = "lbl_num3";
            this.lbl_num3.Size = new System.Drawing.Size(35, 13);
            this.lbl_num3.TabIndex = 3;
            this.lbl_num3.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_palo1;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_palo2;
        private System.Windows.Forms.Label lbl_num3;
        private System.Windows.Forms.Label lbl_palo3;
    }
}