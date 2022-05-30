using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class NodoLista
    {
        public Hardware hardware;

        public NodoLista siguiente = null;

        public NodoLista(Hardware objnuev)
        {
            hardware = objnuev;
            siguiente = null;
        }

        public NodoLista(int clave, string categoria,
            string marca, string modelo, string serie,
            string descripcion, string imagen1, string imagen2)
        {
            hardware = new Hardware() {
                Clave = clave,
                Categoria = categoria,
                Marca = marca,
                Modelo = modelo,
                Serie = serie,
                Descripcion = descripcion,
                Imagen1 = imagen1,
                Imagen2 = imagen2,
            };

            siguiente = null;
        }
    }
}
