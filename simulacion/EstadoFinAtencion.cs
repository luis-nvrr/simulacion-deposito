using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    class EstadoFinAtencion : Estado
    {
        public void FinalizarAtencion(Linea linea)
        {
            linea.agregarCostoEmpleado(linea.getSiguienteFinAtencion());
            linea.agregarCostoAyudante(linea.getSiguienteFinAtencion());
            linea.agregarCostoMecanicos(linea.getSiguienteFinAtencion());
            linea.calcularCostosAcumulados();
            linea.incrementar();
            linea.setReloj(linea.getSiguienteFinAtencion());
            linea.setEvento(linea.FIN_ATENCION);
            linea.finalizarAtencionActual();
            linea.generarSiguienteFinAtencion();
        }

        public void NuevaLinea(Linea linea, double mediaLlegadas, double mediaFinAtencion)
        {
            return;
        }

        public void RecibirCliente(Linea linea)
        {
            return;
        }

        public void CambiarEstado(Linea linea)
        {
            string evento = linea.calcularSiguienteEvento();
            if (evento == linea.LLEGADA_MECANICO)
            {
                linea.setEstado(new EstadoLlegadaMecanico());
            }
        }
    }
}
