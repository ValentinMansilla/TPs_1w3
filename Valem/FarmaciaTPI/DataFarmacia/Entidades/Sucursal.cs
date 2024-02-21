using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Sucursal()
        {
            Id = 0;
            Descripcion = string.Empty;
        }

        public Sucursal(int id, string desc)
        {
            Id = id;
            Descripcion = desc;
        }
    }
}
