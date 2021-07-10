using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion_mecanicos.simulacion
{
    class Simulacion
    {
        private int desde;
        private int hasta;
        private int cantidadLineas;
        private Linea linea;
        private DataTable resultados;

        private double ultimoRNDLlegadas;
        private double ultimoTiempoParaLlegadas;
        private double ultimoRNDAtencion;
        private double ultimoFinAtencion;

        public Simulacion(int desde, int hasta, int cantidadLineas,
            double mediaLlegadas, double mediaFinAtencion) {
            this.desde = desde;
            this.hasta = hasta;
            this.cantidadLineas = cantidadLineas;
            this.linea = new Linea(mediaLlegadas, mediaFinAtencion,this);
            crearTabla();
        }

        public void agregarAyudante()
        {
            this.linea.agregarAyudante();
        }

        public void simular()
        {
            agregarLinea();
            for (int i = 1; i <= cantidadLineas; i++)
            {
                linea.recibirMecanico();
                linea.terminarAtencion();
                linea.cambiarEstado();

                if(i >= desde && i <= hasta)
                {
                    agregarLinea();
                }
            }
            agregarLinea();
        }

        public void crearTabla()
        {
            this.resultados = new DataTable();
            resultados.Columns.Add("i", typeof(string));
            resultados.Columns.Add("evento", typeof(string));
            resultados.Columns.Add("reloj", typeof(string));
            resultados.Columns.Add("RND llegada", typeof(string));
            resultados.Columns.Add("tiempo para llegada", typeof(string));
            resultados.Columns.Add("siguiente llegada", typeof(string));
            resultados.Columns.Add("RND atencion", typeof(string));
            resultados.Columns.Add("tiempo de atencion", typeof(string));
            resultados.Columns.Add("fin de atencion", typeof(string));
            resultados.Columns.Add("estado empleado", typeof(string));
            resultados.Columns.Add("estado ayudante", typeof(string));
            resultados.Columns.Add("cola", typeof(string));
            resultados.Columns.Add("costo de empleado", typeof(string));
            resultados.Columns.Add("costo de ayudante", typeof(string));
            resultados.Columns.Add("costo de mecanicos", typeof(string));
        }

        private void agregarLinea()
        {
            DataRow row = resultados.NewRow(); row[0] = linea.getId();
            double rndLlegadas = linea.getRNDLlegadaMecanico();

            if (rndLlegadas != ultimoRNDLlegadas) { 
                ultimoRNDLlegadas = rndLlegadas;
                row[3] = rndLlegadas;
                row[4] = linea.getTiempoLlegada();
            }

            double rndAtencion = linea.getRNDAtencion();

            if (rndAtencion != ultimoRNDAtencion)
            {
                ultimoRNDAtencion = rndAtencion;
                row[6] = (linea.getRNDAtencion() != -1) ? linea.getRNDAtencion() : "";
                row[7] = (linea.getTiempoAtencion() != -1) ? linea.getTiempoAtencion() : "";
            }
             
            row[1] = linea.getEvento();
            row[2] = linea.getReloj();
            row[5] = linea.getSiguienteLlegada();
            row[8] = linea.getSiguienteFinAtencion() != -1 ? linea.getSiguienteFinAtencion() : "";
            row[9] = linea.getEstadoEmpleado();
            row[10] = linea.getEstadoAyudante();
            row[11] = linea.getCantidadEnCola();
            row[12] = linea.getCostoEmpleado();
            row[13] = linea.getCostoAyudante();
            row[14] = linea.getCostoMecanicos();


            int indice = 14;
            int cantidadClientes = linea.getCantidadClientes();
            for (int j = 0; j < cantidadClientes; j++)
            {
                indice += 1;
                row[indice] = linea.getEstadoMecanico(j) != "libre" ? linea.getEstadoMecanico(j) : "";
                indice += 1;
                row[indice] = linea.getHoraInicioEspera(j) != -1 ? linea.getHoraInicioEspera(j) : "";
            }

            resultados.Rows.Add(row);
        }

        public void agregarColumna()
        {
            int idCliente = linea.getCantidadClientes();
            this.resultados.Columns.Add("estado " + idCliente, typeof(string));
            this.resultados.Columns.Add("inicio espera " + idCliente, typeof(string));
        }


        public DataTable getResultados()
        {
            return this.resultados;
        }

        public double getCostoAcumulado()
        {
            return this.linea.getCostoAcumulado();
        }

    }
}
