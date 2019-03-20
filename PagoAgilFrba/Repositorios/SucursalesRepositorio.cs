using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PagoAgilFrba.Modelo;

namespace PagoAgilFrba.Repositorios
{
    class SucursalesRepositorio
    {

        public static bool esSucursalExistente(int codigo_postal)
        {
            SqlDataReader lector = buscarFilasSucursal(codigo_postal);
            return lector.HasRows;
        }

        public static SqlDataReader buscarFilasSucursal(int codigo_postal)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@codigo_postal", codigo_postal));
            return DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_SUCURSAL", "SP", parametros);
        }

        public static List<SqlParameter> buildParametrosSucursal(Sucursal sucursal)
        {
            List<SqlParameter> parametros_sucursal = new List<SqlParameter>();
            parametros_sucursal.Add(new SqlParameter("@codigo_postal", sucursal.codigo_postal));
            parametros_sucursal.Add(new SqlParameter("@nombre", sucursal.nombre));
            parametros_sucursal.Add(new SqlParameter("@direccion", sucursal.direccion));
            parametros_sucursal.Add(new SqlParameter("@habilitado", sucursal.habilitado));
            return parametros_sucursal;
        }

        public static void agregar(Sucursal sucursal)
        {
            DataBase.WriteInBase("404_NOT_FOUND.SP_AGREGAR_SUCURSAL", "SP", buildParametrosSucursal(sucursal));
        }

        public static List<Sucursal> getSucursales(String codigo_postal, String nombre, String direccion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<Sucursal> sucursales = new List<Sucursal>();

            if (String.IsNullOrWhiteSpace(codigo_postal)) parametros.Add(new SqlParameter("@codigo_postal", DBNull.Value));
            else parametros.Add(new SqlParameter("@codigo_postal", codigo_postal));

            if (String.IsNullOrWhiteSpace(nombre)) parametros.Add(new SqlParameter("@nombre", DBNull.Value));
            else parametros.Add(new SqlParameter("@nombre", nombre));

            if (String.IsNullOrWhiteSpace(direccion)) parametros.Add(new SqlParameter("@direccion", DBNull.Value));
            else parametros.Add(new SqlParameter("@direccion", direccion));

            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_SUCURSALES", "SP", parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Sucursal sucursal = buildSucursal(lector);
                    sucursales.Add(sucursal);
                }
                lector.Close();
            }
            return sucursales;

        }

        public static Sucursal buildSucursal(SqlDataReader lector)
        {
            Sucursal sucursal = new Sucursal();

            sucursal.codigo_postal = (int)lector["suc_cod_post"];
            sucursal.nombre = (String)lector["suc_nombre"];
            sucursal.direccion = (String)lector["suc_direccion"];
            sucursal.habilitado = (bool)lector["suc_habilitado"];

            return sucursal;
        }

        public static void deshabilitar(String codigo_postal_sucursal)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@codigo_postal", codigo_postal_sucursal));

            DataBase.WriteInBase("404_NOT_FOUND.SP_ELIMINAR_SUCURSAL", "SP", parametros);

        }

        public static void habilitar(String codigo_postal_sucursal)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@codigo_postal", codigo_postal_sucursal));

            DataBase.WriteInBase("404_NOT_FOUND.SP_HABILITAR_SUCURSAL", "SP", parametros);
        }

        public static void modificar(Sucursal sucursal)
        {
            DataBase.WriteInBase("404_NOT_FOUND.SP_MODIFICAR_SUCURSAL", "SP", buildParametrosSucursal(sucursal));

        }

        public static int validarHabilitacionSucursal(int cod_post)
        {
            int salida = 1;

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@suc",cod_post));
            
            SqlParameter output = new SqlParameter("@salida", salida);
            output.Direction = ParameterDirection.Output;
            parametros.Add(output);
            
            SqlCommand sqlCommand = DataBase.ejecutarSP("[404_NOT_FOUND].[sp_validar_sucursal]",parametros);

            return Convert.ToInt32(sqlCommand.Parameters["@salida"].Value);
        }


    }
}
