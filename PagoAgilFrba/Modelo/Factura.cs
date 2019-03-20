using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    class Factura
    {
        public Int32 numero { get; set; }
        public Int32 cliente { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public Double total { get; set; }
        public String empresa_cuit { get; set; }
        public bool habilitada { get; set; }
  
        public List<ItemFactura> items_factura = new List<ItemFactura>();

        public List<ItemFactura> get_items_factura
        {
             // no setter
                get { return items_factura; }
        }

        public Boolean esItemRepetido(String detalle)
        {
            return items_factura.Exists(item => item.detalle == detalle);
        }

        public void agregarNuevoItem(ItemFactura item)
        {
            items_factura.Add(item);
        }

        public void vaciarItems()
        {
            items_factura.Clear();
        }

        public void eliminarItem(string detalle)
        {
            var indice = items_factura.FindIndex(item => item.detalle == detalle);
           items_factura.RemoveAt(indice);
        }

        public void setMontoTotal()
        {
            this.total = this.getMontoActual();
        }

        public Double getMontoActual()
        {
            return items_factura.ConvertAll(item => item.monto * item.cantidad).Sum();
        }


        public void setItemsNumeroFactura()
        {
            items_factura.ForEach(item => item.numero_factura = this.numero);
        }
    }
}
