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
        CounterStrike,
        DiabloII,
        MuOnline,
        LineageII,
        WarcraftIII,
        AgeOfEmpiresII
    }
    public class Computadora : Servicios
    {
        List<ESoftware> listaDeSorftwareIstalado;
        List<EPerifericos> listaDePerifericos;
        List<EJuegos> listaDeJuegos;
        Hardware maquina;

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
        public string Maquina
        {
            get { return this.maquina.MostrarCaracteristicas(); }
        }
        #endregion

        #region Constructores

        public Computadora() : base()
        {
            base.Identificador = "C";
        }
        public Computadora(string identidicador,bool activo, List<ESoftware> listaDeSorftwareIstalado, List<EPerifericos> listaDePerifericos, List<EJuegos> listaDeJuegos, Hardware maquina) : base(activo)
        {
            base.Identificador = base.AgregarCodigo("C", identidicador);
            this.listaDeSorftwareIstalado = listaDeSorftwareIstalado;
            this.listaDePerifericos = listaDePerifericos;
            this.listaDeJuegos = listaDeJuegos;
            this.maquina = maquina;
        }

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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            int index = 1;
            foreach (ESoftware item in this.listaDeSorftwareIstalado)
            {
                sb.AppendLine("Software Instalado");
                sb.AppendLine($"{index}: {item.ToString()}");
                index++;
            }
            index = 1;
            foreach (ESoftware item in this.listaDePerifericos)
            {
                sb.AppendLine("Lista De Perifericos");
                sb.AppendLine($"{index}: {item.ToString()}");
                index++;
            }
            index = 1;
            foreach (ESoftware item in this.listaDeJuegos)
            {
                sb.AppendLine("Lista De Juegos");
                sb.AppendLine($"{index}: {item.ToString()}");
                index++;
            }
            sb.AppendLine("Hardware");
            sb.AppendLine(this.Maquina);

            return sb.ToString();
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append(this.ToString());

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
