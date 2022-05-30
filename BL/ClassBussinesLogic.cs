using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    public class ClassBussinesLogic
    {
        public AccesoDAL accesoDal=new AccesoDAL();

        public string InsertarHardaware(NodoLista nodoLista)
        {
            return accesoDal.InsertarHardware(nodoLista);
        }

        public string[] MostrarHarware() {
            return accesoDal.MostrarLista();
        }

        public string BuscarHardware(int clave)
        {
            string msg = "";
            NodoLista nodo = null;

            nodo = accesoDal.BuscarHardware(clave);
            if (nodo == null)
            {
                msg = "No encontrados";
            }
            else
            {
                msg = "Encontrado:   " + nodo.hardware.MostrarDatos(); 
            }
            return msg;
        }
    }
}
