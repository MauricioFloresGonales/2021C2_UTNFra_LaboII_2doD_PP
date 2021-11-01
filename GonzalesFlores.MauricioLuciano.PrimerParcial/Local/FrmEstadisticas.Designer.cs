
namespace Local
{
    partial class FrmEstadisticas
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
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.btnOrdenarPc = new System.Windows.Forms.Button();
            this.btnOrdenarTel = new System.Windows.Forms.Button();
            this.btnOrdenarGanancias = new System.Windows.Forms.Button();
            this.btnPerifericos = new System.Windows.Forms.Button();
            this.btnHorasYRecaudacion = new System.Windows.Forms.Button();
            this.btnSofware = new System.Windows.Forms.Button();
            this.btnJuegos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(12, 12);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.Size = new System.Drawing.Size(641, 428);
            this.dgvEstadisticas.TabIndex = 0;
            // 
            // btnOrdenarPc
            // 
            this.btnOrdenarPc.Location = new System.Drawing.Point(659, 12);
            this.btnOrdenarPc.Name = "btnOrdenarPc";
            this.btnOrdenarPc.Size = new System.Drawing.Size(115, 56);
            this.btnOrdenarPc.TabIndex = 1;
            this.btnOrdenarPc.Text = "Oredenar Computadoras de Forma Descendente";
            this.btnOrdenarPc.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarTel
            // 
            this.btnOrdenarTel.Location = new System.Drawing.Point(659, 74);
            this.btnOrdenarTel.Name = "btnOrdenarTel";
            this.btnOrdenarTel.Size = new System.Drawing.Size(115, 56);
            this.btnOrdenarTel.TabIndex = 2;
            this.btnOrdenarTel.Text = "Oredenar Cabinas de Forma Descendente";
            this.btnOrdenarTel.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarGanancias
            // 
            this.btnOrdenarGanancias.Location = new System.Drawing.Point(659, 136);
            this.btnOrdenarGanancias.Name = "btnOrdenarGanancias";
            this.btnOrdenarGanancias.Size = new System.Drawing.Size(115, 56);
            this.btnOrdenarGanancias.TabIndex = 3;
            this.btnOrdenarGanancias.Text = "Ordenar x Gancias y Servicios";
            this.btnOrdenarGanancias.UseVisualStyleBackColor = true;
            // 
            // btnPerifericos
            // 
            this.btnPerifericos.Location = new System.Drawing.Point(659, 260);
            this.btnPerifericos.Name = "btnPerifericos";
            this.btnPerifericos.Size = new System.Drawing.Size(115, 56);
            this.btnPerifericos.TabIndex = 4;
            this.btnPerifericos.Text = "Perifericos Mas Pedidos";
            this.btnPerifericos.UseVisualStyleBackColor = true;
            // 
            // btnHorasYRecaudacion
            // 
            this.btnHorasYRecaudacion.Location = new System.Drawing.Point(659, 198);
            this.btnHorasYRecaudacion.Name = "btnHorasYRecaudacion";
            this.btnHorasYRecaudacion.Size = new System.Drawing.Size(115, 56);
            this.btnHorasYRecaudacion.TabIndex = 5;
            this.btnHorasYRecaudacion.Text = "Horas Totales y Clasificacion por tipo de llamada";
            this.btnHorasYRecaudacion.UseVisualStyleBackColor = true;
            // 
            // btnSofware
            // 
            this.btnSofware.Location = new System.Drawing.Point(659, 322);
            this.btnSofware.Name = "btnSofware";
            this.btnSofware.Size = new System.Drawing.Size(115, 56);
            this.btnSofware.TabIndex = 6;
            this.btnSofware.Text = "Software Mas Pedidos";
            this.btnSofware.UseVisualStyleBackColor = true;
            // 
            // btnJuegos
            // 
            this.btnJuegos.Location = new System.Drawing.Point(659, 384);
            this.btnJuegos.Name = "btnJuegos";
            this.btnJuegos.Size = new System.Drawing.Size(115, 56);
            this.btnJuegos.TabIndex = 7;
            this.btnJuegos.Text = "Juegos Mas Pedidos";
            this.btnJuegos.UseVisualStyleBackColor = true;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(778, 449);
            this.Controls.Add(this.btnJuegos);
            this.Controls.Add(this.btnSofware);
            this.Controls.Add(this.btnHorasYRecaudacion);
            this.Controls.Add(this.btnPerifericos);
            this.Controls.Add(this.btnOrdenarGanancias);
            this.Controls.Add(this.btnOrdenarTel);
            this.Controls.Add(this.btnOrdenarPc);
            this.Controls.Add(this.dgvEstadisticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.Button btnOrdenarPc;
        private System.Windows.Forms.Button btnOrdenarTel;
        private System.Windows.Forms.Button btnOrdenarGanancias;
        private System.Windows.Forms.Button btnPerifericos;
        private System.Windows.Forms.Button btnHorasYRecaudacion;
        private System.Windows.Forms.Button btnSofware;
        private System.Windows.Forms.Button btnJuegos;
    }
}