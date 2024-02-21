using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Cliente
    {
        public int ID { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDNI { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";

        public Cliente()
        {
            ID = 0;
            DNI = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            TipoDNI = 0;

        }
        public Cliente(int id, int dni, string nombre, string apellido, int tipo)
        {
            ID = id;
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            TipoDNI = tipo;
        }
    }
}
