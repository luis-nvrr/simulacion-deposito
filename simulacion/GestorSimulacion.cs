using Numeros_aleatorios.Colas;
using Numeros_aleatorios.LibreriaSimulacion;
using System.Collections.Generic;
using System.Data;

namespace simulacion_mecanicos.simulacion
{
    class GestorSimulacion
    {
        public string CON_AYUDANTE = "con ayudante";
        public string SIN_AYUDANTE = "sin ayudante";
        private PantallaPrincipal pantalla;
        private double mediaLlegadasSinAyudante;
        private double mediaFinAtencionSinAyudante;
        private double mediaLlegadasConAyudante;
        private double mediaFinAtencionConAyudante;
        private int cantidadLineas;
        private int cantidadSimulaciones;
        private int desde;
        private int hasta;
        private Simulacion simulacionSinAyudante;
        private Simulacion simulacionConAyudante;
        private List<List<DataTable>> grillas;
        private DataTable resultados;
        private Truncador truncador;
        private int contadorConAyudante;
        private int contadorSinAyudante;
        private List<List<double>> costos;

        public GestorSimulacion(PantallaPrincipal pantalla)
        {
            this.pantalla = pantalla;
            this.grillas = new List<List<DataTable>>();
            this.costos = new List<List<double>>();
            this.truncador = new Truncador(4);
            construirTabla();
        }

        private void construirTabla()
        {
            this.resultados = new DataTable();
            this.resultados.Columns.Add("Costo sin ayudante", typeof(string));
            this.resultados.Columns.Add("Costo con ayudante", typeof(string));
            this.resultados.Columns.Add("Conviene", typeof(string));
            this.resultados.Columns.Add("Contador SIN", typeof(string));
            this.resultados.Columns.Add("Contador CON", typeof(string));
        }

        public void tomarParametrosSimulacion(int cantidadLineas, int desde, int hasta, int cantidadSimulaciones)
        {
            this.cantidadLineas = cantidadLineas;
            this.desde = desde;
            this.hasta = hasta;
            this.cantidadSimulaciones = cantidadSimulaciones;
        }

        public void tomarDistribuciones(double mediaLlegadasSinAyudante, double mediaFinAtencionSinAyudante,
            double mediaLlegadasConAyudante, double mediaFinAtencionConAyudante)
        {
            this.mediaLlegadasSinAyudante = mediaLlegadasSinAyudante;
            this.mediaFinAtencionSinAyudante = mediaFinAtencionSinAyudante;
            this.mediaLlegadasConAyudante = mediaLlegadasConAyudante;
            this.mediaFinAtencionConAyudante = mediaFinAtencionConAyudante;

        }

        public void simular()
        {
            for (int i = 0; i < cantidadSimulaciones; i++)
            {
                simularSinAyudante();
                simularConAyudante();
                guardarGrillas();
                agregarResultados();
            }
            this.pantalla.mostrarResultados(resultados);

            if (contadorConAyudante > contadorSinAyudante) { this.pantalla.mostrarOpcionConAyudante(contadorConAyudante); }
            else { this.pantalla.mostrarOpcionSinAyudante(contadorSinAyudante); }
        }

        private void simularSinAyudante()
        {
            simulacionSinAyudante = new Simulacion(desde, hasta, cantidadLineas, mediaLlegadasSinAyudante, mediaFinAtencionSinAyudante);
            this.simulacionSinAyudante.simular();
        }

        private void simularConAyudante()
        {
            simulacionConAyudante = new Simulacion(desde, hasta, cantidadLineas, mediaLlegadasConAyudante, mediaFinAtencionConAyudante);
            simulacionConAyudante.agregarAyudante();
            this.simulacionConAyudante.simular();
        }

        private void guardarGrillas()
        {
            List<DataTable> temp = new List<DataTable>();
            temp.Add(simulacionSinAyudante.getResultados());
            temp.Add(simulacionConAyudante.getResultados());
            this.grillas.Add(temp);

            List<double> tempCostos = new List<double>();
            tempCostos.Add(simulacionSinAyudante.getCostoAcumulado());
            tempCostos.Add(simulacionConAyudante.getCostoAcumulado());
            this.costos.Add(tempCostos);
        }

        private void agregarResultados()
        {
            double costoSinAyudante = simulacionSinAyudante.getCostoAcumulado();
            double costoConAyudante = simulacionConAyudante.getCostoAcumulado(); 
            DataRow row = resultados.NewRow();

            row[0] = truncador.truncar(costoSinAyudante);
            row[1] = truncador.truncar(costoConAyudante);

            string conviene = costoSinAyudante < costoConAyudante ? SIN_AYUDANTE : CON_AYUDANTE;
            row[2] = conviene;

            if(conviene == SIN_AYUDANTE) { contadorSinAyudante++; }
            else
            {
                contadorConAyudante++;
            }
            row[3] = contadorSinAyudante;
            row[4] = contadorConAyudante;

            resultados.Rows.Add(row);
        }


        public void mostrarPantalla(int fila)
        {
            PantallaGrillas pantallaGrillas = new PantallaGrillas();
            pantallaGrillas.mostrarGrillaSinAyudante(this.grillas[fila][0]);
            pantallaGrillas.mostrarGrillaConAyudante(this.grillas[fila][1]);
            pantallaGrillas.agregarCostoSinAyudante(this.costos[fila][0]);
            pantallaGrillas.agregarCostoConAyudante(this.costos[fila][1]);
            pantallaGrillas.Show();
        }

    }
}
