using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Model
{
    class Pantalon : Prenda
    {

        private string tipoCorte;
        public string TipoCorte { get => tipoCorte; set => tipoCorte = value; }

        public Pantalon(string calidad, int stock, string tipoCorte) : base( calidad,   stock)
        {
            this.TipoCorte = tipoCorte;       
        }


        public override void precioSegunTipo()
        {
            throw new NotImplementedException();
        }
    }
}
