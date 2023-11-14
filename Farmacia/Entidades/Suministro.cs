using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suministro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Suministro()
        {
            Id = 0;
            Nombre = string.Empty;
            Precio = 0;
        }
        public Suministro(int id, string nombre, double precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
