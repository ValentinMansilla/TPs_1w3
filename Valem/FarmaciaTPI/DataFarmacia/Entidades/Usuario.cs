using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public Usuario()
        {
            Nombre = string.Empty;
            Contraseña = string.Empty;
        }
        public Usuario(string usuario, string contraseña)
        {
            this.Nombre = usuario;
            this.Contraseña = contraseña;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
