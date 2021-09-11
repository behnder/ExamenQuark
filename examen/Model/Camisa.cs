using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Model
{
    class Camisa : Prenda
    {

        private string tipoManga;
        private string tipoCuello;

        public string TipoManga { get => tipoManga; set => tipoManga = value; }
        public string TipoCuello { get => tipoCuello; set => tipoCuello = value; }

        public Camisa(string calidad,  int stock, string tipoManga, string tipoCuello) : base(calidad, stock)
        {
            this.tipoManga = tipoManga;
            this.tipoCuello = tipoCuello;
        }

        public override void precioSegunTipo()
        {
            throw new NotImplementedException();
        }
    }
}
