using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Modelo;

namespace PagoAgilFrba.Modelo
{
     public class Usuario
    {
        public String nombre { get; set; }
        public String password { get; set; }
        public Sucursal sucursal { get; set; }
        public Rol rol { get; set; }

        public Usuario(String nombre, String contrasena)
        {
            this.nombre = nombre;
            this.password = contrasena;
        }

     }
}
