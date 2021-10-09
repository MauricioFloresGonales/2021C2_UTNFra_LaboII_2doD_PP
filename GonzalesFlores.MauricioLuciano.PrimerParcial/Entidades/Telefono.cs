using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipo {
        loca,
        largaDistancia,
        Internacional
    }
    public class Telefono: Servicios
    {
        ETipo tipoDeLlamada;
        public string numeroLlamado;


        #region Propiedades
        public override string Identificador
        {
            set
            {
                if (this.ValidarIdentificador(value))
                    base.Identificador = value;
                else
                    base.Identificador = "Error al identificador";

            }
            get { return base.Identificador; }
        }
        public override float CostoDeUso
        {
            set { base.CostoDeUso = CalcularCosto(this.tipoDeLlamada); }
            get { return base.CostoDeUso; }
        }
        public string TipoDeLlamada
        {
            get 
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{this.tipoDeLlamada.ToString()}");
                return sb.ToString();
            }
        }
        public string NumeroLlamado
        {
            get{ return this.numeroLlamado; }
        }
        #endregion

        #region Constructores
        public Telefono() : base()
        {
            base.Identificador = "T";
        }
        public Telefono(string identidicador, float costoDeUso, int minutos, bool activo, ETipo tipoDeLlamada, string numeroLlamado) : base(costoDeUso, minutos, activo)
        {
            base.Identificador = base.AgregarCodigo("T", identidicador);
            this.tipoDeLlamada = tipoDeLlamada;
            this.numeroLlamado = numeroLlamado;
        }
        #endregion

        #region Metodos
        private float CalcularCosto(ETipo tipo)
        {
            switch (tipo)
            {
                case ETipo.loca:
                    return Costo(base.minutos, "1");
                case ETipo.largaDistancia:
                    return Costo(base.minutos, "2,5");
                case ETipo.Internacional:
                    return Costo(base.minutos, "5");
                default:
                    return 0;
            }
        }
        private string MostrarTipoDeLlamada()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.tipoDeLlamada.ToString()} ");
            return sb.ToString();
        }
        #endregion

        #region Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo de Llamado: {this.TipoDeLlamada}");
            sb.AppendLine($"Numero Llamado:{this.NumeroLlamado}");

            return sb.ToString();
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"Tipo de Llamado: {this.TipoDeLlamada} ");
            sb.Append($"Numero Llamado:{this.NumeroLlamado}");

            return sb.ToString();
        }
        public override bool ValidarIdentificador(string codigo)
        {
            if (codigo[0] == 'T')
                return true;
            return false;
        }
        #endregion
    }
}
