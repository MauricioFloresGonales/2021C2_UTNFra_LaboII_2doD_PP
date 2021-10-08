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
