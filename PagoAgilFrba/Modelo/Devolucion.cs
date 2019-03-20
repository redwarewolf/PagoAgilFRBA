using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    class Devolucion
    {
        public int id { get; set; }
        public String motivo { get; set; }
        public DateTime fecha_devolucion { get; set; }
        public List<int> facturas = new List<int>();

        public List<int> getFacturasADevolver()
        {
            return this.facturas;
        }

        public void agregarFacturaADevolver(int numero_factura)
        {
            facturas.Add(numero_factura);
        }

        public void eliminarFacturasADevolver()
        {
            this.facturas.Clear();
        }

        public void eliminarFacturaADevolver(int numero_factura)
        {
            this.facturas.RemoveAll(factura => factura == numero_factura);
        }

        public bool contiene(int numero_factura)
        {
            return this.facturas.Contains(numero_factura);
        }

        public bool existenFacturasADevolver()
        {
            return this.facturas.Count > 0;
        }

    }
}
