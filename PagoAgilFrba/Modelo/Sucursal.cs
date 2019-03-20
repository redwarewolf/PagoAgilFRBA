using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    public class Sucursal
    {
        public String nombre { get; set; }
        public String direccion { get; set; }
        public Int32 codigo_postal { get; set; }
        public Boolean habilitado { get; set; }
    }
}
