using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipo
    {
        aDisco,
        conTeclado
    }
    public enum EMarca
    {
        nokia,
        telefonica,
        samsung,
    }
    public enum ETipoLlamada {
        local,
        largaDistancia,
        Internacional
    }
    public class Telefono : Servicios
    {
        ETipo tipo;
        EMarca marca;
        ETipoLlamada tipoDeLlamada;


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
            set { base.CostoDeUso = value != 0 ? CalcularCosto(this.tipoDeLlamada) : 0; }
            get { return base.CostoDeUso; }
        }
        public ETipoLlamada TipoDeLlamadaSet
        {
            set { this.tipoDeLlamada = value; }
        }
        public string TipoDeLlamadaGet
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{this.tipoDeLlamada.ToString()}");
                return sb.ToString();
            }
        }
        public string Tipo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{this.tipo.ToString()}");
                return sb.ToString();
            }
        }
        public string Marca
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{this.marca.ToString()}");
                return sb.ToString();
            }
        }
        #endregion

        #region Constructores
        public Telefono() : base()
        {
            base.Identificador = "T";
        }
        public Telefono(string identidicador, bool activo, ETipo tipo, EMarca marca) : base(activo)
        {
            base.Identificador = base.AgregarCodigo("T", identidicador);
            this.tipo = tipo;
            this.marca = marca;
        }
        #endregion

        #region Metodos
        private float CalcularCosto(ETipoLlamada tipo)
        {
            switch (tipo)
            {
                case ETipoLlamada.local:
                    return Costo(base.minutos, "1");
                case ETipoLlamada.largaDistancia:
                    return Costo(base.minutos, "2,5");
                case ETipoLlamada.Internacional:
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
        private string LlamarA(string numero)
        {
            switch (this.TipoDeLlamadaGet)
            {
                case "largaDistancia":
                    return string.Concat("+54 9 11 ", numero);
                case "Internacional":
                    return string.Concat("0609 ", numero);
                default:
                    return string.Concat("011 ", numero);
            }
        }
        #endregion

        #region Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo de Llamado: {this.TipoDeLlamadaGet}");

            return sb.ToString();
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"Tipo de Llamado: {this.TipoDeLlamadaGet} ");

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
