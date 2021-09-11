using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Model
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigoVendedor;
        private List<Cotizacion> historialCotizaciones;

        static int contadorCodigo = 0;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        internal List<Cotizacion> Historialcotizaciones { get => historialCotizaciones; set => historialCotizaciones = value; }

        public Vendedor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = contadorCodigo++;

        }

        public void RealizarCotizacion()
        {

        }
    }
}
