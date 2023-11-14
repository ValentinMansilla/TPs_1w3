using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle
    {
        public int Id { get; set; }
        public Suministro Suministro { get; set; }
        public Descuento Descuento { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public Detalle(int id, Suministro sum, Descuento de, int cant, double precio)
        {
            Id = id;
            Suministro = sum;
            Descuento = de;
            Cantidad = cant;
            Precio = precio;
        }

        public double CalcularSubtotal()
        {
            double subtotal = Cantidad * Precio;
            
            return subtotal;
        }

    }
}
