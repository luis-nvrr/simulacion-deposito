using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    class EstadoInicializacion : Estado
    {
        public void FinalizarAtencion(Linea linea)
        {
            return;
        }

        public void NuevaLinea(Linea linea, double mediaLlegadas, double mediaFinAtencion)
        {
            linea.inicializar(mediaLlegadas, mediaFinAtencion);
        }

        public void RecibirCliente(Linea linea)
        {
            return;
        }
       
        public void CambiarEstado(Linea linea)
        {
            return;
        }
    }
}
