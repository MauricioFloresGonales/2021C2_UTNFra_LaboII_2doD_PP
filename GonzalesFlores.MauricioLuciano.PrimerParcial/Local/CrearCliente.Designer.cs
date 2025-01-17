﻿
namespace Local
{
    partial class CrearCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.grBoxTel = new System.Windows.Forms.GroupBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.grBoxPC = new System.Windows.Forms.GroupBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblGrafica = new System.Windows.Forms.Label();
            this.lblProcesador = new System.Windows.Forms.Label();
            this.cmbRam = new System.Windows.Forms.ComboBox();
            this.cmbProcesador = new System.Windows.Forms.ComboBox();
            this.cmbGrafica = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.cmbJuegos = new System.Windows.Forms.ComboBox();
            this.cmbUso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDeLlamada = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grBoxTel.SuspendLayout();
            this.grBoxPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(16, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre : ";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblServicio.Location = new System.Drawing.Point(16, 157);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(73, 16);
            this.lblServicio.TabIndex = 1;
            this.lblServicio.Text = "Servicio :";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(16, 183);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(73, 16);
            this.lblMinutos.TabIndex = 2;
            this.lblMinutos.Text = "Minutos : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // cmbServicios
            // 
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(95, 156);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(126, 21);
            this.cmbServicios.TabIndex = 4;
            this.cmbServicios.SelectedIndexChanged += new System.EventHandler(this.cmbServicios_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(36, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Crear Cliente";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 336);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(90, 36);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(133, 336);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 36);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(95, 183);
            this.nudMinutos.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(126, 20);
            this.nudMinutos.TabIndex = 9;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDni.Location = new System.Drawing.Point(38, 53);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(46, 16);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "DNI : ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(16, 105);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 16);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido : ";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(95, 52);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(126, 20);
            this.txtDni.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEdad.Location = new System.Drawing.Point(32, 130);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(57, 16);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad : ";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(95, 130);
            this.nudEdad.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudEdad.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(126, 20);
            this.nudEdad.TabIndex = 16;
            this.nudEdad.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // grBoxTel
            // 
            this.grBoxTel.Controls.Add(this.cmbTipoDeLlamada);
            this.grBoxTel.Controls.Add(this.txtNumTel);
            this.grBoxTel.Controls.Add(this.lblNumTel);
            this.grBoxTel.Location = new System.Drawing.Point(19, 209);
            this.grBoxTel.Name = "grBoxTel";
            this.grBoxTel.Size = new System.Drawing.Size(202, 120);
            this.grBoxTel.TabIndex = 17;
            this.grBoxTel.TabStop = false;
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(6, 82);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(190, 20);
            this.txtNumTel.TabIndex = 20;
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNumTel.Location = new System.Drawing.Point(34, 16);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(134, 16);
            this.lblNumTel.TabIndex = 19;
            this.lblNumTel.Text = "Numero a Llamar :";
            // 
            // grBoxPC
            // 
            this.grBoxPC.Controls.Add(this.lblRam);
            this.grBoxPC.Controls.Add(this.lblGrafica);
            this.grBoxPC.Controls.Add(this.lblProcesador);
            this.grBoxPC.Controls.Add(this.cmbRam);
            this.grBoxPC.Controls.Add(this.cmbProcesador);
            this.grBoxPC.Controls.Add(this.cmbGrafica);
            this.grBoxPC.Controls.Add(this.lblJuego);
            this.grBoxPC.Controls.Add(this.cmbJuegos);
            this.grBoxPC.Controls.Add(this.cmbUso);
            this.grBoxPC.Controls.Add(this.label1);
            this.grBoxPC.Location = new System.Drawing.Point(19, 209);
            this.grBoxPC.Name = "grBoxPC";
            this.grBoxPC.Size = new System.Drawing.Size(204, 128);
            this.grBoxPC.TabIndex = 18;
            this.grBoxPC.TabStop = false;
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRam.Location = new System.Drawing.Point(156, 81);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(42, 13);
            this.lblRam.TabIndex = 9;
            this.lblRam.Text = "RAM :";
            // 
            // lblGrafica
            // 
            this.lblGrafica.AutoSize = true;
            this.lblGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGrafica.Location = new System.Drawing.Point(82, 81);
            this.lblGrafica.Name = "lblGrafica";
            this.lblGrafica.Size = new System.Drawing.Size(56, 13);
            this.lblGrafica.TabIndex = 8;
            this.lblGrafica.Text = "Grafica :";
            // 
            // lblProcesador
            // 
            this.lblProcesador.AutoSize = true;
            this.lblProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProcesador.Location = new System.Drawing.Point(-3, 81);
            this.lblProcesador.Name = "lblProcesador";
            this.lblProcesador.Size = new System.Drawing.Size(79, 13);
            this.lblProcesador.TabIndex = 7;
            this.lblProcesador.Text = "Procesador :";
            // 
            // cmbRam
            // 
            this.cmbRam.FormattingEnabled = true;
            this.cmbRam.Location = new System.Drawing.Point(142, 101);
            this.cmbRam.Name = "cmbRam";
            this.cmbRam.Size = new System.Drawing.Size(64, 21);
            this.cmbRam.TabIndex = 6;
            // 
            // cmbProcesador
            // 
            this.cmbProcesador.FormattingEnabled = true;
            this.cmbProcesador.Location = new System.Drawing.Point(0, 101);
            this.cmbProcesador.Name = "cmbProcesador";
            this.cmbProcesador.Size = new System.Drawing.Size(65, 21);
            this.cmbProcesador.TabIndex = 5;
            // 
            // cmbGrafica
            // 
            this.cmbGrafica.FormattingEnabled = true;
            this.cmbGrafica.Location = new System.Drawing.Point(71, 101);
            this.cmbGrafica.Name = "cmbGrafica";
            this.cmbGrafica.Size = new System.Drawing.Size(65, 21);
            this.cmbGrafica.TabIndex = 4;
            // 
            // lblJuego
            // 
            this.lblJuego.AutoSize = true;
            this.lblJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuego.Location = new System.Drawing.Point(1, 38);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(69, 26);
            this.lblJuego.TabIndex = 3;
            this.lblJuego.Text = "Juego      :\r\nEspecifico";
            // 
            // cmbJuegos
            // 
            this.cmbJuegos.FormattingEnabled = true;
            this.cmbJuegos.Location = new System.Drawing.Point(76, 38);
            this.cmbJuegos.Name = "cmbJuegos";
            this.cmbJuegos.Size = new System.Drawing.Size(126, 21);
            this.cmbJuegos.TabIndex = 2;
            // 
            // cmbUso
            // 
            this.cmbUso.FormattingEnabled = true;
            this.cmbUso.Location = new System.Drawing.Point(76, 11);
            this.cmbUso.Name = "cmbUso";
            this.cmbUso.Size = new System.Drawing.Size(126, 21);
            this.cmbUso.TabIndex = 1;
            this.cmbUso.SelectedIndexChanged += new System.EventHandler(this.cmbUso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uso :";
            // 
            // cmbTipoDeLlamada
            // 
            this.cmbTipoDeLlamada.FormattingEnabled = true;
            this.cmbTipoDeLlamada.Location = new System.Drawing.Point(37, 45);
            this.cmbTipoDeLlamada.Name = "cmbTipoDeLlamada";
            this.cmbTipoDeLlamada.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDeLlamada.TabIndex = 21;
            // 
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(235, 380);
            this.Controls.Add(this.grBoxPC);
            this.Controls.Add(this.grBoxTel);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grBoxTel.ResumeLayout(false);
            this.grBoxTel.PerformLayout();
            this.grBoxPC.ResumeLayout(false);
            this.grBoxPC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.GroupBox grBoxTel;
        private System.Windows.Forms.Label lblNumTel;
        private System.Windows.Forms.GroupBox grBoxPC;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.ComboBox cmbJuegos;
        private System.Windows.Forms.ComboBox cmbUso;
        private System.Windows.Forms.ComboBox cmbRam;
        private System.Windows.Forms.ComboBox cmbProcesador;
        private System.Windows.Forms.ComboBox cmbGrafica;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblGrafica;
        private System.Windows.Forms.Label lblProcesador;
        private System.Windows.Forms.ComboBox cmbTipoDeLlamada;
    }
}