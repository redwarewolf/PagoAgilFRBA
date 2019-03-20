using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    class ItemFactura
    {
        public Int32 cantidad { get; set; }
        public Double monto { get; set; }
        public Int32 numero_factura { get; set; }
        public String detalle { get; set; }
    }
}
