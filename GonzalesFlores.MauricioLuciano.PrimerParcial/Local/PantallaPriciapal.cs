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
    // Setear las pcs y telefonos con sus identificadores en el name del objeto
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
            this.SetPCs();
            this.SetTelefonos();
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
                    item.Activo,
                    item.Maquina);
            }
            foreach (Telefono item in Cibercafe.ListaDeTelefonos)
            {
                this.dgvcConsola.Rows.Add(
                    item.Identificador,
                    string.Concat("$", item.CostoDeUso),
                    item.minutos,
                    item.Activo,
                    item.Marca);
            }
        }
        #endregion

        #region ListBox
        void RecibirClientes()
        {
            this.lisBoxClientesPCs.Items.Clear();
            foreach (Cliente item in Cibercafe.FilaDeClientesPC)
            {
                this.lisBoxClientesPCs.Items.Add(item.Mostrar());
            }
            this.lisBoxClientesTelefono.Items.Clear();
            foreach (Cliente item in Cibercafe.FilaDeClientesTel)
            {
                this.lisBoxClientesTelefono.Items.Add(item.Mostrar());
            }
        }
        #endregion

        #region Computadoras
        void SetPCs ()
        {// replicar para telefonos
            this.btnPcUno.Tag = Cibercafe.ListaDeComputadoras.ElementAt(0).Identificador;
            this.btnPcDos.Tag = Cibercafe.ListaDeComputadoras.ElementAt(1).Identificador;
            this.btnPcTres.Tag = Cibercafe.ListaDeComputadoras.ElementAt(2).Identificador;
            this.btnPcCuatro.Tag = Cibercafe.ListaDeComputadoras.ElementAt(3).Identificador;
            this.btnPcCinco.Tag = Cibercafe.ListaDeComputadoras.ElementAt(4).Identificador;
            this.btnPcSeis.Tag = Cibercafe.ListaDeComputadoras.ElementAt(5).Identificador;
            this.btnPcSiete.Tag = Cibercafe.ListaDeComputadoras.ElementAt(6).Identificador;
            this.btnPcOcho.Tag = Cibercafe.ListaDeComputadoras.ElementAt(7).Identificador;
            this.btnPcNueve.Tag = Cibercafe.ListaDeComputadoras.ElementAt(8).Identificador;
            this.btnPcDiez.Tag = Cibercafe.ListaDeComputadoras.ElementAt(9).Identificador;
        }
        bool EnUso(string id, string servicio)
        {
            Cliente cliente = Cibercafe.RetirarCliente(servicio);
            if (cliente.Servicio == servicio)
            {
                return Cibercafe.ElejirServicio(cliente, id);
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
            this.ValidarUso(this.btnPcUno, this.btnPcUno.Tag.ToString(), "Computadora");
        }
        private void btnPcDos_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcDos, this.btnPcDos.Tag.ToString(), "Computadora");
        }

        private void btnPcTres_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcTres, this.btnPcTres.Tag.ToString(), "Computadora");
        }

        private void btnPcCuatro_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcCuatro, this.btnPcCuatro.Tag.ToString(), "Computadora");
        }

        private void btnPcCinco_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcCinco, this.btnPcCinco.Tag.ToString(), "Computadora");
        }

        private void btnPcSeis_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcSeis, this.btnPcSeis.Tag.ToString(), "Computadora");
        }

        private void btnPcSiete_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcSiete, this.btnPcSiete.Tag.ToString(), "Computadora");
        }

        private void btnPcOcho_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcOcho, this.btnPcOcho.Tag.ToString(), "Computadora");
        }

        private void btnPcNueve_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcNueve, this.btnPcNueve.Tag.ToString(), "Computadora");
        }

        private void btnPcDiez_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnPcDiez, this.btnPcDiez.Tag.ToString(), "Computadora");
        }

        #endregion

        #region Telefonos
        void SetTelefonos()
        {// replicar para telefonos
            this.btnTelUno.Tag = Cibercafe.ListaDeTelefonos.ElementAt(0).Identificador;
            this.btnTelDos.Tag = Cibercafe.ListaDeTelefonos.ElementAt(1).Identificador;
            this.btnTelTres.Tag = Cibercafe.ListaDeTelefonos.ElementAt(2).Identificador;
            this.btnTelCuatro.Tag = Cibercafe.ListaDeTelefonos.ElementAt(3).Identificador;
            this.btnTelCinco.Tag = Cibercafe.ListaDeTelefonos.ElementAt(4).Identificador;
        }
        void LiberarTel(string id)
        {
            Cibercafe.TelefonoALiberar(id);
        }
        private void btnTelUno_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelUno, this.btnTelUno.Tag.ToString(), "Telefono");
        }
        private void btnTelDos_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelDos, this.btnTelDos.Tag.ToString(), "Telefono");
        }
        private void btnTelTres_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelTres, this.btnTelTres.Tag.ToString(), "Telefono");
        }
        private void btnTelCuatro_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelCuatro, this.btnTelCuatro.Tag.ToString(), "Telefono");
        }
        private void btnTelCinco_Click(object sender, EventArgs e)
        {
            this.ValidarUso(this.btnTelCinco, this.btnTelCinco.Tag.ToString(), "Telefono");
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
