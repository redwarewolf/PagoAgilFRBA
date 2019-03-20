using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Modelo;
using System.Data;
using System.Data.SqlClient;
using PagoAgilFrba.Excepciones;


namespace PagoAgilFrba.Repositorios
{
    class EmpresasRepositorio
    {

        public static bool esEmpresaExistente(String cuit)
        {
            SqlDataReader lector = buscarFilasEmpresa(cuit);
            return lector.HasRows;
        }

        public static SqlDataReader buscarFilasEmpresa(String cuit)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@cuit", cuit));
            return DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_EMPRESA", "SP", parametros);
        }

        public static bool verificaConformacionCuit(String cuit)
        {

            if (cuit.Length != 11) return false;

            int[] serie = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

            int verificador = 0;

            for (int i = 0; i < serie.Length; i++)
                verificador += (int)Char.GetNumericValue(cuit[i]) * serie[i];

            verificador = 11 - (verificador % 11);
            verificador %= 11;

            return Char.GetNumericValue(cuit[10]).Equals(verificador);
        }
       

        public static void agregar(Empresa empresa)
        {
            DataBase.WriteInBase("404_NOT_FOUND.SP_AGREGAR_EMPRESA", "SP", buildParametrosEmpresa(empresa));
         
        }

        public static void modificar(Empresa empresa)
        {
            DataBase.WriteInBase("404_NOT_FOUND.SP_MODIFICAR_EMPRESA", "SP", buildParametrosEmpresa(empresa));
        }

        public static List<SqlParameter> buildParametrosEmpresa(Empresa empresa)
        {
            List<SqlParameter> parametros_empresa = new List<SqlParameter>();

            parametros_empresa.Add(new SqlParameter("@cuit", empresa.cuit));
            parametros_empresa.Add(new SqlParameter("@nombre", empresa.nombre));
            parametros_empresa.Add(new SqlParameter("@rubro", empresa.rubro));
            parametros_empresa.Add(new SqlParameter("@direccion", empresa.direccion));
            parametros_empresa.Add(new SqlParameter("@habilitado", empresa.habilitado));

            return parametros_empresa;
        }

        public static List<Empresa> getAllEmpresas()
        {
            return getEmpresas("","","", "", "");
        }

        public static List<Empresa> buildEmpresasDelLector(SqlDataReader lector)
        {
            List<Empresa> empresas = new List<Empresa>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Empresa empresa = buildEmpresa(lector);
                    empresas.Add(empresa);
                }
                lector.Close();
            }
            return empresas;
        }

        public static List<Empresa> getEmpresas(String tipo,String numero,String verificador, String nombre, String rubro_id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            String cuit = tipo + "-" + numero + "-" + verificador;
            if (string.IsNullOrWhiteSpace(tipo) || string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(verificador)) 
                parametros.Add(new SqlParameter("@cuit", DBNull.Value));
            else parametros.Add(new SqlParameter("@cuit", cuit));

            if (string.IsNullOrWhiteSpace(nombre)) parametros.Add(new SqlParameter("@nombre", DBNull.Value));
            else parametros.Add(new SqlParameter("@nombre", nombre));

            if (string.IsNullOrWhiteSpace(rubro_id)) parametros.Add(new SqlParameter("@rubro", DBNull.Value));
            else parametros.Add(new SqlParameter("@rubro", rubro_id));


            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_EMPRESAS", "SP", parametros);
            return buildEmpresasDelLector(lector);
        }

        public static bool esEmpresaHabilitada(String cuit)
        {
            Empresa empresa = getEmpresa(cuit);
            
            return empresa.habilitado;
        }

        public static List<Empresa> getEmpresasHabilitadas()
        {
            List<Empresa> empresas = new List<Empresa>();
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_EMPRESAS_HABILITADAS", "SP", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Empresa empresa = buildEmpresa(lector);
                    empresas.Add(empresa);
                }
                lector.Close();
            }
            return empresas;
        }

        public static Empresa getEmpresa(String cuit)
        {
            Empresa empresa = new Empresa();
            SqlDataReader lector = buscarFilasEmpresa(cuit);

            if (lector.HasRows) /*TODO: Lanzar excpecion*/
            {
                while (lector.Read())
                {
                    empresa = buildEmpresa(lector);
                }
                lector.Close();
            }
            
            return empresa;
        }

     
        public static Empresa buildEmpresa(SqlDataReader lector)
        {
            Empresa empresa = new Empresa();

            empresa.cuit = (String)lector["emp_cuit"];
            empresa.nombre = (String)lector["emp_nombre"];
            empresa.habilitado = (bool)lector["emp_habilitado"];
            empresa.direccion = (String)lector["emp_direccion"];
            empresa.rubro = (int)lector["emp_rubro"];

            return empresa;
        }



        public static void deshabilitar(String cuit)
        {
            if (!tieneTodasFacturasCobradasRendidas(cuit)) throw new EmpresaNoRendidaError("La empresa no tiene todas sus facturas cobradas de manera rendidas");

            List<SqlParameter> parametros = new List<SqlParameter>();
            
            parametros.Add(new SqlParameter("@cuit",cuit));
           
            DataBase.WriteInBase("404_NOT_FOUND.SP_ELIMINAR_EMPRESA", "SP", parametros);
       
        }

        public static bool tieneTodasFacturasCobradasRendidas(String cuit)
        {
            List<Factura> facturas = FacturasRepositorio.getFacturasPendientesDeRendicionDeEmpresa(cuit);
            return facturas.Count() == 0;
        }
        


        public static SqlDataReader obtenerListadoEmpresasSP(DateTime desde, DateTime hasta, int cantidad, String SP)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@fecha_desde", desde));
            parametros.Add(new SqlParameter("@fecha_hasta", hasta));
            parametros.Add(new SqlParameter("@cant_elementos", cantidad));

            return DataBase.GetDataReader("[404_NOT_FOUND].[sp_buscar_"+SP+"_empresa]", "SP", parametros);

        }

    }
}
