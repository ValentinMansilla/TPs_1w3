using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Semifactura
    {
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string Cliente { get; set; }
        public int Cantidad { get; set; }

        public Semifactura(int mes, int anio, string cliente, int cantidad)
        {
            Mes = mes;
            Anio = anio;
            Cliente = cliente;
            Cantidad = cantidad;
        }
    }
}
