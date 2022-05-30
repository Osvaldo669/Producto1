using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class AccesoDAL
    {
        //Nodo lista es el ancla
        private NodoLista nodoLista;
        private int cuentanodos = 0;

        public string InsertarHardware(NodoLista nuevo)
        {
            string msg = "";
            NodoLista temporal = null;

            if (nodoLista == null)
            {
                nodoLista = nuevo;
                msg = "Se inserto el primer elemento de hardware a la lista";
            }
            else
            {
                temporal = nodoLista;

                while (temporal.siguiente != null)
                {
                    temporal = temporal.siguiente;
                }

                temporal.siguiente = nuevo;
                msg = "Se agrego un nuevo hardware al final de la lista";
            }
            cuentanodos++;
            return msg;
        }

        public string[] MostrarLista()
        {
            string[] lista = new string[cuentanodos];
            NodoLista nodo = null;

            int c = 0;
            nodo = nodoLista;

            while (nodo != null)
            {
                lista[c] = nodo.hardware.MostrarDatos();
                c++;
                nodo = nodo.siguiente;
            }
            return lista;
        }

        public NodoLista BuscarHardware(int clave)
        {
            NodoLista nodo = null;
            NodoLista marca=null;

            nodo= nodoLista;
            while(nodo != null)
            {
                if (nodo.hardware.Clave == clave)
                {
                    marca=nodo;
                }
                nodo = nodo.siguiente;
            }

            return marca;
        }


    }
}
