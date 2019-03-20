using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Modelo;
using System.Data.SqlClient;

namespace PagoAgilFrba.Repositorios
{
    class FuncionalidadesRepositorio
    {
        public static List<Funcionalidad> getFuncionalidades()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_FUNCIONALIDADES", "SP", parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad funcionalidad = buildFuncionalidad(lector);
                    funcionalidades.Add(funcionalidad);
                }
                lector.Close();
            }
            return funcionalidades;
        }

        public static Funcionalidad buildFuncionalidad(SqlDataReader lector)
        {
            Funcionalidad funcionalidad = new Funcionalidad();

            funcionalidad.nombre = (String)lector["func_nombre"];
            funcionalidad.detalle = (String)lector["func_detalle"];

            return funcionalidad;
        }
    }
}
