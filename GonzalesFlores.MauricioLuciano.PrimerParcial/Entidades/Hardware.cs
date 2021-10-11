using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EProcesador
    {
        intel,
        Generico
    }
    public enum ERam
    {
        Ram100,
        Ram200,
        Ram300
    }
    public enum EPlacaGrafica
    {
        integrada,
        gaming
    }
    public class Hardware
    {
        int codigo;
        EProcesador procesador;
        ERam ram;
        EPlacaGrafica placaGrafica;

        public Hardware(int codigo, EProcesador procesador, ERam ram, EPlacaGrafica placaGrafica)
        {
            this.codigo = codigo;
            this.procesador = procesador;
            this.ram = ram;
            this.placaGrafica = placaGrafica;
        }

        #region Propiedades
        public int Codigo
        {
            get { return this.codigo; }
        }
        public string Procesador
        {
            get { return this.procesador.ToString(); }
        }
        public string Ram
        {
            get { return this.ram.ToString(); }
        }
        public string PlacaGrafica
        {
            get { return this.placaGrafica.ToString(); }
        }
        #endregion

        #region Metodos
        public string  MostrarCaracteristicas()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Procesador} ");
            sb.Append($"- {this.Ram} ");
            sb.Append($"- {this.PlacaGrafica}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Hardware h1, Hardware h2)
        {
            if (h1.Codigo == h2.Codigo)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Hardware h1, Hardware h2)
        {
            return (h1 == h2);
        }
        #endregion
    }
}
