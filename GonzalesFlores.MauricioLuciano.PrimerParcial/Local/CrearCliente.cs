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
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            this.cmbServicios.Items.Add("Computadora");
            this.cmbServicios.Items.Add("Telefono");
            this.cmbUso.Items.Add("Juegos");
            this.cmbUso.Items.Add("Programas");
            this.grBoxPC.Visible = false;
            this.grBoxTel.Visible = false;
            this.btnCrear.Enabled = false;
        }

        void Actualizar()
        {
            this.txtDni.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.cmbServicios.Text = "";
            this.nudMinutos.Value = 0;
            this.nudEdad.Value = 6;
            this.cmbUso.Text = "";
            this.cmbJuegos.Text = "";
            this.cmbJuegos.Enabled = false;
            this.txtNumTel.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbServicios.Text == "Computadora")
                {
                    List<ESoftware> auxSoftware = new List<ESoftware>();
                    auxSoftware.Add(Computadora.ValidarSoftware(this.cmbJuegos.Text));
                    List<EJuegos> auxJuegos = new List<EJuegos>();
                    auxJuegos.Add(Computadora.ValidarJuegos(this.cmbJuegos.Text));

                    Cibercafe.AgregarAFila(
                    new Cliente(
                            this.txtDni.Text,
                            this.txtNombre.Text,
                            this.txtApellido.Text,
                            (int)this.nudEdad.Value,
                            cmbServicios.Text,
                            (int)nudMinutos.Value,
                            new Computadora(
                                auxSoftware,
                                auxJuegos,
                                new Hardware(Hardware.ValidarProcesador(this.cmbProcesador.Text), Hardware.ValidarRam(this.cmbRam.Text), Hardware.ValidarGrafica(this.cmbGrafica.Text))
                                )
                        )
                    );
                }
                else
                {
                    Cibercafe.AgregarAFila(
                    new Cliente(
                            this.txtDni.Text,
                            this.txtNombre.Text,
                            this.txtApellido.Text,
                            (int)this.nudEdad.Value,
                            cmbServicios.Text,
                            (int)nudMinutos.Value,
                            txtNumTel.Text,
                            Telefono.ValidarTipoDeLlamada(cmbTipoDeLlamada.Text)
                        )
                    );
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                this.Actualizar();
            }
            
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }
        void setComboJuegos()
        {
            this.cmbJuegos.Items.Add(EJuegos.CounterStrike);
            this.cmbJuegos.Items.Add(EJuegos.DiabloII);
            this.cmbJuegos.Items.Add(EJuegos.MuOnline);
            this.cmbJuegos.Items.Add(EJuegos.LineageII);
            this.cmbJuegos.Items.Add(EJuegos.WarcraftIII);
            this.cmbJuegos.Items.Add(EJuegos.AgeOfEmpiresII);
        }
        void setComboProgramass()
        {
            this.cmbJuegos.Items.Add(ESoftware.ofice);
            this.cmbJuegos.Items.Add(ESoftware.messenger);
            this.cmbJuegos.Items.Add(ESoftware.icq);
            this.cmbJuegos.Items.Add(ESoftware.ares);
        }
        void setCombosHardware()
        {
            this.cmbProcesador.Items.Clear();
            this.cmbProcesador.Items.Add(EProcesador.intel);
            this.cmbProcesador.Items.Add(EProcesador.Generico);

            this.cmbRam.Items.Clear();
            this.cmbRam.Items.Add(ERam.Ram100);
            this.cmbRam.Items.Add(ERam.Ram200);
            this.cmbRam.Items.Add(ERam.Ram300);

            this.cmbGrafica.Items.Clear();
            this.cmbGrafica.Items.Add(EPlacaGrafica.integrada);
            this.cmbGrafica.Items.Add(EPlacaGrafica.gaming);
        }
        void setCombosTipoLlamados()
        {
            this.cmbTipoDeLlamada.Items.Clear();

            this.cmbTipoDeLlamada.Items.Add(ETipoLlamada.local);
            this.cmbTipoDeLlamada.Items.Add(ETipoLlamada.largaDistancia);
            this.cmbTipoDeLlamada.Items.Add(ETipoLlamada.Internacional);
        }
        private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnCrear.Enabled = true;
            if (this.cmbServicios.Text == "Computadora")
            {
                this.grBoxPC.Visible = true;
                this.grBoxTel.Visible = false;
                this.setCombosHardware();

                this.cmbJuegos.Enabled = false;
            } else
            {
                this.grBoxPC.Visible = false;
                this.grBoxTel.Visible = true;
                this.setCombosTipoLlamados();
            }
        }

        private void cmbUso_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbJuegos.Enabled = true;
            this.cmbJuegos.Text = "";
            this.cmbJuegos.Items.Clear();
            if (this.cmbUso.Text == "Juegos")
            {
                this.setComboJuegos();
            }
            else
            {
                this.setComboProgramass();
            }
        }
    }
}
