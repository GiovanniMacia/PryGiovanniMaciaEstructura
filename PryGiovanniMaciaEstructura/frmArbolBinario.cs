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
            clsTemas.AplicarTema(this);
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        clsArchivo x = new clsArchivo();
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            ValidarDatos();
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
            LosRecorrer();
            limpiarTodo();
        }

      
        private void LosRecorrer()
        {
            Arbol.Recorrer(tvArbol);
            Arbol.Recorrer(cmbCodigo);
            Arbol.Recorrer(dgvDatos);
        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            cmbCodigo.Text = "";
        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Arbol.Eliminar(Convert.ToInt32(cmbCodigo.Text));
            LosRecorrer();
        }
        private void ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

       

        private void btnEquilibrar_Click_1(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.Recorrer(tvArbol);

        }

        private void optInOrden_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cmbCodigo.Items.Count > 0) Arbol.Recorrer(dgvDatos);

        }

        private void optPreOrden_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cmbCodigo.Items.Count > 0) Arbol.RecorrerPre(dgvDatos);
        }

        private void optPostOrden_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cmbCodigo.Items.Count > 0) Arbol.RecorrerPost(dgvDatos);
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
