using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo
{
    class Trimestre
    {
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }

        
        public void configurar(int ano, int numeroTrimestre)
        {
            int mesInicio = 0;
            int diaFin = 0;
            int mesFin = 0;

            switch(numeroTrimestre)
            {
                case 1:
                    mesInicio = 01;
                    diaFin = 31;
                    mesFin = 03;
                    break;
                case 2:
                    mesInicio = 04;
                    diaFin = 30;
                    mesFin = 06;
                    break;
                case 3:
                    mesInicio = 07;
                    diaFin = 30;
                    mesFin = 09;
                    break;
                case 4:
                    mesInicio = 10;
                    diaFin = 31;
                    mesFin = 12;
                    break;
            }
            int diaInicio = 01;
            this.fecha_inicio = new DateTime(ano,mesInicio,diaInicio);
            this.fecha_fin = new DateTime(ano, mesFin, diaFin);
        }
    }
}
