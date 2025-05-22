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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDelProgramador x = new frmDatosDelProgramador();
            x.ShowDialog();
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades ciudad = new frmCiudades();
            ciudad.ShowDialog();

        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvincias prov = new frmProvincias();
            prov.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola col = new frmCola();
            col.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pil = new frmPila();
            pil.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListaSimple simple = new frmListaSimple();
            simple.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble doble = new frmListaDoble();
            doble.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario arbol = new frmArbolBinario();
            arbol.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo Graf = new frmGrafo();
            Graf.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void claroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTemas.TemaActual = clsTemas.TipoTema.Claro;

            foreach (Form frm in Application.OpenForms)
            {
                clsTemas.AplicarTema(frm);
            }
        }

        private void oscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                clsTemas.TemaActual = clsTemas.TipoTema.Oscuro;

                foreach (Form frm in Application.OpenForms)
                {
                    clsTemas.AplicarTema(frm);
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mostrarUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosMostrarTabla Mostrar = new frmBaseDatosMostrarTabla();
            Mostrar.ShowDialog();
        }

        private void consultaDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosConsultasSql mostrarConsultas = new frmBaseDatosConsultasSql();
            mostrarConsultas.ShowDialog();
        }

        private void operacionesEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatosOperaciones operaciones = new frmBaseDeDatosOperaciones();
            operaciones.ShowDialog();
        }
    }
}
