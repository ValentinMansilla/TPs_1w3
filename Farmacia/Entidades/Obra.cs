using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Obra
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Obra()
        {
            Id = 0;
            Nombre = string.Empty;
        }
        public Obra(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
