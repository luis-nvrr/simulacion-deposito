using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    interface Estado
    {
        void NuevaLinea(Linea linea, double mediaLlegadas, double mediaFinAtencion);
        void RecibirCliente(Linea linea);
        void FinalizarAtencion(Linea linea);
        void CambiarEstado(Linea linea);
    }
}
