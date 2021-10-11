using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Cibercafe
    {
        static List<Computadora> listaDeComputadoras;
        static List<Telefono> listaDeTelefonos;


        public static List<Computadora> ListaDeComputadoras
        {
            get { return listaDeComputadoras; }
        }
        public static List<Telefono> ListaDeTelefonos
        {
            get { return listaDeTelefonos; }
        }

        #region Constructores
        static Cibercafe()
        {
            listaDeComputadoras = new List<Computadora>();
            listaDeTelefonos = new List<Telefono>();
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
            soft1.Add(ESoftware.ares);
            soft1.Add(ESoftware.messenger);
            soft1.Add(ESoftware.ofice);
            List<ESoftware> soft2 = new List<ESoftware>();
            soft2.Add(ESoftware.ofice);
            soft2.Add(ESoftware.messenger);
            soft2.Add(ESoftware.icq);

            List<EPerifericos> peri1 = new List<EPerifericos>();
            peri1.Add(EPerifericos.auriculares);
            List<EPerifericos> peri2 = new List<EPerifericos>();
            peri2.Add(EPerifericos.auriculares);
            peri2.Add(EPerifericos.microfono);
            List<EPerifericos> peri3 = new List<EPerifericos>();
            peri3.Add(EPerifericos.auriculares);
            peri3.Add(EPerifericos.microfono);
            peri3.Add(EPerifericos.camara);

            List<EJuegos> juegos1 = new List<EJuegos>();
            juegos1.Add(EJuegos.AgeOfEmpiresII);
            juegos1.Add(EJuegos.MuOnline);
            juegos1.Add(EJuegos.WarcraftIII);
            List<EJuegos> juegos2 = new List<EJuegos>();
            juegos2.Add(EJuegos.AgeOfEmpiresII);
            juegos2.Add(EJuegos.MuOnline);
            juegos2.Add(EJuegos.WarcraftIII);
            juegos2.Add(EJuegos.LineageII);
            juegos2.Add(EJuegos.DiabloII);
            List<EJuegos> juegos3 = new List<EJuegos>();
            juegos3.Add(EJuegos.AgeOfEmpiresII);
            juegos3.Add(EJuegos.MuOnline);
            juegos3.Add(EJuegos.WarcraftIII);
            juegos3.Add(EJuegos.LineageII);
            juegos3.Add(EJuegos.DiabloII);
            juegos3.Add(EJuegos.CounterStrike);

            Computadora pc1 = new Computadora("1", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc2 = new Computadora("2", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc3 = new Computadora("3", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc4 = new Computadora("4", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc5 = new Computadora("5", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc6 = new Computadora("6", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc7 = new Computadora("7", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc8 = new Computadora("8", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc9 = new Computadora("9", 1, 1, false, soft1, peri1, juegos1, hw1);
            Computadora pc10 = new Computadora("10", 1, 1, false, soft1, peri1, juegos1, hw1);

            Telefono tel1 = new Telefono("1", 1, 1, false, ETipo.aDisco, EMarca.telefonica, ETipoLlamada.Internacional, "1");
            Telefono tel2 = new Telefono("2", 1, 1, false, ETipo.aDisco, EMarca.nokia, ETipoLlamada.largaDistancia, "1");
            Telefono tel3 = new Telefono("3", 1, 1, false, ETipo.conTeclado, EMarca.samsung, ETipoLlamada.local, "1");
            Telefono tel4 = new Telefono("4", 1, 1, false, ETipo.conTeclado, EMarca.nokia, ETipoLlamada.local, "1");
            Telefono tel5 = new Telefono("5", 1, 1, false, ETipo.conTeclado, EMarca.telefonica, ETipoLlamada.Internacional, "1");

            AgregarAFila(pc1);
            AgregarAFila(pc2);
            AgregarAFila(pc3);
            AgregarAFila(pc4);
            AgregarAFila(pc5);
            AgregarAFila(pc6);
            AgregarAFila(pc7);
            AgregarAFila(pc8);
            AgregarAFila(pc9);
            AgregarAFila(pc10);

            AgregarAFila(tel1);
            AgregarAFila(tel2);
            AgregarAFila(tel3);
            AgregarAFila(tel4);
            AgregarAFila(tel5);
        }
        #endregion

        #region Metodos Computadora
        public static void AgregarAFila( Computadora pc)
        {
            try
            {
                if (listaDeComputadoras == null)
                {
                    listaDeComputadoras.Add(pc);
                }
                foreach (Computadora item in listaDeComputadoras)
                {
                    if (item == pc)
                    {
                        listaDeComputadoras.Add(pc);
                    }
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static bool RetirarDeLaFilaPC(Computadora pc)
        {
            try
            {
                if (listaDeComputadoras != null)
                {
                    foreach (Computadora item in listaDeComputadoras)
                    {
                        if (item == pc)
                        {

                            return listaDeComputadoras.Remove(pc);
                        }
                    }
                    throw new Exception("La pc que se quiere eliminar no esta en la lista.");
                }
                throw new Exception("La fila de pc's esta vacia.");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        #endregion

        #region Metodos Telefonos
        public static void AgregarAFila(Telefono tel)
        {
            try
            {
                if (listaDeTelefonos == null)
                {

                    listaDeTelefonos.Add(tel);
                }
                foreach (Telefono item in listaDeTelefonos)
                {
                    if (item == tel)
                    {

                        listaDeTelefonos.Add(tel);
                    }
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static bool RetirarDeLaFilaTel(Telefono tel)
        {
            try
            {
                if (listaDeTelefonos != null)
                {
                    foreach (Telefono item in listaDeTelefonos)
                    {
                        if (item == tel)
                        {

                            return listaDeTelefonos.Remove(tel);
                        }
                    }
                    throw new Exception("El telefono que se quiere eliminar no esta en la lista.");
                }
                throw new Exception("La fila de Telefonos esta vacia.");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        #endregion
    }
}
