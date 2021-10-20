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
        string numerosALlamar;
        ETipoLlamada tipoLlamada;


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
        public string NumeroALlamar
        {
            get { return this.numerosALlamar; }
        }
        public ETipoLlamada TipoDeLlamada
        {
            get { return this.tipoLlamada; }
        }
        #endregion

        #region Constructores
        public Cliente()
        {
        }
        public Cliente(string nombre, string servicio, int minutos)
        {
            this.nombre = nombre;
            this.servicio = servicio == "Computadora" ? servicio : "Telefono";
            this.minutos = minutos;
        }
        public Cliente(string nombre, string servicio, int minutos, string numeroALlamar, ETipoLlamada tipo): this(nombre,servicio,minutos)
        {
            this.numerosALlamar = numeroALlamar;
            this.tipoLlamada = tipo;
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($" {this.Nombre} -");
            sb.Append($" {this.Servicio} -");
            sb.Append($" {this.Minutos} -");
            sb.Append($" {this.NumeroALlamar} -");
            sb.Append($" {this.TipoDeLlamada}");
            return sb.ToString();
        }
        #endregion





    }
}
