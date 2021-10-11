using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        string nombre;
        string servicio;
        int minutos;

        #region Propiedades
        public string Nombre 
        {
            get { return this.nombre; }
        }
        public string Servicio
        {
            get { return this.servicio; }

        }
        public int Minutos
        {
            get { return this.minutos; }
        }
        #endregion

        #region Constructores
        public Cliente(string nombre, string servicio, int minutos)
        {
            this.nombre = nombre;
            this.servicio = servicio;
            this.minutos = minutos;
        }
        #endregion

        #region Metodos

        #endregion





    }
}
