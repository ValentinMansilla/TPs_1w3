using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Sucursal Sucursal { get; set; }
        public Empleado Empleado { get; set; }
        public bool Pagado { get; set; }

        public List<Detalle> lDetalles { get; set; }

        public Factura()
        {
            lDetalles = new List<Detalle>();
        }


        public void AddDetalle(Detalle det)
        {
            lDetalles.Add(det);
        }

        public void QuitarDetalle(int index)
        {
            lDetalles.RemoveAt(index);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (Detalle d in lDetalles)
            {
                total += d.CalcularSubtotal();
            }
            return total;
        }
    }
}
