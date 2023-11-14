using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Descuento
    {
        public Obra Obra { get; set; }
        public Localidad Localidad { get; set; }
        public Suministro Suministro { get; set; }
        public int PorcDescuento { get; set; }
        public Descuento()
        {
            Obra = new Obra();
            Localidad = new Localidad();
            Suministro = new Suministro();
            PorcDescuento = 0;
        }
        public Descuento(Obra obra, Localidad localidad, Suministro suministro, int porc)
        {
            Obra = obra;
            Localidad = localidad;
            Suministro = suministro;
            PorcDescuento = porc;
                    
        }

    }
}
