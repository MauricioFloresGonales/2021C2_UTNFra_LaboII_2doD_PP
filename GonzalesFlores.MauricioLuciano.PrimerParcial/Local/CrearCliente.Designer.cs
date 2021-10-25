
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
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
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
            this.btnCrear.Location = new System.Drawing.Point(12, 209);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(90, 36);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(133, 209);
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
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(235, 256);
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
    }
}