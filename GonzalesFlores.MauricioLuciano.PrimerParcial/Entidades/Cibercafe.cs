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
        static Queue<Cliente> filaDeClientesPC;
        static Queue<Cliente> filaDeClientesTel;

        #region Propiedades
        public static List<Computadora> ListaDeComputadoras
        {
            get { return listaDeComputadoras; }
        }
        public static List<Telefono> ListaDeTelefonos
        {
            get { return listaDeTelefonos; }
        }
        public static Queue<Cliente> FilaDeClientesPC
        {
            get { return filaDeClientesPC; }
        }
        public static Queue<Cliente> FilaDeClientesTel
        {
            get { return filaDeClientesTel; }
        }
        #endregion

        #region Constructores
        static Cibercafe()
        {
            listaDeComputadoras = new List<Computadora>();
            listaDeTelefonos = new List<Telefono>();
            filaDeClientesPC = new Queue<Cliente>();
            filaDeClientesTel = new Queue<Cliente>();
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

            listaDeComputadoras+=pc1;
            listaDeComputadoras+=pc2;
            listaDeComputadoras+=pc3;
            listaDeComputadoras+=pc4;
            listaDeComputadoras+=pc5;
            listaDeComputadoras+=pc6;
            listaDeComputadoras+=pc7;
            listaDeComputadoras+=pc8;
            listaDeComputadoras+=pc9;
            listaDeComputadoras+=pc10;

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

            Cliente cl1 = new Cliente("1", "Uno", "", 1,"Telefono", 30, "123", ETipoLlamada.Internacional);
            Cliente cl2 = new Cliente("2", "Dos", "", 2, "Telefono", 30, "345", ETipoLlamada.largaDistancia);
            Cliente cl3 = new Cliente("3", "Tres", "", 3, "Telefono", 60, "567", ETipoLlamada.local);
            Cliente cl4 = new Cliente("4", "Cuatro", "", 4, "Computadora", 90);
            Cliente cl5 = new Cliente("5", "Cinco", "", 5, "Computadora", 30);
            Cliente cl6 = new Cliente("6", "Seis", "", 6, "Computadora", 120);
            Cliente cl7 = new Cliente("7", "Siete", "", 7 ,"Computadora", 220);
            Cliente cl8 = new Cliente("8", "Uno", "", 8, "Telefono", 30, "123", ETipoLlamada.Internacional);
            Cliente cl9 = new Cliente("9", "Dos", "", 9, "Telefono", 30, "345", ETipoLlamada.largaDistancia);
            Cliente cl10 = new Cliente("10", "Tres", "", 10, "Telefono", 60, "567", ETipoLlamada.local);
            Cliente cl11 = new Cliente("11", "Cuatro", "", 11, "Computadora", 90);
            Cliente cl12 = new Cliente("12", "Cinco", "", 12, "Computadora", 30);
            Cliente cl13 = new Cliente("13", "Seis", "", 13, "Computadora", 120);
            Cliente cl14= new Cliente("14", "Siete", "", 14, "Computadora", 220);

            AgregarALista(cl1);
            AgregarALista(cl2);
            AgregarALista(cl3);
            AgregarALista(cl4);
            AgregarALista(cl5);
            AgregarALista(cl6);
            AgregarALista(cl7);
            AgregarALista(cl8);
            AgregarALista(cl9);
            AgregarALista(cl10);
            AgregarALista(cl11);
            AgregarALista(cl12);
            AgregarALista(cl13);
            AgregarALista(cl14);
        }
        #endregion

        #region Clientes
        public static void AgregarALista(Cliente cl)
        {
            try
            {
                if (cl.Servicio == "Computadora")
                {
                    filaDeClientesPC+=cl;
                } else
                {
                    filaDeClientesTel+=cl;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static Cliente RetirarCliente(string servicio)
        {
            try
            {
                if (servicio == "Computadora")
                {
                    if (filaDeClientesPC != null)
                    {
                        foreach (Cliente item in filaDeClientesPC)
                        {
                            if (item.Servicio == servicio)
                            {
                                return filaDeClientesPC.Dequeue();
                            }
                        }
                        throw new Exception("El cliente que se quiere retirar de la fila no esta en la fila.");
                    }
                    throw new Exception("La fila de clientes esta vacia.");
                }
                else
                {
                    if (filaDeClientesTel != null)
                    {
                        foreach (Cliente item in filaDeClientesTel)
                        {
                            if (item.Servicio == servicio)
                            {
                                return filaDeClientesTel.Dequeue();
                            }
                        }
                        throw new Exception("El cliente que se quiere retirar de la fila no esta en la fila.");
                    }
                    throw new Exception("La fila de clientes esta vacia.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static bool ElejirServicio(Cliente cl, string idServicio)
        {
            if (cl.Servicio == "Computadora")
            {
                return ComputadoraAUsar(idServicio, cl.Minutos);
            }
            if (cl.Servicio == "Telefono")
            {
                return TelefonoAUsar(cl, idServicio, cl.Minutos);
            }
            throw new Exception("Error, en ElejirServicio");
        }
        #endregion

        #region Metodos Computadora
        public static Computadora RecibirPC(string idPc)
        {
            try
            {
                if (listaDeComputadoras.Count >= 1)
                {
                    foreach (Computadora item in listaDeComputadoras)
                    {
                        if (item.Identificador == idPc)
                        {
                            return item;
                        }
                    }
                    throw new Exception("La pc que se requiere no esta en la lista.");
                }
                throw new Exception("La lista de pc's esta vacia.");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static bool ComputadoraAUsar(string index, int minutos)
        {
            try
            {
                foreach (Computadora item in listaDeComputadoras)
                {
                    if (item == RecibirPC(index))
                    {
                        return item + minutos;
                    }
                }
                return false;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static void ComputadoraLiberar(string idPc)
        {
            try
            {
                if (Computadora.Liberar(listaDeComputadoras, idPc) == false)
                {
                    throw new Exception("No se pudo liberar la PC que solicitó");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        #endregion

        #region Metodos Telefonos
        public static void AgregarALista(Telefono tel)
        {
            try
            {
                if (listaDeTelefonos.Count == 0)
                {

                    listaDeTelefonos.Add(tel);
                } else
                {
                    foreach (Telefono item in listaDeTelefonos)
                    {
                        if (item == tel)
                        {
                            throw new Exception("La computadora ya existe");
                        }
                    }
                    listaDeTelefonos.Add(tel);
                }
                
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static Telefono RecibirTel(int index)
        {
            try
            {
                if (listaDeTelefonos.Count >= 1)
                {
                    if (listaDeTelefonos.Count >= index)
                    {
                        return listaDeTelefonos[index];
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
        public static bool TelefonoAUsar(Cliente cl,int index, int minutos)
        {
            foreach (Telefono item in listaDeTelefonos)
            {
                if (item == RecibirTel(index))
                {
                    item.activo = true;
                    item.minutos = minutos;
                    item.CostoDeUso = cl.Minutos;
                    item.TipoDeLlamadaSet = cl.TipoDeLlamada;
                    return item.activo;
                }
            }
            throw new Exception("No hay un telefono disponible");
        }
        public static void TelefonoALiberar(int index)
        {
            foreach (Telefono tel in listaDeTelefonos)
            {
                if (tel == RecibirTel(index))
                {
                    tel.activo = false;
                    tel.minutos = 0;
                    tel.CostoDeUso = 0;
                }
            }
        }
        #endregion
    }
}
