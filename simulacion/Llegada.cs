using Numeros_aleatorios.LibreriaSimulacion;
using Numeros_aleatorios.LibreriaSimulacion.GeneradoresAleatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    class Llegada
    {
        private double random;
        private double tiempoParaLlegada;
        private double siguienteLlegada;

        private Truncador truncador;
        private IGenerador generadorExponencial;
        private GeneradorUniformeLenguaje generadorUniforme;

        public Llegada(double media)
        {
            this.truncador = new Truncador(4);
            this.generadorUniforme = new GeneradorUniformeLenguaje(truncador);
            this.generadorExponencial = new GeneradorExponencialNegativa(generadorUniforme, truncador, 1.0 / media);
            generarSiguienteLlegada(0);
        }

        public void generarSiguienteLlegada(double reloj)
        {
            this.siguienteLlegada = reloj + generadorExponencial.siguienteAleatorio();
            this.tiempoParaLlegada = ((GeneradorExponencialNegativa)generadorExponencial).getAleatorio();
            this.random = ((GeneradorExponencialNegativa)generadorExponencial).getAleatorioUniforme();
        }

        public double getRNDLlegada()
        {
            return this.random;
        }

        public double getTiempoLlegada()
        {
            return this.tiempoParaLlegada;
        }

        public double getSiguienteLlegada()
        {
            return this.siguienteLlegada;
        }
    }
}
