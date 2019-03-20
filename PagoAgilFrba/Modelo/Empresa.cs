using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    class Empresa
    {
        public String cuit { get; set; }
        public String nombre { get; set; }
        public Int32 rubro { get; set; }
        public String direccion { get; set; }
        public Boolean habilitado { get; set; }
    }
}
