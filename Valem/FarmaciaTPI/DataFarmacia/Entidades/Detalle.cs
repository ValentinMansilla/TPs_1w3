using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Detalle
    {
        public Suministro Suministro { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public Detalle()
        {
            Suministro = new Suministro();
            Cantidad = 0;
            Precio = 0;
        }
        public Detalle(Suministro sum, int cant, double precio)
        {
            Suministro = sum;
            Cantidad = cant;
            Precio = precio;
        }
        public Detalle(Suministro sum, int cant)
        {

            Suministro = sum;
            Cantidad = cant;
        }

        public double CalcularSubtotal()
        {
            double subtotal = Cantidad * Precio;

            return subtotal;
        }
    }
}
