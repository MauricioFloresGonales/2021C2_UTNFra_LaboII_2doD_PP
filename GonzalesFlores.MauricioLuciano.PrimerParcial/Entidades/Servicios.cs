using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Servicios
    {
        string identificador;
        float costoDeUso;
        public int minutos;
        public bool activo;

        #region Propiedades
        public virtual string Identificador
        {
            set { this.identificador = value; }
            get { return this.identificador; }
        }
        public virtual float CostoDeUso
        {
            set { this.costoDeUso = value; }
            get { return this.costoDeUso; }
        }
        #endregion

        #region Constructores
        public Servicios()
        {
            this.identificador = " ";
            this.costoDeUso = 0;
            this.minutos = 0;
            this.activo = false;
        }
        public Servicios(bool activo) : base()
        {
            this.activo = activo;
        }
        #endregion

        #region Metodos
        public string AgregarCodigo(string identificador, string numero)
        {
            if (int.Parse(numero) < 10)
            {
                return string.Concat(identificador, this.Identificador, "0", numero);
            }
            return string.Concat(identificador,this.Identificador, numero);
        }
        public abstract bool ValidarIdentificador(string code);
        public float Costo(int minutos, string valorInicial)
        {
            int tiempo = 30;
            float valor = float.Parse(valorInicial);
            float retorno = 0;
            do
            {
                if (minutos <= tiempo)
                {
                    return retorno + valor;
                }
                else
                {
                    retorno = retorno + valor;
                    tiempo = tiempo * 2;
                }
            } while (tiempo <= minutos);

             return retorno;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Indentificador: {this.Identificador} ");
            sb.Append($"Indentificador: {this.CostoDeUso} ");
            sb.Append($"Indentificador: {this.minutos} ");
            sb.Append($"Indentificador: {this.activo} ");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Servicios s1, Servicios s2)
        {
            if (object.ReferenceEquals(s1, null) || object.ReferenceEquals(s2, null))
            {
                return false;
            }
            else
            {
                if (s1.Identificador == s2.Identificador)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Servicios s1, Servicios s2)
        {
            return !(s1 == s2);
        }
        public override bool Equals(object obj)
        {
            return obj is Servicios servicios &&
                   Identificador == servicios.Identificador &&
                   CostoDeUso == servicios.CostoDeUso;
        }

        public override int GetHashCode()
        {
            int hashCode = -1922181091;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Identificador);
            hashCode = hashCode * -1521134295 + CostoDeUso.GetHashCode();
            return hashCode;
        }
        #endregion
    }
}
