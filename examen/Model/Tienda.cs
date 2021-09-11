using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Model
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prenda> listadoPrendas;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Prenda> ListadoPrendas { get => listadoPrendas; set => listadoPrendas = value; }

        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            listadoPrendas = new List<Prenda>();
        }
        public void CargarCamisas()
        {
            //Camisas Manga Corta
            listadoPrendas.Add(new Camisa("Standard", 100, "corta", "mao"));
            listadoPrendas.Add(new Camisa("Premium", 100, "corta", "mao"));
            listadoPrendas.Add(new Camisa("Standard", 150, "corta", "comun"));
            listadoPrendas.Add(new Camisa("Premium", 150, "corta", "comun"));

            //Camisas Manga Larga
            listadoPrendas.Add(new Camisa("Standard", 75, "larga", "mao"));
            listadoPrendas.Add(new Camisa("Premium", 75, "larga", "mao"));
            listadoPrendas.Add(new Camisa("Standard", 175, "larga", "comun"));
            listadoPrendas.Add(new Camisa("Premium", 175, "larga", "comun"));


            #region
            //for (int mc = 1; mc <= 500; mc++) //500 manga corta
            //{
            //    if (mc <= 200)//200 cuello mao
            //    {
            //        if (mc <= 100)//100 calidad Standard
            //        {


            //        }
            //        if (mc > 100)//100 calidad Premium
            //        {


            //        }

            //    }
            //    else if (mc > 200)//300 cuello comun
            //    {
            //        if (mc <= 350)//150 calidad Standard
            //        {


            //        }
            //        if (mc <= 500)//150 calidad Premium
            //        {


            //        }

            //    }

            //}

            //for (int ml = 1; ml <= 500; ml++)   //500 manga larga
            //{
            //    if (ml <= 150)                  //150 cuello mao
            //    {
            //        if (ml <= 75)               //100 calidad Standard
            //        {


            //        }
            //        if (ml >= 150)              //100 calidad Premium
            //        {


            //        }

            //    }
            //    else if (ml > 150)              //350 cuello comun
            //    {
            //        if (ml <= 325)              //175 calidad Standard
            //        {


            //        }
            //        if (ml <= 500)              //175 calidad Premium
            //        {


            //        }

            //    }

            //}
            #endregion

        }
        public void CargarPantalones()
        {
            //Pantalones chupin
            listadoPrendas.Add(new Pantalon("Standard", 750, "chupin" ));
            listadoPrendas.Add(new Pantalon("Premium", 750, "chupin"));
            //Pantalones normal
            listadoPrendas.Add(new Pantalon("Standard", 250, "normal" ));
            listadoPrendas.Add(new Pantalon("Premium", 250, "normal"));
        }

      
    }
}
