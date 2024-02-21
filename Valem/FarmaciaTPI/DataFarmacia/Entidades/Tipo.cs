using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Tipo
    {
        public Tipo(int codigoTipo, string nombreTipo)
        {
            this.codigoTipo = codigoTipo;
            this.nombreTipo = nombreTipo;
        }
        public Tipo()
        {
            codigoTipo = 0;
            nombreTipo = string.Empty;
        }

        public int codigoTipo { get; set; }
        public string nombreTipo { get; set; }

        public override string ToString()
        {
            return nombreTipo;
        }
    }
}
