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
        static float gananciasDelDia;

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
        public static float GananciasDelDia
        {
            get { return gananciasDelDia; }
            set { gananciasDelDia = value; }
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
            List<ESoftware> soft3 = new List<ESoftware>();
            soft3.Add(ESoftware.ofice);

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
            List<EJuegos> juegos4 = new List<EJuegos>();
            juegos4.Add(EJuegos.MuOnline);

            Computadora pc1 = new Computadora("1", false, soft3, peri1, juegos4, hw4);
            Computadora pc2 = new Computadora("2", false, soft2, peri3, juegos1, hw1);
            Computadora pc3 = new Computadora("3", false, soft1, peri1, juegos2, hw2);
            Computadora pc4 = new Computadora("4", false, soft2, peri2, juegos2, hw1);
            Computadora pc5 = new Computadora("5", false, soft2, peri1, juegos1, hw1);
            Computadora pc6 = new Computadora("6", false, soft1, peri2, juegos1, hw2);
            Computadora pc7 = new Computadora("7", false, soft2, peri3, juegos1, hw4);
            Computadora pc8 = new Computadora("8", false, soft1, peri3, juegos2, hw3);
            Computadora pc9 = new Computadora("9", false, soft2, peri1, juegos3, hw4);
            Computadora pc10 = new Computadora("10", false, soft1, peri3, juegos3, hw3);

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

            Cliente cl1 = new Cliente("1", "Uno", "Uno", 1,"Telefono", 30, "123", ETipoLlamada.Internacional);
            Cliente cl2 = new Cliente("2", "Dos", "Dos", 2, "Telefono", 30, "345", ETipoLlamada.largaDistancia);
            Cliente cl3 = new Cliente("3", "Tres", "Tres", 3, "Telefono", 60, "567", ETipoLlamada.local);
            Cliente cl4 = new Cliente("4", "Cuatro", "Cuatro", 4, "Computadora", 90, new Computadora(new List<ESoftware> {ESoftware.messenger}, new List<EJuegos> { EJuegos.ninguno }, new Hardware(EProcesador.Generico,ERam.Ram200,EPlacaGrafica.gaming)));
            Cliente cl5 = new Cliente("5", "Cinco", "Cinco", 5, "Computadora", 30, new Computadora(new List<ESoftware> { ESoftware.icq }, new List<EJuegos> { EJuegos.MuOnline }, new Hardware(EProcesador.intel, ERam.Ram300, EPlacaGrafica.integrada)));
            Cliente cl6 = new Cliente("6", "Seis", "Seis", 6, "Computadora", 120, new Computadora(new List<ESoftware> { ESoftware.messenger }, new List<EJuegos> { EJuegos.DiabloII }, new Hardware(EProcesador.Generico, ERam.Ram200, EPlacaGrafica.gaming)));
            Cliente cl7 = new Cliente("7", "Siete", "Siete", 7 ,"Computadora", 220, new Computadora(new List<ESoftware> { ESoftware.ares }, new List<EJuegos> { EJuegos.WarcraftIII }, new Hardware(EProcesador.intel, ERam.Ram100, EPlacaGrafica.integrada)));
            Cliente cl8 = new Cliente("8", "Uno", "Uno", 8, "Telefono", 30, "123", ETipoLlamada.Internacional);
            Cliente cl9 = new Cliente("9", "Dos", "Dos", 9, "Telefono", 30, "345", ETipoLlamada.largaDistancia);
            Cliente cl10 = new Cliente("10", "Tres", "Tres", 10, "Telefono", 60, "567", ETipoLlamada.local);
            Cliente cl11 = new Cliente("11", "Cuatro", "Cuatro", 11, "Computadora", 90, new Computadora(new List<ESoftware> { ESoftware.ofice }, new List<EJuegos> { EJuegos.LineageII }, new Hardware(EProcesador.intel, ERam.Ram100, EPlacaGrafica.integrada)));
            Cliente cl12 = new Cliente("12", "Cinco", "Cinco", 12, "Computadora", 30, new Computadora(new List<ESoftware> { ESoftware.icq }, new List<EJuegos> { EJuegos.MuOnline }, new Hardware(EProcesador.Generico, ERam.Ram100, EPlacaGrafica.gaming)));
            Cliente cl13 = new Cliente("13", "Seis", "Seis", 13, "Computadora", 120, new Computadora(new List<ESoftware> { ESoftware.ares}, new List<EJuegos> { EJuegos.WarcraftIII }, new Hardware(EProcesador.intel, ERam.Ram200, EPlacaGrafica.integrada)));
            Cliente cl14= new Cliente("14", "Siete", "Siete", 14, "Computadora", 220, new Computadora(new List<ESoftware> { ESoftware.ares}, new List<EJuegos> { EJuegos.AgeOfEmpiresII }, new Hardware(EProcesador.Generico, ERam.Ram300, EPlacaGrafica.gaming)));

            AgregarAFila(cl1);
            AgregarAFila(cl2);
            AgregarAFila(cl3);
            AgregarAFila(cl4);
            AgregarAFila(cl5);
            AgregarAFila(cl6);
            AgregarAFila(cl7);
            AgregarAFila(cl8);
            AgregarAFila(cl9);
            AgregarAFila(cl10);
            AgregarAFila(cl11);
            AgregarAFila(cl12);
            AgregarAFila(cl13);
            AgregarAFila(cl14);
        }
        #endregion

        #region Clientes
        public static Queue<Cliente> FilaSegunServicio(string servicio)
        {
            try
            {
                if (servicio == "Computadora")
                {
                    return filaDeClientesPC;
                }
                else
                {
                    return filaDeClientesTel;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static void AgregarAFila(Cliente cl)
        {
            try
            {
                Queue<Cliente> auxCliente = FilaSegunServicio(cl.Servicio);
                auxCliente += cl;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static bool RetirarCliente(string servicio)
        {
            try
            {
                Queue<Cliente> auxCliente = FilaSegunServicio(servicio);
                if (auxCliente != null)
                {
                    foreach (Cliente item in auxCliente)
                    {
                        if (item.Servicio == servicio)
                        {
                        auxCliente.Dequeue();
                            return true;
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
        public static bool ElejirServicio(Cliente cl, string idServicio)
        {
            if (cl.Servicio == "Computadora")
            {
                if (Computadora.VerificarPosiblePc(listaDeComputadoras, cl.PcRequerida))
                {
                    if (ComputadoraAUsar(idServicio, cl))
                    {
                        return Cibercafe.RetirarCliente(cl.Servicio);
                    }
                }
                throw new Exception("No hay una PC que cumpla con los requisitos del Cliente");
            }
            if (cl.Servicio == "Telefono")
            {
                if (TelefonoAUsar(cl, idServicio, cl.Minutos))
                {
                    return Cibercafe.RetirarCliente(cl.Servicio);
                }
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
        public static bool ComputadoraAUsar(string index, Cliente cliente)
        {
            try
            {
                foreach (Computadora item in listaDeComputadoras)
                {
                    if (item == RecibirPC(index))
                    {
                        if (Computadora.ValidarPosiblePc(item, cliente.PcRequerida))
                        {
                            return item + cliente.Minutos;
                        }
                        throw new Exception("La PC elejida no cumple con los requicitos del Cliente");
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
                Cibercafe.GananciasDelDia += Computadora.Liberar(listaDeComputadoras, idPc);
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
        public static Telefono RecibirTel(string idTel)
        {
            try
            {
                if (listaDeTelefonos.Count >= 1)
                {
                    foreach (Telefono item in listaDeTelefonos)
                    {
                        if (item.Identificador == idTel)
                        {
                            return item;
                        }
                    }
                    throw new Exception("El telefono que se quiere  no esta en la lista.");
                }
                throw new Exception("La lista de Telefonos esta vacia.");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static bool TelefonoAUsar(Cliente cl,string id, int minutos)
        {
            try
            {
                Telefono aux = RecibirTel(id);
                foreach (Telefono item in listaDeTelefonos)
                {
                    if (item == aux)
                    {
                        item.CostoDeUso = cl.Minutos;
                        item.TipoDeLlamadaSet = cl.TipoDeLlamada;
                        item.LlamandoA = cl.NumeroALlamar;
                        return item + minutos;
                    }
                }
                throw new Exception("No hay un telefono disponible");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public static void TelefonoALiberar(string idTel)
        {
            try
            {
                Cibercafe.GananciasDelDia += Telefono.Liberar(listaDeTelefonos, idTel);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        #endregion
    }
}
