using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Suministro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Int64 CodigoDeBarras { get; set; }

        public Suministro()
        {
            Id = 0;
            Nombre = string.Empty;
            Precio = 0;
            CodigoDeBarras = 0;
        }
        public Suministro(int id, string nombre, double precio, Int64 cod)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            CodigoDeBarras = cod;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
