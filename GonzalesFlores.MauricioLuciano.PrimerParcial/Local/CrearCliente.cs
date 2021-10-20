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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            this.cmbServicios.Items.Add("Computadora");
            this.cmbServicios.Items.Add("Telefono");
        }

        void Actualizar()
        {
            this.txtNombre.Text = "";
            cmbServicios.Text = "";
            nudMinutos.Value = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cibercafe.AgregarALista(
                new Cliente(
                        this.txtNombre.Text,
                        cmbServicios.Text,
                        (int)nudMinutos.Value
                    )
                );
            this.Actualizar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }
    }
}
