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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola filaPersonas = new clsCola();
        private void frmCola_Load(object sender, EventArgs e)
        {

            filaPersonas.Agregar();
            filaPersonas.Recorrer();
            filaPersonas.Recorrer(dgvDatos);
            filaPersonas.Recorrer(lstDatos);
            filaPersonas.Recorrer(cmbDatos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nuevo = new clsNodo();
            Nuevo.Código = Convert.ToInt32(txtCodigo.Text);
            Nuevo.Nombre = txtNombre.Text;
            Nuevo.Trámite = txtTramite.Text;

            filaPersonas.Agregar(Nuevo);

            filaPersonas.Recorrer();
            filaPersonas.Recorrer(dgvDatos);
            filaPersonas.Recorrer(lstDatos);
            filaPersonas.Recorrer(cmbDatos);

            txtCodigo.Text = " ";
            txtNombre.Text = " ";
            txtTramite.Text = " ";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (filaPersonas.Primero != null)
            {
                lblCod.Text = filaPersonas.Primero.Código.ToString();
                lblNom.Text = filaPersonas.Primero.Nombre;
                lblTra.Text = filaPersonas.Primero.Trámite;

                filaPersonas.Eliminar();

                filaPersonas.Recorrer();
                filaPersonas.Recorrer(dgvDatos);
                filaPersonas.Recorrer(lstDatos);
                filaPersonas.Recorrer(cmbDatos);
            }
            else
            {
                lblCod.Text = "";
                lblNom.Text = "";
                lblTra.Text = "";
            }
        }
    }
}
