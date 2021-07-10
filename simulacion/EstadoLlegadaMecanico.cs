using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    class EstadoLlegadaMecanico : Estado
    {
        public void FinalizarAtencion(Linea linea)
        {
            return;
        }

        public void NuevaLinea(Linea linea, double mediaLLegadas, double mediaFinAtencion)
        {
            return;
        }

        public void RecibirCliente(Linea linea)
        {
            linea.agregarCostoEmpleado(linea.getSiguienteLlegada());
            linea.agregarCostoAyudante(linea.getSiguienteLlegada());
            linea.agregarCostoMecanicos(linea.getSiguienteLlegada());
            linea.calcularCostosAcumulados();
            linea.incrementar();
            linea.setReloj(linea.getSiguienteLlegada());
            linea.setEvento(linea.LLEGADA_MECANICO);
            linea.atenderNuevoMecanico();
            linea.generarSiguienteLlegada();
        }

        public void CambiarEstado(Linea linea)
        {
            string evento = linea.calcularSiguienteEvento();
            if (evento == linea.FIN_ATENCION)
            {
                linea.setEstado(new EstadoFinAtencion());
            }
        }

    }
}
