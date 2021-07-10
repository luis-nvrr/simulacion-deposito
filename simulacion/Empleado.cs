using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    class Empleado
    {
        private string LIBRE = "libre";
        private string OCUPADO = "ocupado";

        private string estado;
        private Queue<Mecanico> mecanicosEnEspera;

        public Empleado()
        {
            this.estado = LIBRE;
            this.mecanicosEnEspera = new Queue<Mecanico>();
        }

        public string getEstado()
        {
            return this.estado;
        }

        public int getCantidadEnCola()
        {
            return this.mecanicosEnEspera.Count;
        }

        public Boolean estaLibre()
        {
            return this.estado == LIBRE;
        }

        public void esperar(Mecanico mecanico)
        {
            this.mecanicosEnEspera.Enqueue(mecanico);
        }

        public void atender()
        {
            this.estado = OCUPADO;
        }

        public void liberar()
        {
            this.estado = LIBRE;
        }

        public Boolean tieneCola()
        {
            return this.mecanicosEnEspera.Count > 0;
        }

        public Mecanico getSiguienteMecanico()
        {
            return this.mecanicosEnEspera.Dequeue();
        }
    }
}
