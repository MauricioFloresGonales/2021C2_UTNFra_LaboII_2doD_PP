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
            cargarDataGridView();
        }
        #endregion

        #region DataGridView
        void cargarDataGridView()
        {
            this.setColumnas();
            this.datos();
        }
        void setColumnas()
        {
            this.dgvcConsola.ColumnCount = 5;
            this.dgvcConsola.Columns[0].Name = "Identificador";
            this.dgvcConsola.Columns[1].Name = "Costo De Uso";
            this.dgvcConsola.Columns[2].Name = "Minutos";
            this.dgvcConsola.Columns[3].Name = "Activo";
            this.dgvcConsola.Columns[4].Name = "Servicio";
        }
        void datos()
        {
            foreach (Computadora item in Cibercafe.ListaDeComputadoras)
            {
                this.dgvcConsola.Rows.Add(
                    item.Identificador,
                    item.CostoDeUso,
                    item.minutos,
                    item.activo,
                    item.Maquina);
            }
            foreach (Telefono item in Cibercafe.ListaDeTelefonos)
            {
                this.dgvcConsola.Rows.Add(
                    item.Identificador,
                    item.CostoDeUso,
                    item.minutos,
                    item.activo,
                    item.Marca);
            }
        }
        #endregion

        #region ListBox
        void RecibirClientes()
        {
            this.lisBoxClientes.Items.Clear();
            foreach (Cliente item in Cibercafe.FilaDeClientes)
            {
                this.lisBoxClientes.Items.Add(item.Mostrar());
            }
        }
        private void btnRecibirClientes_Click(object sender, EventArgs e)
        {
            RecibirClientes();
        }
        #endregion

        #region Computadoras
        bool EnUso(int index)
        {
            Cliente cliente = Cibercafe.RetirarCliente();
            Cibercafe.ComputadoraAUsar(index, cliente.Minutos);
            return Cibercafe.RecibirPC(index).activo;
        }
        private void btnPcUno_Click(object sender, EventArgs e)
        {
            EnUso(0);
            RecibirClientes();
        }
        private void btnPcDos_Click(object sender, EventArgs e)
        {
            EnUso(1);
            RecibirClientes();
        }

        private void btnPcTres_Click(object sender, EventArgs e)
        {
            EnUso(2);
            RecibirClientes();
        }

        private void btnPcCuatro_Click(object sender, EventArgs e)
        {
            EnUso(3);
            RecibirClientes();
        }

        private void btnPcCinco_Click(object sender, EventArgs e)
        {
            EnUso(4);
            RecibirClientes();
        }

        private void btnPcSeis_Click(object sender, EventArgs e)
        {
            EnUso(5);
            RecibirClientes();
        }

        private void btnPcSiete_Click(object sender, EventArgs e)
        {
            EnUso(6);
            RecibirClientes();
        }

        private void btnPcOcho_Click(object sender, EventArgs e)
        {
            EnUso(7);
            RecibirClientes();
        }

        private void btnPcNueve_Click(object sender, EventArgs e)
        {
            EnUso(8);
            RecibirClientes();
        }

        private void btnPcDiez_Click(object sender, EventArgs e)
        {
            EnUso(9);
            RecibirClientes();
        }
        #endregion
    }
}
