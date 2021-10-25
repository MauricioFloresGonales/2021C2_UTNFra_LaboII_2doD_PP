using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        string dni;
        string nombre;
        string apellido;
        int edad;
        string servicio;
        int minutos;
        string numerosALlamar;
        ETipoLlamada tipoLlamada;

        #region Propiedades
        public string Dni
        {
            get { return this.dni; }
        }
        public string Nombre 
        {
            get { return this.nombre; }
        }
        public string Servicio
        {
            get { return this.servicio; }
            set { this.servicio = value == "Computadora" ? servicio : "Telefono"; }

        }
        public string Apellodo
        {
            get { return this.apellido; }

        }
        public int Minutos
        {
            get { return this.minutos; }
        }
        public int Edad
        {
            get { return this.edad; }
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
        public Cliente(string dni, string nombre, string apellido, int edad, string servicio, int minutos):this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.servicio = servicio;
            this.minutos = minutos;
        }
        public Cliente(string dni, string nombre, string apellido, int edad, string servicio, int minutos, string numeroALlamar, ETipoLlamada tipo): this(dni,nombre,apellido,edad,servicio,minutos)
        {
            this.numerosALlamar = numeroALlamar;
            this.tipoLlamada = tipo;
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($" {this.Dni} -");
            sb.Append($" {this.Nombre} -");
            sb.Append($" {this.Apellodo} -");
            sb.Append($" {this.Edad} -");
            sb.Append($" {this.Servicio} -");
            sb.Append($" {this.Minutos} -");
            if (this.NumeroALlamar != null)
            {
                sb.Append($" {this.NumeroALlamar} -");
            }
            sb.Append($" {this.TipoDeLlamada}");
            return sb.ToString();
        }
        public static Queue<Cliente> operator +(Queue<Cliente> filaClientes, Cliente cl)
        {
            if (!object.ReferenceEquals(cl, null))
            {
                filaClientes.Enqueue(cl);
            }
            return filaClientes;
        }
        #endregion





    }
}
