using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entities;

namespace WebPresentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClassBussinesLogic classBL = new ClassBussinesLogic();
        Hardware hardware= new Hardware();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cad = "";

            cad = classBL.InsertarHardaware(new NodoLista(new Hardware() { 
                Clave=1233,
                Categoria="Tarjeta Madre",
                Marca="Asus",
                Modelo="Tx100",
                Serie="series 5",
                Descripcion="La mejor del mercado",
                Imagen1= "https://static-geektopia.com/storage/t/p/540/54025/816x381/file-270fa1dcbebe770b3b.webp",
                Imagen2= "https://static-geektopia.com/storage/t/p/540/54025/816x381/file-270fa1dcbebe770b3b.webp",

            }) );
            TextBox1.Text = cad;


            cad = classBL.InsertarHardaware(new NodoLista(new Hardware()
            {
                Clave = 1454,
                Categoria = "Tarjeta Madre",
                Marca = "Asus",
                Modelo = "Tx100",
                Serie = "series 5",
                Descripcion = "La mejor del mercado",
                Imagen1 = "https://static-geektopia.com/storage/t/p/540/54025/816x381/file-270fa1dcbebe770b3b.webp",
                Imagen2 = "https://static-geektopia.com/storage/t/p/540/54025/816x381/file-270fa1dcbebe770b3b.webp",

            }));
            TextBox2.Text = cad;

            string[] array = null;
            array = classBL.MostrarHarware();
            TextBox3.Text = "";
            foreach(string item in array)
            {
                TextBox3.Text =item+ "  ........  " + TextBox3.Text  ;
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string msg = "";
            int clave = Convert.ToInt16((TextBox4.Text));

            msg = classBL.BuscarHardware(clave);

            TextBox5.Text = msg;
        }
    }
}