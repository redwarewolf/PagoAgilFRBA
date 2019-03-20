using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    class Direccion
    {
        public Int16 cp { get; set; }
        public String localidad { get; set; }
        public Int16 piso { get; set; }
        public Char dpto { get; set; }
        public String calle { get; set; }
    }
}
