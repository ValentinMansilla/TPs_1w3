using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Empleado
    {

        public int Legajo { get;  set; }
        public string Nombre { get;  set; }
        public string Apellido { get;  set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";

        public Empleado(int legajo, string nombre, string apellido)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
        }
        public Empleado()
        {
            Legajo = 0;
            Nombre = String.Empty;
            Apellido = String.Empty;
        }
    }
}
