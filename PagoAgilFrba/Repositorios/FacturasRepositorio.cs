using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Modelo;
using System.Data;
using System.Data.SqlClient;
using PagoAgilFrba.Excepciones;
using PagoAgilFrba.Modelo;

namespace PagoAgilFrba.Repositorios
{
    class FacturasRepositorio
    {

        public static List<SqlParameter> buildParametrosFactura(Factura factura)
        {
            List<SqlParameter> parametros_factura = new List<SqlParameter>();

            parametros_factura.Add(new SqlParameter("@numero_factura", factura.numero));
            parametros_factura.Add(new SqlParameter("@cuit", factura.empresa_cuit));
            parametros_factura.Add(new SqlParameter("@cliente", factura.cliente));
            parametros_factura.Add(new SqlParameter("@fecha_alta", factura.fecha_alta));
            parametros_factura.Add(new SqlParameter("@fecha_vencimiento", factura.fecha_vencimiento));
            parametros_factura.Add(new SqlParameter("@total", factura.getMontoActual()));
            parametros_factura.Add(new SqlParameter("@habilitada",factura.habilitada));

            return parametros_factura;
        }

        public static List<SqlParameter> buildParametrosItem(ItemFactura item)
        {
            List<SqlParameter> parametros_item = new List<SqlParameter>();
            parametros_item.Add(new SqlParameter("@numero_factura", item.numero_factura));
            parametros_item.Add(new SqlParameter("@detalle", item.detalle));
            parametros_item.Add(new SqlParameter("@cantidad", item.cantidad));
            parametros_item.Add(new SqlParameter("@monto", item.monto));
            return parametros_item;
        }

        public static void agregarItems(List<ItemFactura> items)
        {
            foreach (ItemFactura item in items)
            {
                DataBase.WriteInBase("404_NOT_FOUND.SP_AGREGAR_ITEM", "SP", buildParametrosItem(item));
            }
        }


        public static void agregar(Factura factura)
        {
            DataBase.WriteInBase("404_NOT_FOUND.SP_AGREGAR_FACTURA", "SP", buildParametrosFactura(factura));
            agregarItems(factura.get_items_factura);

        }

        public static void modificar(Factura factura)
        {
            DataBase.WriteInBase("404_NOT_FOUND.SP_MODIFICAR_FACTURA", "SP", buildParametrosFactura(factura));

            List<SqlParameter> parametros_item = new List<SqlParameter>();
            parametros_item.Add(new SqlParameter("@numero_factura", factura.numero));
            DataBase.WriteInBase("404_NOT_FOUND.SP_ELIMINAR_ITEMS_FACTURA", "SP", parametros_item);
            agregarItems(factura.get_items_factura);
            
        }

       
        public static void inhabilitar(string numero_factura)
        {

            List<SqlParameter> parametros_factura = new List<SqlParameter>();
            
            parametros_factura.Add(new SqlParameter("@numero_factura", numero_factura));
           
            DataBase.WriteInBase("404_NOT_FOUND.SP_INHABILITAR_FACTURA", "SP", parametros_factura);
        }

        public static bool esFacturaHabilitada(string numero_factura)
        {
            return getFactura(Convert.ToInt32(numero_factura)).habilitada;
        }


        public static bool esFacturaExistente(String numero_factura)
        {
            List<Factura> facturas = getFacturas("", "", "", new DateTime(), new DateTime(), false, false);

            return facturas.ConvertAll(factura => factura.numero).Contains(Convert.ToInt32(numero_factura));
        }

        public static List<Factura> getFacturas(string factura,string cliente, string cuit, DateTime fecha_alta, DateTime fecha_vencimiento, bool criterio_fecha_alta, bool criterio_fecha_vencimiento)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();


            if (string.IsNullOrWhiteSpace(factura)) parametros.Add(new SqlParameter("@factura", DBNull.Value));
            else parametros.Add(new SqlParameter("@factura", Convert.ToInt32(factura)));

            if (string.IsNullOrWhiteSpace(cliente)) parametros.Add(new SqlParameter("@cliente", DBNull.Value));
            else parametros.Add(new SqlParameter("@cliente", Convert.ToInt32(cliente)));
            
            if (string.IsNullOrWhiteSpace(cuit)) parametros.Add(new SqlParameter("@cuit", DBNull.Value));
            else parametros.Add(new SqlParameter("@cuit", cuit));
            
            if (!criterio_fecha_alta)parametros.Add(new SqlParameter("@fecha_alta", DBNull.Value));
           else parametros.Add(new SqlParameter("@fecha_alta", fecha_alta));
            
            if (!criterio_fecha_vencimiento)parametros.Add(new SqlParameter("@fecha_vencimiento", DBNull.Value));
            else parametros.Add(new SqlParameter("@fecha_vencimiento", fecha_vencimiento));
            

            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS","SP", parametros);

            return buildFacturasDelLector(lector);
        }

        public static List<Factura> buildFacturasDelLector(SqlDataReader lector)
        {
            List<Factura> facturas = new List<Factura>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Factura factura = buildFactura(lector);
                    facturas.Add(factura);
                }
                lector.Close();
            }
            return facturas;
        }

        public static Factura getFactura(int numero_factura)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@factura", Convert.ToInt32(numero_factura)));
            parametros.Add(new SqlParameter("@cliente", DBNull.Value));
            parametros.Add(new SqlParameter("@cuit", DBNull.Value));
            parametros.Add(new SqlParameter("@fecha_alta", DBNull.Value));
            parametros.Add(new SqlParameter("@fecha_vencimiento", DBNull.Value));


            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS", "SP", parametros);

            Factura factura =  buildFacturasDelLector(lector).ElementAt(0);

            setItems(factura);
            return factura;
        }

        public static List<Factura> getFacturasPagasActualesDeCliente(String numero_cliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@factura", DBNull.Value));
            if (string.IsNullOrWhiteSpace(numero_cliente)) parametros.Add(new SqlParameter("@cliente", DBNull.Value));
            else parametros.Add(new SqlParameter("@cliente", Convert.ToInt32(numero_cliente)));
            parametros.Add(new SqlParameter("@cuit", DBNull.Value));

            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS_PAGAS_ACTUALES", "SP", parametros);
            return buildFacturasDelLector(lector);
        }

        public static List<Factura> getFacturasPagasActualesDeEmpresa(String cuit)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@factura", DBNull.Value));
            parametros.Add(new SqlParameter("@cliente", DBNull.Value));
            if (string.IsNullOrWhiteSpace(cuit)) parametros.Add(new SqlParameter("@cuit", DBNull.Value));
            else parametros.Add(new SqlParameter("@cuit", cuit));
            
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS_PAGAS_ACTUALES", "SP", parametros);
            return buildFacturasDelLector(lector);
        }

        public static List<Factura> getFacturasRendidasActualesDeEmpresa(String cuit)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@cuit", cuit));
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS_RENDIDAS_ACTUALES", "SP",parametros);
            return buildFacturasDelLector(lector);
        }

        public static List<Factura> getAllFacturasRendidasActuales()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@cuit", DBNull.Value));
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS_RENDIDAS_ACTUALES", "SP", parametros);
            return buildFacturasDelLector(lector);
        }
        public static List<Factura> getAllFacturasPagasActuales()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@factura", DBNull.Value));
            parametros.Add(new SqlParameter("@cliente", DBNull.Value));
            parametros.Add(new SqlParameter("@cuit", DBNull.Value));
           
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS_PAGAS_ACTUALES", "SP", parametros);
            return buildFacturasDelLector(lector);
        }

        public static List<Factura> getFacturasPendientesDeRendicionDeEmpresa(String cuit)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@cuit", cuit));
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS_PENDIENTES_DE_RENDICION_DE_EMPRESA", "SP", parametros);
            return buildFacturasDelLector(lector);
        }


      

        public static void setItems(Factura factura)
        {
            factura.items_factura = getItems(factura.numero);
        }

        public static List<ItemFactura> getItems(int numero_factura)
        {
            
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<ItemFactura> items = new List<ItemFactura>();

           parametros.Add(new SqlParameter("@numero_factura", numero_factura));
           SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_ITEMS", "SP", parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ItemFactura item = buildItem(lector);
                    items.Add(item);
                }
                lector.Close();
            }
            return items;
        }



        public static Factura buildFactura(SqlDataReader lector)
        {
            Factura factura = new Factura();

            factura.cliente = Convert.ToInt32(lector["fact_cliente"]);
            factura.numero = Convert.ToInt32(lector["fact_numero"]);
            factura.empresa_cuit = (String)lector["fact_emp_cuit"];
            factura.fecha_alta = (DateTime)lector["fact_fecha_alta"];
            factura.fecha_vencimiento = (DateTime)lector["fact_fecha_vencimiento"];
            factura.total = Convert.ToDouble(lector["fact_total"]);
            factura.habilitada = (bool)lector["fact_habilitada"];

            return factura;
        }

        public static ItemFactura buildItem(SqlDataReader lector)
        {
            ItemFactura item = new ItemFactura();

            item.cantidad = Convert.ToInt32(lector["item_cantidad"]);
            item.detalle = Convert.ToString(lector["item_detalle"]);
            item.monto = Convert.ToDouble(lector["item_monto"]);
            item.numero_factura = Convert.ToInt32(lector["item_fact_numero"]);

            return item;
        }

        public static List<Factura> getFacturasARendirDeEmpresa(String cuit, DateTime fecha)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            if (string.IsNullOrWhiteSpace(cuit)) parametros.Add(new SqlParameter("@cuit", DBNull.Value));
            else parametros.Add(new SqlParameter("@cuit", cuit));
            
            parametros.Add(new SqlParameter("@fecha",fecha));
                 
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FACTURAS_A_RENDIR_DE_EMPRESA", "SP", parametros);
            return buildFacturasDelLector(lector);
        }

        public static bool esFacturaDelCliente(String numero_factura, String numero_cliente)
        {
            List<Factura> facturas = getFacturas(numero_factura, numero_cliente, "", new DateTime(), new DateTime(), false, false);
            return facturas.Count > 0;
        }

        public static bool esFacturaDeLaEmpresa(String numero_factura, String cuit_empresa)
        {
            List<Factura> facturas = getFacturas(numero_factura, "", cuit_empresa, new DateTime(), new DateTime(), false, false);
            return facturas.Count > 0;
        }

        public static bool verificaFechaVencimiento(String numero_factura,DateTime fecha_vencimiento_ingresada)
        {
            Factura factura = getFactura(Convert.ToInt32(numero_factura));
            ComparadorFechas comparadorFechas = new ComparadorFechas();
            return comparadorFechas.esIgual(fecha_vencimiento_ingresada, factura.fecha_vencimiento);
            
        }

        public static bool esImporteCorrecto(String numero_factura, String importe)
        {
            return getFactura(Convert.ToInt32(numero_factura)).total.ToString() == importe;
        }

        public static bool esFacturaPagada(String numero_factura)
        {
           
            return getAllFacturasPagasActuales().ConvertAll(factura => factura.numero).Contains(Convert.ToInt32(numero_factura));
        }

        public static bool esFacturaRendida(String numero_factura)
        {
            return getAllFacturasRendidasActuales().ConvertAll(factura => factura.numero).Contains(Convert.ToInt32(numero_factura));
        }

      

        public static void rendir(List<int> listaFacturas, double comision, int cantidadFacturas, double total,double porcentajeComision,string empresa)
        {
            DateTime fechaRendicion = DateTime.Today;
            int id_rend = 0;
       
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@fecha", fechaRendicion));
            parametros.Add(new SqlParameter("@porcentajeComision", porcentajeComision));
            parametros.Add(new SqlParameter("@total", total));
            parametros.Add(new SqlParameter("@total_comision", comision));
            parametros.Add(new SqlParameter("@cantidad", cantidadFacturas));
            parametros.Add(new SqlParameter("@empresa", empresa));        
            SqlParameter output = new SqlParameter("@id_rend", id_rend);
            output.Direction = ParameterDirection.Output;
            parametros.Add(output);

            SqlCommand sqlCommand = DataBase.ejecutarSP("[404_NOT_FOUND].[sp_rendir_facturas]",parametros);
            id_rend = Convert.ToInt32(sqlCommand.Parameters["@id_rend"].Value);

            parametros.Clear();

            foreach (int fact in listaFacturas)
            {
                parametros.Add(new SqlParameter("@fact_id",fact));
                parametros.Add(new SqlParameter("@rend_id",id_rend));

                DataBase.ejecutarSP("[404_NOT_FOUND].[sp_insert_items_rendicion]", parametros);
                parametros.Clear();

            }
           

        }

    }
}


 
