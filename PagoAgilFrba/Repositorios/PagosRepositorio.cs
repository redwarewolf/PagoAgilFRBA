using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace PagoAgilFrba.Repositorios
{
    class PagosRepositorio
    {
        public static List<String> formas_de_pago = new List<String>(new String[] {"Efectivo","Tarjeta de credito","Tarjeta de debito","Cheque"});

        public static List<String> getFormasDePago()
        {
            return formas_de_pago;
        }

        public static void agregarPago(Pago pago)
        {
           SqlCommand sqlCommand= DataBase.ejecutarSP("404_NOT_FOUND.SP_AGREGAR_PAGO", buildParametrosPago(pago));
           pago.id = Convert.ToInt32(sqlCommand.Parameters["@pago_id"].Value);

            agregarItemsPago(pago);
        }

        public static void agregarItemsPago(Pago pago)
        {
            foreach (Factura factura in pago.getFacturasAPagar())
            {
                List<SqlParameter> parametros_item = new List<SqlParameter>();
                parametros_item.Add(new SqlParameter("@factura", factura.numero));
                parametros_item.Add(new SqlParameter("@pago_id",pago.id ));
                DataBase.WriteInBase("404_NOT_FOUND.SP_AGREGAR_ITEM_PAGO", "SP", parametros_item);
            }
        }

        public static List<SqlParameter> buildParametrosPago(Pago pago)
        {
            List<SqlParameter> parametros_pago = new List<SqlParameter>();
            parametros_pago.Add(new SqlParameter("@cliente", pago.cliente));
            
            parametros_pago.Add(new SqlParameter("@sucursal", pago.sucursal));
            parametros_pago.Add(new SqlParameter("@medio_pago", pago.medio_pago));
            parametros_pago.Add(new SqlParameter("@total", pago.total));
            parametros_pago.Add(new SqlParameter("@fecha_cobro", pago.fecha_cobro));
            SqlParameter output = new SqlParameter("@pago_id", pago.id);
            output.Direction = ParameterDirection.Output;
            parametros_pago.Add(output);
            return parametros_pago;
        }
    }
}
