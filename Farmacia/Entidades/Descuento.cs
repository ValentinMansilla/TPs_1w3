using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Descuento
    {        
        public int id_obra { get; set; }
        public int localidad { get; set; }
        public int suministro { get; set; }
        public int descuento { get; set; }
        public Descuento()
        {            
            id_obra = 0;
            localidad = 0;
            suministro = 0;            
        }

    }
}
