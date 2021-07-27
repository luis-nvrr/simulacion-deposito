using Numeros_aleatorios.LibreriaSimulacion;
using Numeros_aleatorios.LibreriaSimulacion.GeneradoresAleatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    class Atencion
    {
        private Mecanico mecanicoActual;
        private Empleado empleado;
        private Empleado ayudante;

        private double random;
        private double tiempoAtencion;
        private double finAtencion;

        private Truncador truncador;
        private IGenerador generadorExponencial;
        private GeneradorUniformeLenguaje generadorUniforme;

        public Atencion(double media)
        {
            this.mecanicoActual = null;
            this.empleado = new Empleado();
            this.ayudante = null;
            this.random = -1;
            this.tiempoAtencion = -1;
            this.finAtencion = -1;

            this.truncador = new Truncador(4);
            this.generadorUniforme = new GeneradorUniformeLenguaje(truncador);
            this.generadorExponencial = new GeneradorExponencialNegativa(generadorUniforme,truncador, 1.0 / media);
        }

        public void agregarAyudante()
        {
            this.ayudante = new Empleado();
        }

        public double getRNDAtencion()
        {
            return random;
        }

        public double getTiempoAtencion()
        {
            return tiempoAtencion;
        }

        public double getSiguienteFinAtencion()
        {
            return finAtencion;
        }

        public string getEstadoEmpleado()
        {
            return empleado.getEstado();
        }

        public string getEstadoAyudante()
        {
            if (ayudante == null) return "";
            return ayudante.getEstado();
        }

        public int getCantidadEnCola()
        {
            return empleado.getCantidadEnCola();
        }

        public Boolean estaLibre()
        {
            return empleado.estaLibre();
        }

        public Boolean tieneAyudante()
        {
            return this.ayudante != null;
        }

        private void generarFinAtencion(double reloj)
        {
            this.tiempoAtencion = generadorExponencial.siguienteAleatorio();
            this.finAtencion = truncador.truncar(reloj + tiempoAtencion);
            this.random = ((GeneradorExponencialNegativa)generadorExponencial).getAleatorioUniforme();
        }

        public void atender(Mecanico mecanico, double reloj)
        {
            generarFinAtencion(reloj);
            mecanicoActual = mecanico;
            mecanico.atender();
            empleado.atender();
           
            if(ayudante != null)
            {
                ayudante.atender();
            }

        }

        public void esperar(Mecanico mecanico, double reloj)
        {
            empleado.esperar(mecanico);
            mecanico.esperar(reloj);
        }

        public void finalizarAtencion(Linea linea)
        {
            mecanicoActual.liberar();
            empleado.liberar();

            if(ayudante != null)
            {
                ayudante.liberar();
            }
      

            linea.agregarMecanicoLibre(mecanicoActual);
            mecanicoActual = null;
            this.random = -1;
            this.tiempoAtencion = -1;
            this.finAtencion = -1;

        }

        public void generarSiguienteFinAtencion(double reloj)
        {
            if (empleado.tieneCola())
            {
                atender(empleado.getSiguienteMecanico(), reloj);
            }
        }

    }
}
