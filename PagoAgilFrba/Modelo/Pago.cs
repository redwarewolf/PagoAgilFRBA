using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    class Pago
    {
        public int id { get; set; }
        public List<Factura> facturas = new List<Factura>();
        public  DateTime fecha_cobro { get; set; }
        public Double total { get; set; }
        public  String medio_pago { get; set; }
        public int cliente { get; set; }
        public int sucursal { get; set; }

        public void aumentarImporteTotal(String importe_factura)
        {
            this.total += Convert.ToDouble(importe_factura);
        }

        public List<Factura> getFacturasAPagar()
        {
            return this.facturas;
        }

        public void agregarFacturaAPagar(Factura factura)
        {
            this.facturas.Add(factura);
        }

        public void eliminarFacturasAPagar()
        {
            this.facturas.Clear();
        }

        public bool existenFacturasAPagar()
        {
            return this.facturas.Count > 0;
        }

        

    }
}
