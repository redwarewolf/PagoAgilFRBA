using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    class Cliente
    {
        public Direccion direccion { get; set; }
        public String apellido { get; set; }
        public String nombre { get; set; }
        public DateTime fecha_nac { get; set; }
        public String mail { get; set; }
        public Boolean habilitado { get; set; }
        public String telefono { get; set; }
        public int dni { get; set; }
    }
}
