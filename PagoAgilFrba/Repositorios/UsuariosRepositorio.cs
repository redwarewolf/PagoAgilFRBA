using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PagoAgilFrba.Modelo;
using PagoAgilFrba.Repositorios;

namespace PagoAgilFrba.Repositorios
{
    class UsuariosRepositorio
    {

       


        public static Object validarUsuario(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            int salida = 1;

            SqlParameter output = new SqlParameter("@salida", salida);
            output.Direction = ParameterDirection.Output;
            parametros.Add(output);

            parametros.Add(new SqlParameter("@user",user.nombre));
            parametros.Add(new SqlParameter("@password",user.password));
           


            SqlCommand sqlCommand = DataBase.ejecutarSP("[404_NOT_FOUND].[sp_autenticar_usuario]",parametros);

            return sqlCommand.Parameters["@salida"].Value;
  

        }

        public static List<Rol> getRoles(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<Rol> roles = new List<Rol>();

            parametros.Add(new SqlParameter("@user", user.nombre));
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_OBTENER_ROLES", "SP", parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol rol = RolesRepositorio.buildRol(lector);
                    roles.Add(rol);
                }
                lector.Close();
            }
            else
                return null;
            return roles;
        }

        public static List<Sucursal> getSucursales(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<Sucursal> sucursales = new List<Sucursal>();
            List<int> cps = new List<int>();

            parametros.Add(new SqlParameter("@user", user.nombre));
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_OBTENER_SUCURSALES", "SP", parametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int cp = Convert.ToInt32(lector["suc_cod_post"]);
                    cps.Add(cp);
                }
                lector.Close();
            }
            foreach (int cod_post in cps)
            {
                Sucursal suc = SucursalesRepositorio.getSucursales(cod_post.ToString(), null, null).First();
                sucursales.Add(suc);
            }
            return sucursales;
        }





    }
}
