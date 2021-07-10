using Numeros_aleatorios.Colas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion_mecanicos.simulacion
{
    public partial class PantallaGrillas : Form
    {
        public PantallaGrillas()
        {
            InitializeComponent();
        }

        public void mostrarGrillaSinAyudante(DataTable resultados)
        {
            this.grdSinAyudante.DoubleBuffered(true);
            grdSinAyudante.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdSinAyudante.DataSource = resultados;
        }

        public void mostrarGrillaConAyudante(DataTable resultados)
        {
            this.grdConAyudante.DoubleBuffered(true);
            grdConAyudante.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConAyudante.DataSource = resultados;
        }

        public void agregarCostoSinAyudante(double costo)
        {
            this.txtCostoSinAyudante.Text = costo.ToString();
        }

        public void agregarCostoConAyudante(double costo)
        {
            this.txtCostoConAyudante.Text = costo.ToString();
        }

    }
}
