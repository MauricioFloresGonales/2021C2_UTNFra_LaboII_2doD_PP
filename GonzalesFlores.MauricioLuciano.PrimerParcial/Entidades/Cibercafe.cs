using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Cibercafe
    {
        static Queue<Computadora> filaDeComputadoras;
        static Queue<Telefono> filaDeTelefonos;

        #region Constructores
        static Cibercafe()
        {
            filaDeComputadoras = new Queue<Computadora>();
            filaDeTelefonos = new Queue<Telefono>();
        }
        #endregion

        #region Hardcodeo
        public static void HardcodeoDedatos()
        {
            Hardware hw1 = new Hardware(1, EProcesador.Generico, ERam.Ram100, EPlacaGrafica.integrada);
            Hardware hw2 = new Hardware(1, EProcesador.Generico, ERam.Ram100, EPlacaGrafica.integrada);
            Hardware hw3 = new Hardware(1, EProcesador.Generico, ERam.Ram200, EPlacaGrafica.integrada);
            Hardware hw4 = new Hardware(1, EProcesador.intel, ERam.Ram200, EPlacaGrafica.gaming);
            Hardware hw5 = new Hardware(1, EProcesador.intel, ERam.Ram300, EPlacaGrafica.gaming);

            List<ESoftware> soft1 = new List<ESoftware>();
            List<ESoftware> soft2 = new List<ESoftware>();
            List<ESoftware> soft3 = new List<ESoftware>();
            List<ESoftware> soft4 = new List<ESoftware>();
            List<ESoftware> soft5 = new List<ESoftware>();

            List<EPerifericos> peri1 = new List<EPerifericos>();
            List<EPerifericos> peri2 = new List<EPerifericos>();
            List<EPerifericos> peri3 = new List<EPerifericos>();
            List<EPerifericos> peri4 = new List<EPerifericos>();
            List<EPerifericos> peri5 = new List<EPerifericos>();

            List<EJuegos> juegos1 = new List<EJuegos>();
            List<EJuegos> juegos2 = new List<EJuegos>();
            List<EJuegos> juegos3 = new List<EJuegos>();
            List<EJuegos> juegos4 = new List<EJuegos>();
            List<EJuegos> juegos5 = new List<EJuegos>();

            Computadora pc1 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc2 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc3 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc4 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc5 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc6 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc7 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc8 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc9 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc10 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);

            Telefono tel1 = new Telefono("1", 1, 1, false, ETipo.aDisco, EMarca.nokia, ETipoLlamada.Internacional, "1");
            Telefono tel2 = new Telefono("1", 1, 1, false, ETipo.aDisco, EMarca.nokia, ETipoLlamada.Internacional, "1");
            Telefono tel3 = new Telefono("1", 1, 1, false, ETipo.aDisco, EMarca.nokia, ETipoLlamada.Internacional, "1");
            Telefono tel4 = new Telefono("1", 1, 1, false, ETipo.aDisco, EMarca.nokia, ETipoLlamada.Internacional, "1");
            Telefono tel5 = new Telefono("1", 1, 1, false, ETipo.aDisco, EMarca.nokia, ETipoLlamada.Internacional, "1");
        }
        #endregion

        #region Metodos Computadora
        public static Queue<Computadora> AgregarAFila(Queue<Computadora> listaDeCP, Computadora cp)
        {
            if (listaDeCP != null && cp != null)
            {
                listaDeCP.Enqueue(cp);
            }
            return listaDeCP;
        }
        public static Computadora RetirarDeLaFila(Queue<Computadora> listaDeCP)
        {
            if (listaDeCP != null)
            {
                return listaDeCP.Dequeue();
            }
            throw new Exception("La fila de coputadoras esta vacia.");
        }
        #endregion

        #region Metodos Telefonos
        public static Queue<Telefono> AgregarAFila(Queue<Telefono> listaDeTel, Telefono tel)
        {
            if (listaDeTel != null && tel != null)
            {
                listaDeTel.Enqueue(tel);
            }
            return listaDeTel;
        }
        public static Telefono RetirarDeLaFila(Queue<Telefono> listaDeTel)
        {
            if (listaDeTel != null)
            {
                return listaDeTel.Dequeue();
            }
            throw new Exception("La fila de coputadoras esta vacia.");
        }
        #endregion
    }
}
