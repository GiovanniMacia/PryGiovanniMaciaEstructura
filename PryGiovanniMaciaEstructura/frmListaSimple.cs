using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryGiovanniMaciaEstructura
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
            clsTemas.AplicarTema(this);
        }
        clsListSimple Lista = new clsListSimple();
        clsArchivo x = new clsArchivo();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Código = Convert.ToInt32(txtCódigoLista.Text);
            Persona.Nombre = txtNombreLista.Text;
            Persona.Trámite = txtTrámiteLista.Text;

            Lista.Agregar(Persona);
            Lista.Recorrer();
            Lista.Recorrer(cmbDatosLista);
            Lista.Recorrer(dgvDatosLista);
            Lista.Recorrer(lstDatosLista);
            limpiarTodo();
            Lista.Recorrer();
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "ListaSimple.csv";
            if (!File.Exists(x.NombreArchivo))
            {
                MessageBox.Show("Primera vez usando la lista doble. Aún no hay datos guardados.");
            }
            else
            {
                x.Recorrer(dgvDatosLista);
            }

            Lista.Agregar();
            Lista.Recorrer("ListaSimple.csv");
            Lista.Recorrer(cmbDatosLista);
            Lista.Recorrer(dgvDatosLista);
            Lista.Recorrer(lstDatosLista);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbDatosLista.SelectedItem != null)
            {
                try
                {
                    Lista.Eliminar(Convert.ToInt32(cmbDatosLista.SelectedItem));
                    MessageBox.Show("Se eliminó correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún valor a eliminar.");
            }
            limpiarTodo();
        }

        private void cmbDatosLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatosLista.Text == "")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }
        private void validarDatos()
        {
            if (txtCódigoLista.Text != "" && txtNombreLista.Text != "" && txtTrámiteLista.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void limpiarTodo()
        {
            txtCódigoLista.Text = "";
            txtNombreLista.Text = "";
            txtTrámiteLista.Text = "";
             cmbDatosLista.Text = "";
            Lista.Recorrer();
            Lista.Recorrer(dgvDatosLista);
            Lista.Recorrer(lstDatosLista);
        }

        private void txtCódigoLista_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtNombreLista_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtTrámiteLista_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }
    }
}
