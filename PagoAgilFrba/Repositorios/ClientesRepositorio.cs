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
    class ClientesRepositorio
    {
        public static bool esClienteExistente(int dni)
        {
            SqlDataReader lector = buscarFilasCliente(dni);
            return lector.HasRows;
        }

        public static bool esClienteHabilitado(int dni)
        {
            return getAllClientes().Where(cliente => cliente.habilitado)
                                            .ToList().ConvertAll(cliente => cliente.dni)
                                            .Contains(dni);
        }

        public static SqlDataReader buscarFilasCliente(int dni)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@dni", dni));
            return DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_CLIENTE", "SP", parametros);
        }
        public static bool direccionExistente(int dni)
        {
            SqlDataReader lector = buscarFilasDireccion(dni);
            return lector.HasRows;
        }

        public static SqlDataReader buscarFilasDireccion(int dni)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@dni", dni));
            return DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_DIRECCION", "SP", parametros);
        }
        public static bool esClienteExistenteMail(String mail)
        {
            SqlDataReader lector = buscarFilasClienteMail(mail);
            return lector.HasRows;
        }

        public static SqlDataReader buscarFilasClienteMail(String mail)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@mail", mail));
            return DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_CLIENTE_MAIL", "SP", parametros);
        }

        public static void agregar(Cliente cliente)
        {
            DataBase.WriteInBase("404_NOT_FOUND.SP_AGREGAR_CLIENTE", "SP", buildParametrosCliente(cliente));

        }

        private static List<SqlParameter> buildParametrosCliente(Cliente cliente)
        {
            List<SqlParameter> parametros_cliente = new List<SqlParameter>();

            parametros_cliente.Add(new SqlParameter("@dni", cliente.dni));
            parametros_cliente.Add(new SqlParameter("@apellido", cliente.apellido));
            parametros_cliente.Add(new SqlParameter("@nombre", cliente.nombre));
            parametros_cliente.Add(new SqlParameter("@fecha_nac", cliente.fecha_nac));
            parametros_cliente.Add(new SqlParameter("@mail", cliente.mail));
            parametros_cliente.Add(new SqlParameter("@habilitado", cliente.habilitado));
            parametros_cliente.Add(new SqlParameter("@telefono", cliente.telefono));
            parametros_cliente.Add(new SqlParameter("@localidad", cliente.direccion.localidad));
            parametros_cliente.Add(new SqlParameter("@cp", cliente.direccion.cp));
            parametros_cliente.Add(new SqlParameter("@calle", cliente.direccion.calle));
            if (cliente.direccion.piso == short.MaxValue){
                parametros_cliente.Add(new SqlParameter("@piso", System.DBNull.Value));
            }
            else
                parametros_cliente.Add(new SqlParameter("@piso", cliente.direccion.piso));
            if (cliente.direccion.dpto == " ".First()){
                parametros_cliente.Add(new SqlParameter("@dpto", System.DBNull.Value));
            }
            else
                parametros_cliente.Add(new SqlParameter("@dpto", cliente.direccion.dpto));

            return parametros_cliente;
        }

        public static SqlDataReader obtenerListadoClientesSP(DateTime desde, DateTime hasta, int cantidad, String SP)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@fecha_desde", desde));
            parametros.Add(new SqlParameter("@fecha_hasta", hasta));
            parametros.Add(new SqlParameter("@cant_elementos", cantidad));

            return DataBase.GetDataReader("[404_NOT_FOUND].[sp_buscar_clie_pagos_"+SP+"]", "SP", parametros);
        }

        public static List<Cliente> getAllClientes()
        {
            return getClientes("", "", "");
        }

        public static List<Cliente> buildClientesDelLector(SqlDataReader lector)
        {
            List<Cliente> clientes = new List<Cliente>();
             if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Cliente cliente = buildCliente(lector);
                    clientes.Add(cliente);
                }
                lector.Close();
            }
            return clientes;
        }

        public static List<Cliente> getClientes(string dni, string nombre, string apellido)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            
            if (string.IsNullOrWhiteSpace(dni)) parametros.Add(new SqlParameter("@dni", DBNull.Value));
            else parametros.Add(new SqlParameter("@dni", dni));

            if (string.IsNullOrWhiteSpace(nombre)) parametros.Add(new SqlParameter("@nombre", DBNull.Value));
            else parametros.Add(new SqlParameter("@nombre", nombre));

            if (string.IsNullOrWhiteSpace(apellido)) parametros.Add(new SqlParameter("@apellido", DBNull.Value));
            else parametros.Add(new SqlParameter("@apellido", apellido));


            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_CLIENTES", "SP", parametros);
            return buildClientesDelLector(lector);
        }

        public static Cliente buildCliente(SqlDataReader lector)
        {
            Cliente cliente = new Cliente();

            cliente.dni = Convert.ToInt32(lector["clie_dni"]);
            cliente.nombre = (String)lector["clie_nombre"];
            cliente.habilitado = (bool)lector["clie_habilitado"];
            cliente.apellido = (String)lector["clie_apellido"];
            cliente.fecha_nac = (DateTime)lector["clie_fecha_nac"];
            cliente.mail = (String)lector["clie_mail"];
            if (lector["clie_telefono"] != System.DBNull.Value)
                cliente.telefono = (String)lector["clie_telefono"];
            if(direccionExistente(cliente.dni))
                cliente.direccion = obtenerDireccionCliente(cliente.dni);


            return cliente;
        }

        private static Direccion obtenerDireccionCliente(int dni)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@dni", dni));

            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_DIRECCION", "SP", parametros);

            Direccion direccion = new Direccion();

            if (lector.HasRows)
            {
                lector.Read();
                direccion.cp = Convert.ToInt16(lector["dir_cod_postal"]);
                direccion.localidad = (String)lector["dir_localidad"];
                if (lector["dir_piso"] != System.DBNull.Value)
                    direccion.piso = Convert.ToInt16(lector["dir_piso"]);
                if (lector["dir_depto"] != System.DBNull.Value)
                    direccion.dpto = (lector["dir_depto"].ToString()).First();
                direccion.calle = (String)lector["dir_calle"];
                lector.Close();
            }
            return direccion;
        }

        public static void eliminarCliente(int dni)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@dni", dni));

            DataBase.GetDataReader("404_NOT_FOUND.SP_ELIMINAR_CLIENTE", "SP", parametros);

        }

        public static void habilitarCliente(int dni)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@dni", dni));

            DataBase.GetDataReader("404_NOT_FOUND.SP_HABILITAR_CLIENTE", "SP", parametros);

        }

        public static void modificarCliente(Cliente cliente)
        {
            //parametros.Add(new SqlParameter("@dni_nuevo", dni_nuevo));
            DataBase.WriteInBase("404_NOT_FOUND.SP_MODIFICAR_CLIENTE", "SP", buildParametrosCliente(cliente));

        }
    }
}
