using Numeros_aleatorios.LibreriaSimulacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_mecanicos.simulacion
{
    class Linea
    {
        public string INICIALIZACION = "inicializacion";
        public string LLEGADA_MECANICO = "llegada de mecanico";
        public string FIN_ATENCION = "fin de atencion";
        private int id;
        private string evento;
        private double reloj;
        private Estado estado;
        private Atencion atencion;
        private Llegada llegada;
        private Queue<Mecanico> mecanicosLibres;
        private List<Mecanico> mecanicosEnSistema;
        private Simulacion simulacion;
        private double costoEmpleado;
        private double costoAyudante;
        private double costoMecanicos;
        private double costoAcumulado;
        private Truncador truncador;

        public Linea(double mediaLlegadas, double mediaFinAtencion, Simulacion simulacion)
        {
            this.truncador = new Truncador(4);
            this.simulacion = simulacion;
            this.estado = new EstadoInicializacion();
            estado.NuevaLinea(this, mediaLlegadas, mediaFinAtencion);
        }

        public void agregarAyudante()
        {
            this.atencion.agregarAyudante();
        }

        public void inicializar(double mediaLlegadas, double mediaFinAtencion)
        {
            this.id = 0;
            this.evento = INICIALIZACION;
            this.reloj = 0;
            this.estado = new EstadoLlegadaMecanico();
            this.atencion = new Atencion(mediaFinAtencion);
            this.llegada = new Llegada(mediaLlegadas);
            this.mecanicosLibres = new Queue<Mecanico>();
            this.mecanicosEnSistema = new List<Mecanico>();
        }

        public void incrementar()
        {
            this.id++;
        }

        public void setReloj(double reloj)
        {
            this.reloj = truncador.truncar(reloj);
        }

        public void recibirMecanico()
        {
            estado.RecibirCliente(this);

        }
        public void terminarAtencion()
        {
            estado.FinalizarAtencion(this);
        }

        public int getId()
        {
            return this.id;
        }

        public string getEvento()
        {
            return this.evento;
        }

        public double getReloj()
        {
            return this.reloj;
        }

        public double getRNDLlegadaMecanico()
        {
            return truncador.truncar(llegada.getRNDLlegada());
        }

        public double getTiempoLlegada()
        {
            return truncador.truncar(llegada.getTiempoLlegada());
        }

        public double getSiguienteLlegada()
        {
            return truncador.truncar(llegada.getSiguienteLlegada());
        }

        public double getRNDAtencion()
        {
            return truncador.truncar(atencion.getRNDAtencion());
        }

        public double getTiempoAtencion()
        {
            return truncador.truncar(atencion.getTiempoAtencion());
        }

        public double getSiguienteFinAtencion()
        {
            return truncador.truncar(atencion.getSiguienteFinAtencion());
        }

        public string getEstadoEmpleado()
        {
            return atencion.getEstadoEmpleado();
        }

        public string getEstadoAyudante()
        {
            return atencion.getEstadoAyudante();
        }

        public int getCantidadEnCola()
        {
            return atencion.getCantidadEnCola();
        }

        public int getCantidadClientes()
        {
            return this.mecanicosEnSistema.Count();
        }

        public string getEstadoMecanico(int i)
        {
            return this.mecanicosEnSistema[i].getEstado();
        }

        public double getHoraInicioEspera(int i)
        {
            return this.mecanicosEnSistema[i].getHoraInicioEspera();
        }

        public void cambiarEstado()
        {
            this.estado.CambiarEstado(this);
        }

        public string calcularSiguienteEvento()
        {
            double min = llegada.getSiguienteLlegada();
            string e = LLEGADA_MECANICO;

            if(atencion.getSiguienteFinAtencion() < min && atencion.getSiguienteFinAtencion() != -1) {
                e = FIN_ATENCION;
            }
            return e;
        }

        private Mecanico buscarMecanicoLibre()
        {
            if(mecanicosLibres.Count > 0)
            {
                return mecanicosLibres.Dequeue();
            }
            Mecanico nuevo = new Mecanico();
            mecanicosEnSistema.Add(nuevo);
            simulacion.agregarColumna();
            return nuevo;
        }

        public void atenderNuevoMecanico()
        {
            Mecanico nuevoMecanico = buscarMecanicoLibre();
            if (atencion.estaLibre())
            {
                atencion.atender(nuevoMecanico, reloj);
            }
            else
            {
                atencion.esperar(nuevoMecanico, reloj);
            }
        }

        public void setEstado(Estado estado)
        {
            this.estado = estado;
        }
        
        public void setEvento(string evento)
        {
            this.evento = evento;
        }

        public void generarSiguienteLlegada()
        {
            this.llegada.generarSiguienteLlegada(reloj);
        }

        public void finalizarAtencionActual()
        {
            this.atencion.finalizarAtencion(this);
        }

        public void agregarMecanicoLibre(Mecanico mecanico)
        {
            this.mecanicosLibres.Enqueue(mecanico);
        }

        public void generarSiguienteFinAtencion()
        {
            atencion.generarSiguienteFinAtencion(reloj);
        }

        public double getCostoAcumulado()
        {
            return costoAcumulado;
        }

        public double getCostoEmpleado()
        {
            return this.costoEmpleado;
        }

        public double getCostoAyudante()
        {
            return this.costoAyudante;
        }

        public double getCostoMecanicos()
        {
            return this.costoMecanicos;
        }

        public void agregarCostoEmpleado(double siguienteEvento)
        {
            this.costoEmpleado = truncador.truncar(this.costoEmpleado + (12.0/60.0) * (siguienteEvento - reloj));
        }
        public void agregarCostoAyudante(double siguienteEvento)
        {
            if (atencion.tieneAyudante())
            {
                this.costoAyudante = truncador.truncar(this.costoAyudante + (8.0 / 60.0) * (siguienteEvento - reloj));
            }
        }

        public void agregarCostoMecanicos(double siguienteEvento)
        {
            foreach(Mecanico mecanico in mecanicosEnSistema){
                if (mecanico.estaEsperando())
                {
                    this.costoMecanicos = truncador.truncar(this.costoMecanicos + (20.0 / 60.0) * (siguienteEvento - reloj));
                }
            }
        }

        public void calcularCostosAcumulados()
        {
            this.costoAcumulado = truncador.truncar(costoEmpleado + costoAyudante + costoMecanicos);
        }
    }
}
