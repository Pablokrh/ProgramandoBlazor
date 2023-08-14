
namespace SQLyWF_Prueba
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
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblJugadoresAgregados = new System.Windows.Forms.Label();
            this.btnMostrarJugadores = new System.Windows.Forms.Button();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.txtJugAgr = new System.Windows.Forms.TextBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(70, 21);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtEquipo.TabIndex = 0;
            // 
            // txtJugador
            // 
            this.txtJugador.Location = new System.Drawing.Point(70, 57);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.Size = new System.Drawing.Size(100, 20);
            this.txtJugador.TabIndex = 1;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(22, 24);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 2;
            this.lblEquipo.Text = "Equipo";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Location = new System.Drawing.Point(17, 60);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(45, 13);
            this.lblJugador.TabIndex = 3;
            this.lblJugador.Text = "Jugador";
            this.lblJugador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(47, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblJugadoresAgregados
            // 
            this.lblJugadoresAgregados.AutoSize = true;
            this.lblJugadoresAgregados.Location = new System.Drawing.Point(214, 4);
            this.lblJugadoresAgregados.Name = "lblJugadoresAgregados";
            this.lblJugadoresAgregados.Size = new System.Drawing.Size(109, 13);
            this.lblJugadoresAgregados.TabIndex = 6;
            this.lblJugadoresAgregados.Text = "Jugadores agregados";
            // 
            // btnMostrarJugadores
            // 
            this.btnMostrarJugadores.Location = new System.Drawing.Point(231, 185);
            this.btnMostrarJugadores.Name = "btnMostrarJugadores";
            this.btnMostrarJugadores.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarJugadores.TabIndex = 7;
            this.btnMostrarJugadores.Text = "Actualizar";
            this.btnMostrarJugadores.UseVisualStyleBackColor = true;
            this.btnMostrarJugadores.Click += new System.EventHandler(this.btnMostrarJugadores_Click);
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Location = new System.Drawing.Point(70, 93);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(100, 20);
            this.txtPuntaje.TabIndex = 8;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(19, 93);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 9;
            this.lblPuntaje.Text = "Puntaje";
            this.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtJugAgr
            // 
            this.txtJugAgr.Location = new System.Drawing.Point(203, 27);
            this.txtJugAgr.Multiline = true;
            this.txtJugAgr.Name = "txtJugAgr";
            this.txtJugAgr.Size = new System.Drawing.Size(131, 126);
            this.txtJugAgr.TabIndex = 10;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(469, 104);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(128, 31);
            this.txtConsulta.TabIndex = 11;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(497, 70);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar Jugador";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.Location = new System.Drawing.Point(494, 9);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(72, 13);
            this.lblIdConsulta.TabIndex = 13;
            this.lblIdConsulta.Text = "Id de Jugador";
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Location = new System.Drawing.Point(485, 37);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtIdConsulta.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdConsulta);
            this.Controls.Add(this.lblIdConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.txtJugAgr);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.btnMostrarJugadores);
            this.Controls.Add(this.lblJugadoresAgregados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.txtJugador);
            this.Controls.Add(this.txtEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblJugadoresAgregados;
        private System.Windows.Forms.Button btnMostrarJugadores;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.TextBox txtJugAgr;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.TextBox txtIdConsulta;
    }
}

