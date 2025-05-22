using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    public partial class frmGrafo : Form
    {
        clsGrafo Grafo = new clsGrafo();
        public frmGrafo()
        {
            InitializeComponent();
            clsTemas.AplicarTema(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            Grafo.MostrarCiudades(cmbDestinoConsulta);
            Grafo.MostrarCiudades(cmbDestino);
            Grafo.MostrarCiudades(cmbOrigen);
            Grafo.MostrarCiudades(cmbOrigenConsulta);
            Grafo.MostrarCiudades(cmbDesde);
            Grafo.MostrarCiudades(cmbHasta);
            //Grafo.MostrarTodo(dataGridView1);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 x = cmbOrigen.SelectedIndex;
            Int32 y = cmbDestino.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecio.Text);
            Grafo.Agregar(x, y, p);
            Grafo.MostrarTodo(dataGridView1);
            MessageBox.Show("Precio Cargado!!!");
            txtPrecio.Text = "";
            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 0;
        }
    }
}
