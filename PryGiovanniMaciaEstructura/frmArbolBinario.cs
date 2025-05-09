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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        clsArchivo x = new clsArchivo();
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);


            if (Arbol.BuscarCodigo(codigo) != null)
            {
                Arbol.Eliminar(codigo);
                Arbol.Recorrer(tvArbol);
                Arbol.Recorrer(dgvDatos);
                MessageBox.Show("Nodo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Código no encontrado en el árbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                MessageBox.Show("Por favor complete todos los campos antes de agregar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                clsNodo aux = new clsNodo();
                aux.Código = Convert.ToInt32(txtCodigo.Text);
                aux.Nombre = txtNombre.Text;
                aux.Trámite = txtTramite.Text;
                Arbol.Agregar(aux);
            }
            Arbol.Recorrer(tvArbol);
            Arbol.Recorrer(dgvDatos);
        }
    }
}
