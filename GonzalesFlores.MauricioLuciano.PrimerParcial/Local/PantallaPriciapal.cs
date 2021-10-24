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

        #region Form Pricipal
        private void PantallaPriciapal_Load(object sender, EventArgs e)
        {
            Cibercafe.HardcodeoDedatos();
            this.cargarDataGridView();
            this.RecibirClientes();
            this.tsmInformacion.ToolTipText = "Contar con una barra de información de la aplicación donde" +
                "figure el nombre del operador conectado (que deberá ser TU nombre) " +
                "y la fecha actual (sin la hora).";
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
            this.dgvcConsola.Columns[0].Width = 90;
            this.dgvcConsola.Columns[1].Name = "Costo De Uso";
            this.dgvcConsola.Columns[1].Width = 80;
            this.dgvcConsola.Columns[2].Name = "Minutos";
            this.dgvcConsola.Columns[2].Width = 60;
            this.dgvcConsola.Columns[3].Name = "Activo";
            this.dgvcConsola.Columns[3].Width = 50;
            this.dgvcConsola.Columns[4].Name = "Servicio";
        }
        void datos()
        {
            this.dgvcConsola.Rows.Clear();
            foreach (Computadora item in Cibercafe.ListaDeComputadoras)
            {
                this.dgvcConsola.Rows.Add(
                    item.Identificador,
                    string.Concat("$",item.CostoDeUso),
                    item.minutos,
                    item.activo,
                    item.Maquina);
            }
            foreach (Telefono item in Cibercafe.ListaDeTelefonos)
            {
                this.dgvcConsola.Rows.Add(
                    item.Identificador,
                    string.Concat("$", item.CostoDeUso),
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
            foreach (Cliente item in Cibercafe.FilaDeClientesPC)
            {
                this.lisBoxClientes.Items.Add(item.Mostrar());
            }
            foreach (Cliente item in Cibercafe.FilaDeClientesTel)
            {
                this.lisBoxClientes.Items.Add(item.Mostrar());
            }
        }
        #endregion

        #region Computadoras
        bool EnUso(int index, string servicio)
        {
            Cliente cliente = Cibercafe.RetirarCliente(servicio);
            if (cliente.Servicio == servicio)
            {
                return Cibercafe.ElejirServicio(cliente, index);
            }
            throw new Exception("Error, en Frm.EnUso");
        }
        void ValidarUso(Button btn, string id, string servicio)
        {
            try
            {
                if (btn.BackColor == Color.Transparent)
                {
                    if (this.EnUso(id, servicio))
                    {
                        btn.BackColor = Color.Red;
                    }
                }
                else if (btn.BackColor == Color.Red)
                {
                    btn.BackColor = Color.Green;
                }
                else if (btn.BackColor == Color.Green)
                {
                    if (servicio == "Computadora")
                    {
                        this.LiberarPc(id);
                    }
                    else
                    {
                        this.LiberarTel(id);
                    }
                    
                    btn.BackColor = Color.Transparent;
                }
                this.cargarDataGridView();
                this.RecibirClientes();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        void LiberarPc(string idPc)
        {
            Cibercafe.ComputadoraLiberar(idPc);
        }
        private void btnPcUno_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcUno, 0, "Computadora");
        }
        private void btnPcDos_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcDos, 1, "Computadora");
        }

        private void btnPcTres_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcTres, 2, "Computadora");
        }

        private void btnPcCuatro_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcCuatro, 3, "Computadora");
        }

        private void btnPcCinco_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcCinco, 4, "Computadora");
        }

        private void btnPcSeis_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcSeis, 5, "Computadora");
        }

        private void btnPcSiete_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcSiete, 6, "Computadora");
        }

        private void btnPcOcho_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcOcho, 7, "Computadora");
        }

        private void btnPcNueve_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcNueve, 8, "Computadora");
        }

        private void btnPcDiez_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcDiez, 9, "Computadora");
        }

        #endregion

        #region Telefonos
        void LiberarTel(int index)
        {
            Cibercafe.TelefonoALiberar(index);
        }
        private void btnTelUno_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelUno, 0, "Telefono");
        }
        private void btnTelDos_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelDos, 1, "Telefono");
        }
        private void btnTelTres_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelTres, 2, "Telefono");
        }
        private void btnTelCuatro_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelCuatro, 3, "Telefono");
        }
        private void btnTelCinco_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelCinco, 4, "Telefono");
        }
        #endregion

        #region Form Crear Cliente
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            CrearCliente frmCrearUsuario = new CrearCliente();
            if (frmCrearUsuario.ShowDialog() == DialogResult.OK)
            {
                
            }
            this.RecibirClientes();
        }
        #endregion
    }
}
