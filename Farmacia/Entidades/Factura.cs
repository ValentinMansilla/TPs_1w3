using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }

        public List<Detalle> lDetalles { get; set; }

        public Factura()
        {
            Numero = 0;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            lDetalles = new List<Detalle>();
        }

        public Factura(int nro, DateTime fecha, string cln)
        {
            Numero = nro;
            Fecha = fecha;
            Cliente = cln;
            lDetalles = new List<Detalle>();
        }

        public void AddDetalle(Detalle det)
        {
            lDetalles.Add(det);
        }

        public void DelDetalle(int index)
        {
            lDetalles.RemoveAt(index);
        }
    }

}
