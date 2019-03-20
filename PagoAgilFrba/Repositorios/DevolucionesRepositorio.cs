using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace PagoAgilFrba.Repositorios
{
    class DevolucionesRepositorio
    {

        public static void agregarDevolucion(Devolucion devolucion)
        {
            SqlCommand sqlCommand = DataBase.ejecutarSP("404_NOT_FOUND.SP_AGREGAR_DEVOLUCION", buildParametrosDevolucion(devolucion));
            devolucion.id = Convert.ToInt32(sqlCommand.Parameters["@devolucion_id"].Value);

            agregarItemsDevolucion(devolucion);
        }

        public static void agregarItemsDevolucion(Devolucion devolucion)
        {
            foreach (int factura_numero in devolucion.getFacturasADevolver())
            {
                List<SqlParameter> parametros_item = new List<SqlParameter>();
                parametros_item.Add(new SqlParameter("@factura", factura_numero));
                parametros_item.Add(new SqlParameter("@devolucion_id", devolucion.id));
                DataBase.WriteInBase("404_NOT_FOUND.SP_AGREGAR_ITEM_DEVOLUCION", "SP", parametros_item);
            }
        }

        public static List<SqlParameter> buildParametrosDevolucion(Devolucion devolucion)
        {
            List<SqlParameter> parametros_devolucion = new List<SqlParameter>();
            parametros_devolucion.Add(new SqlParameter("@motivo", devolucion.motivo));

            parametros_devolucion.Add(new SqlParameter("@fecha_devolucion", devolucion.fecha_devolucion));
           
            SqlParameter output = new SqlParameter("@devolucion_id", devolucion.id);
            output.Direction = ParameterDirection.Output;
            parametros_devolucion.Add(output);
            return parametros_devolucion;
        }
    }
}
