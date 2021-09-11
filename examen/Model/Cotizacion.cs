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

        public Cotizacion( int codigoVendedor, Prenda prendaCotizada, int cantPrendas)
        {
            this.numeroDeIdentificacion++;
            this.fechaYHora = DateTime.Now.ToString(); 
            this.codigoVendedor = codigoVendedor;
            this.prendaCotizada = prendaCotizada;
            this.cantPrendas = cantPrendas;
          
        }




    }
}
