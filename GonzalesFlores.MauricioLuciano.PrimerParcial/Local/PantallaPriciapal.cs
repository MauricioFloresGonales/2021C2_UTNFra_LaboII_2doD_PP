using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Local
{
    public partial class PantallaPriciapal : Form
    {
        public PantallaPriciapal()
        {
            InitializeComponent();
        }

        #region Form
        private void PantallaPriciapal_Load(object sender, EventArgs e)
        {
            Cibercafe.HardcodeoDedatos();
            this.dataGridView1.ColumnCount = 5;
            this.dataGridView1.Columns[0].Name = "Identificador";
            this.dataGridView1.Columns[1].Name = "Costo De Uso";
            this.dataGridView1.Columns[2].Name = "Minutos";
            this.dataGridView1.Columns[3].Name = "Activo";
            this.dataGridView1.Columns[4].Name = "Servicio";
            this.datos();
        }
        #endregion

        #region DataGridView
        void datos()
        {
            foreach (Computadora item in Cibercafe.FilaDeComputadoras)
            {
                this.dataGridView1.Rows.Add(
                    item.Identificador,
                    item.CostoDeUso,
                    item.minutos,
                    item.activo,
                    item.Maquina);
            }
            foreach (Telefono item in Cibercafe.FilaDeTelefonos)
            {
                this.dataGridView1.Rows.Add(
                    item.Identificador,
                    item.CostoDeUso,
                    item.minutos,
                    item.activo,
                    item.NumeroLlamado);
            }

        }
        #endregion

    }
}
