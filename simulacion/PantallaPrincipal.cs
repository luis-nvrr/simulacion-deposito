using simulacion_mecanicos.simulacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios.Colas
{
    public partial class PantallaPrincipal : Form
    {
        double mediaLlegadasSinAyudante;
        double mediaLlegadasConAyudante;
        double mediaFinAtencionSinAyudante;
        double mediaFinAtencionConAyudante;
        int cantidadLineas;
        int cantidadSimulaciones;
        int desde;
        int hasta;
        GestorSimulacion gestor;
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaResultados_Load(object sender, EventArgs e)
        {
            txtMediaLlegadas1.Text = "6.0";
            txtMediaAtencion1.Text = "5.0";
            txtMediaLlegadas2.Text = "6.0";
            txtMediaAtencion2.Text = "4.0";
            txtCantidadSimulaciones.Text = "10";
            txtCantidadLineas.Text = "1000";
            txtDesde.Text = "0";
            txtHasta.Text = "500";
        }

        public void mostrarOpcionSinAyudante(int cantidadMenor)
        {
            string mensaje = "Conviene la opcion" + "\n"
                + "SIN AYUDANTE, ya que en " + "\n"
                + cantidadSimulaciones + " simulaciones," + "\n"
                + cantidadMenor + " veces el COSTO fue MENOR";
            this.lblTexto.Text = mensaje;
        }

        public void mostrarOpcionConAyudante(int cantidadMenor)
        {
            string mensaje = "Conviene la opcion" + "\n"
                + "CON AYUDANTE, ya que en " + "\n"
                + cantidadSimulaciones + " simulaciones," + "\n"
                + cantidadMenor + " veces el COSTO fue MENOR";
            this.lblTexto.Text = mensaje;
        }

        public void mostrarResultados(DataTable resultados)
        {
            this.grdResultados.DoubleBuffered(true);
            grdResultados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdResultados.DataSource = resultados;

        }

        private void grdRangoResultados_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 1;
        }

        private void grdRangoResultados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdResultados.ClearSelection();
        }

        private void cerrarVentanas()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "PantallaPrincipal")
                    f.Close();
            }
        }

        private void tomarParametros()
        {
            grdResultados.DataSource = null;
            grdResultados.Columns.Clear();
            grdResultados.CellClick -= grdResultados_CellClick;
            grdResultados.Refresh(); 

            mediaLlegadasSinAyudante = double.Parse(txtMediaLlegadas1.Text);
            mediaFinAtencionSinAyudante = double.Parse(txtMediaAtencion1.Text);
            mediaLlegadasConAyudante = double.Parse(txtMediaLlegadas2.Text);
            mediaFinAtencionConAyudante = double.Parse(txtMediaAtencion2.Text);

            cantidadSimulaciones = int.Parse(txtCantidadSimulaciones.Text);
            cantidadLineas = int.Parse(txtCantidadLineas.Text);
            desde = int.Parse(txtDesde.Text);
            hasta = int.Parse(txtHasta.Text);
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            tomarParametros();

            if (esRangoValido(desde, hasta)) 
            {
                gestor = new GestorSimulacion(this);
                gestor.tomarParametrosSimulacion(cantidadLineas, desde, hasta, cantidadSimulaciones);
                gestor.tomarDistribuciones(mediaLlegadasSinAyudante, mediaFinAtencionSinAyudante,
                    mediaLlegadasConAyudante, mediaFinAtencionConAyudante);
                gestor.simular();
                agregarBotones();
            }
            else
            {
                mensajeFueraDeRango();
            }
        }

        private Boolean esRangoValido(int desde, int hasta)
        {
            return hasta - desde <= 500;
        }

        private void mensajeFueraDeRango()
        {
            MessageBox.Show("El rango puede ser hasta 500 filas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ajustarTamañoColumnas()
        {
            grdResultados.Columns[0].Width = 100;
            grdResultados.Columns[1].Width = 100;
            grdResultados.Columns[2].Width = 100;
        }

        private void agregarBotones()
        {
            DataGridViewButtonColumn columnaBotones = new DataGridViewButtonColumn();
            columnaBotones.Name = "Abrir";
            columnaBotones.Text = "Abrir";
            int columnIndex = grdResultados.Columns.Count;
            grdResultados.Columns.Insert(columnIndex, columnaBotones);

            grdResultados.CellClick += grdResultados_CellClick;
        }

        private void grdResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdResultados.Columns["Abrir"].Index)
            {
                int fila = e.RowIndex;
                gestor.mostrarPantalla(fila);
            }
        }
    }
}
