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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Lista = new clsListaDoble();
        clsArchivo x = new clsArchivo();

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "ListaDoble.csv";
            if (!File.Exists(x.NombreArchivo))
            {
                MessageBox.Show("Primera vez usando la lista doble. Aún no hay datos guardados.");
            }
            else
            {
                x.Recorrer(dgvDatos);
            }

            Lista.Agregar();
            Lista.Recorrer("ListaDoble.csv");
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer(dgvDatos);
            Lista.Recorrer(lstDatos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Código = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Trámite = txtTramite.Text;

            Lista.Agregar(Persona);
            Lista.Recorrer();
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer(dgvDatos);
            Lista.Recorrer(lstDatos);
            limpiarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedItem != null)
            {
                try
                {

                    string seleccionado = cmbCodigo.SelectedItem.ToString();
                    string[] partes = seleccionado.Split(' ');
                    int codigo = Convert.ToInt32(partes[0]);

                    Lista.Eliminar(codigo);
                    MessageBox.Show("Se eliminó correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún valor a eliminar.");
            }
            limpiarTodo();
        }
        private void validarDatos()
        {
            btnAgregar.Enabled = txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "";
        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            cmbCodigo.Text = "";
            Lista.Recorrer();
            Lista.Recorrer(dgvDatos);
            Lista.Recorrer(lstDatos);
            Lista.Recorrer(cmbCodigo);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvDatos);
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvDatos);
        }
    }
}
