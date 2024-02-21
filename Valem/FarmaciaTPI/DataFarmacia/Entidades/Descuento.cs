using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Descuento
    {
        public int Obra { get; set; }
        public int Localidad { get; set; }
        public int Suministro { get; set; }
        public int PorcDescuento { get; set; }
        public Descuento()
        {
            Obra = 1;
            Localidad = 2;
            Suministro = 10;
            PorcDescuento = 0;
        }
        public Descuento(int porc)
        {
            Obra = 1;
            Localidad = 2;
            Suministro = 10;
            PorcDescuento = porc;

        }
    }
}
