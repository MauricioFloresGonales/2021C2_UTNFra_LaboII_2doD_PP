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

        public Servicios()
        {
            this.identificador = " ";
            this.costoDeUso = 0;
            this.minutos = 0;
            this.activo = false;
        }
        public Servicios(float costoDeUso, int minutos, bool activo) : base()
        {
            this.costoDeUso = costoDeUso;
            this.minutos = minutos;
            this.activo = activo;
        }
        public string AgregarCodigo(string identificador, string numero)
        {
            if (int.Parse(numero) > 9)
            {
                return string.Concat(identificador, this.Identificador, "0", numero);
            }
            return string.Concat(this.Identificador, numero);
        }
        public abstract bool ValidarIdentificador(string code);
        public float Costo(int minutos, string valorInicial)
        {
            int tiempo = 30;
            float valor = float.Parse(valorInicial);

            while (tiempo <= minutos)
            {
                valor = valor * 2;
                minutos = minutos * 2;
            }
            return valor;
        }
        public abstract string Mostrar();
    }
}
