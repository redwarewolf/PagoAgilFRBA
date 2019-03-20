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
    class RubrosRepositorio
    {
        public static List<Rubro> getRubros()
        {
            List<Rubro> rubros = new List<Rubro>();
            SqlDataReader lector = DataBase.GetDataReader("404_NOT_FOUND.SP_BUSCAR_RUBROS", "SP", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rubro rubro = buildRubro(lector);
                    rubros.Add(rubro);
                }
                lector.Close();
            }
            return rubros;
        }

        private static Rubro buildRubro(SqlDataReader lector)
        {
            Rubro rubro = new Rubro();
            rubro.id = Convert.ToInt32(lector["rubr_id"]);
            rubro.detalle = (String)lector["rubr_detalle"];

            return rubro;
        }

    }
}
