using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Entidades
{
    public class TipoDNI
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public TipoDNI(int id, string tipo)
        {
            ID = id;
            Tipo = tipo;
        }
        public TipoDNI()
        {
            ID = 0;
            Tipo = "";
        }
        public TipoDNI(int id)
        {
            ID = id;
            Tipo = DevuelveTipo();
        }
        public string DevuelveTipo()
        {
            string tipo = string.Empty;
            switch (ID)
            {
                case 1:
                    tipo = "DNI";
                    break;
                case 2:
                    tipo = "Pasaporte";
                    break;
                case 3:
                    tipo = "Documento extranjero";
                    break;
                case 4:
                    tipo = "Libreta Civica";
                    break;
                case 5:
                    tipo = "Libreta de Enrolamiento";
                    break;
                default:
                    break;
            }
            return tipo;
        }
        public override string ToString()
        {
            return Tipo;
        }   
    }
}
