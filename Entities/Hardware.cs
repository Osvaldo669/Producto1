using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hardware
    {
        public int Clave { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Descripcion { get; set; }

        public string Imagen1 { get; set; }
        public string Imagen2 { get; set; }


        public string MostrarDatos()
        {
            return "Clave:  " + this.Clave + "   Categoria:  " + this.Categoria; ;
            
        }



    }
}
