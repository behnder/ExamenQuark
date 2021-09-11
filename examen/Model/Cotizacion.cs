using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Model
{
    class Cotizacion
    {
        private int numeroDeIdentificacion = 0;
        private string fechaYHora;
        private int codigoVendedor;
        private Prenda prendaCotizada;
        private int cantPrendas;
        private int totalCotizacion;
        public string FechaYHora { get => fechaYHora; set => fechaYHora = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        public int CantPrendas { get => cantPrendas; set => cantPrendas = value; }
        public int TotalCotizacion { get => totalCotizacion; set => totalCotizacion = value; }
        internal Prenda PrendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }

        public Cotizacion( int codigoVendedor, Prenda prendaCotizada, int cantPrendas)
        {
            this.numeroDeIdentificacion++;
            this.FechaYHora = DateTime.Now.ToString(); 
            this.CodigoVendedor = codigoVendedor;
            this.PrendaCotizada = prendaCotizada;
            this.CantPrendas = cantPrendas;
          
        }

    }
}
