using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ESoftware {
        ofice,
        messenger,
        icq,
        ares
    }
    public enum EPerifericos {
        camara,
        auriculares,
        microfono
    }
    public enum EJuegos
    {
        camara,
        auriculares,
        microfono
    }
    public class Computadora:Servicios
    {
        List<ESoftware> listaDeSorftwareIstalado;
        List<EPerifericos> listaDePerifericos;
        List<EJuegos> listaDeJuegos;

        #region Propiedades
        public override string Identificador
        {
            set {
                if (this.ValidarIdentificador(value))
                    base.Identificador = value;
                else
                    base.Identificador = "Error al identificador";

            }
            get { return base.Identificador; }
        }
        public override float CostoDeUso
        {
            set { base.CostoDeUso = Costo(base.minutos, "0,5"); }
            get { return base.CostoDeUso; }
        }
        public string SofwareInstalados
        {
            get { return MostrarLista(this.listaDeSorftwareIstalado); }
        }
        public string Perifericos
        {
            get { return MostrarLista(this.listaDePerifericos); }
        }
        public string Juegos
        {
            get { return MostrarLista(this.listaDeJuegos); }
        }
        #endregion

        #region Constructores

        #endregion

        #region Metodos
        private string MostrarLista(List<ESoftware> softInstalados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ESoftware item in softInstalados)
            {
                sb.Append($"{item.ToString()} ");
            }
            return sb.ToString();
        }
        private string MostrarLista(List<EPerifericos> perifericos)
        {
            StringBuilder sb = new StringBuilder();
            foreach (EPerifericos item in perifericos)
            {
                sb.Append($"{item.ToString()} ");
            }
            return sb.ToString();
        }
        private string MostrarLista(List<EJuegos> juegos)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ESoftware item in juegos)
            {
                sb.Append($"{item.ToString()} ");
            }
            return sb.ToString();
        }
        #endregion

        #region Override
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
        public override bool ValidarIdentificador(string codigo)
        {
            if (codigo[0] == 'C')
                return true;
            return false;
        }
        #endregion
    }
}
