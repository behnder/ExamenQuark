using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Model
{
    abstract class Prenda
    {
        private string calidad;
        private int precioUnitario;
        private int stock;

        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Calidad { get => calidad; set => calidad = value; }

        protected Prenda(string calidad,  int stock)
        {
            this.Calidad = calidad;
            
            this.Stock = stock;
        }

        public abstract void precioSegunTipo();
    }
}
