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
        static Queue<Cliente> filaDeClientes;


        public static List<Computadora> ListaDeComputadoras
        {
            get { return listaDeComputadoras; }
        }
        public static List<Telefono> ListaDeTelefonos
        {
            get { return listaDeTelefonos; }
        }
        public static Queue<Cliente> FilaDeClientes
        {
            get { return filaDeClientes; }
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

            Computadora pc1 = new Computadora("1", false, soft1, peri1, juegos1, hw1);
            Computadora pc2 = new Computadora("2", false, soft1, peri1, juegos1, hw1);
            Computadora pc3 = new Computadora("3", false, soft1, peri1, juegos1, hw1);
            Computadora pc4 = new Computadora("4", false, soft1, peri1, juegos1, hw1);
            Computadora pc5 = new Computadora("5", false, soft1, peri1, juegos1, hw1);
            Computadora pc6 = new Computadora("6", false, soft1, peri1, juegos1, hw1);
            Computadora pc7 = new Computadora("7", false, soft1, peri1, juegos1, hw1);
            Computadora pc8 = new Computadora("8", false, soft1, peri1, juegos1, hw1);
            Computadora pc9 = new Computadora("9", false, soft1, peri1, juegos1, hw1);
            Computadora pc10 = new Computadora("10", false, soft1, peri1, juegos1, hw1);

            AgregarALista(pc1);
            AgregarALista(pc2);
            AgregarALista(pc3);
            AgregarALista(pc4);
            AgregarALista(pc5);
            AgregarALista(pc6);
            AgregarALista(pc7);
            AgregarALista(pc8);
            AgregarALista(pc9);
            AgregarALista(pc10);

            Telefono tel1 = new Telefono("1", false, ETipo.aDisco, EMarca.telefonica);
            Telefono tel2 = new Telefono("2", false, ETipo.aDisco, EMarca.nokia);
            Telefono tel3 = new Telefono("3", false, ETipo.conTeclado, EMarca.samsung);
            Telefono tel4 = new Telefono("4", false, ETipo.conTeclado, EMarca.nokia);
            Telefono tel5 = new Telefono("5", false, ETipo.conTeclado, EMarca.telefonica);

            AgregarALista(tel1);
            AgregarALista(tel2);
            AgregarALista(tel3);
            AgregarALista(tel4);
            AgregarALista(tel5);

            Cliente cl1 = new Cliente("Uno", "Telefono", 30, "123", ETipoLlamada.Internacional);
            Cliente cl2 = new Cliente("Dos", "Telefono", 30, "345", ETipoLlamada.largaDistancia);
            Cliente cl3 = new Cliente("Tres", "Telefono", 60, "567", ETipoLlamada.local);
            Cliente cl4 = new Cliente("Cuatro", "Computadora", 30);
            Cliente cl5 = new Cliente("Cinco", "Computadora", 30);
            Cliente cl6 = new Cliente("Seis", "Computadora", 30);
            Cliente cl7 = new Cliente("Siete", "Computadora", 30);

            AgregarALista(cl1);
            AgregarALista(cl2);
            AgregarALista(cl3);
            AgregarALista(cl4);
            AgregarALista(cl5);
            AgregarALista(cl6);
            AgregarALista(cl7);
        }
        #endregion

        #region Clientes
        public static void AgregarALista(Cliente cl)
        {
            try
            {
                if (filaDeClientes == null)
                {
                    filaDeClientes.Enqueue(cl);
                }
                foreach (Computadora item in listaDeComputadoras)
                {
                    filaDeClientes.Enqueue(cl);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static Cliente RetirarCliente(Cliente cl)
        {
            try
            {
                if (filaDeClientes != null)
                {
                    foreach (Cliente item in filaDeClientes)
                    {
                        if (item == cl)
                        {

                            return filaDeClientes.Dequeue();
                        }
                    }
                    throw new Exception("El cliente que se quiere retirar de la fila no esta en la fila.");
                }
                throw new Exception("La fila de clientes esta vacia.");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        #endregion

        #region Metodos Computadora
        public static void AgregarALista( Computadora pc)
        {
            try
            {
                if (listaDeComputadoras == null)
                {
                    listaDeComputadoras.Add(pc);
                }
                foreach (Computadora item in listaDeComputadoras)
                {
                    if (item != pc)
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
        public static bool RetirarDeLaListaPC(Computadora pc)
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
                throw new Exception("La lista de pc's esta vacia.");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static void ComputadoraAUsar(Cliente cl)
        {
            foreach (Computadora item in listaDeComputadoras)
            {
                if (item.activo == false)
                {
                    item.activo = true;
                    item.minutos = cl.Minutos;
                }
            }
        }
        public static void ComputadoraLiberar(Computadora pc)
        {
            foreach (Computadora item in listaDeComputadoras)
            {
                if (item.Identificador == pc.Identificador)
                {
                    item.activo = false;
                    item.minutos = 0;
                }
            }
        }
        #endregion

        #region Metodos Telefonos
        public static void AgregarALista(Telefono tel)
        {
            try
            {
                if (listaDeTelefonos == null)
                {

                    listaDeTelefonos.Add(tel);
                }
                foreach (Telefono item in listaDeTelefonos)
                {
                    if (item != tel)
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
        public static bool RetirarDeLaListaTel(Telefono tel)
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
                throw new Exception("La lista de Telefonos esta vacia.");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static Telefono TelefonoAUsar(Cliente cl)
        {
            foreach (Telefono item in listaDeTelefonos)
            {
                if (item.activo == false)
                {
                    item.activo = true;
                    item.minutos = cl.Minutos;
                    item.TipoDeLlamadaSet = cl.TipoDeLlamada;
                    return item;
                }
            }
            throw new Exception("No hay un telefono disponible");
        }
        public static void TelefonoALiberar(Telefono tel)
        {
            foreach (Telefono item in listaDeTelefonos)
            {
                if (tel.Identificador == tel.Identificador)
                {
                    tel.activo = false;
                    tel.minutos = 0;
                }
            }
        }
        #endregion

        #region Cliente
        public static void ElejirServicio(Cliente cl)
        {
            if (cl.Servicio == "Computadora")
            {
                ComputadoraAUsar(cl);
            }
            if (cl.Servicio == "Telefono")
            {
                TelefonoAUsar(cl);
            }
        }
        #endregion
    }
}
