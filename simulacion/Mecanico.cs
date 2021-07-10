using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    class Mecanico
    {
        private string SIENDO_ATENDIDO = "siendo atendido";
        private string ESPERANDO_ATENCION = "esperando atencion";
        private string LIBRE = "libre";
        private string estado;
        private double horaInicioEspera;

        public Mecanico()
        {
            this.estado = LIBRE;
            this.horaInicioEspera = -1;
        }

        public void atender() {
            this.estado = SIENDO_ATENDIDO;
        }

        public string getEstado()
        {
            return estado;
        }

        public double getHoraInicioEspera()
        {
            return horaInicioEspera;
        }

        public void esperar(double reloj)
        {
            this.estado = ESPERANDO_ATENCION;
            this.horaInicioEspera = reloj;
        }

        public Boolean estaEsperando()
        {
            return this.estado == ESPERANDO_ATENCION;
        }

        public void liberar()
        {
            this.estado = LIBRE;
            this.horaInicioEspera = -1;
        }
    }
}
