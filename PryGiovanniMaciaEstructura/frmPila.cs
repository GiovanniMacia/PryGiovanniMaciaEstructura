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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila filaPersonas = new clsPila();
        private void frmPila_Load(object sender, EventArgs e)
        {
            filaPersonas.Agregar(); //Leo los datos del archivo
            filaPersonas.Recorrer(); //Grabo en archivo
            filaPersonas.Recorrer(dgvDatosPila); //Muestro en grilla
            filaPersonas.Recorrer(lstDatosPila); //muestro en lista 
            filaPersonas.Recorrer(cmbDatosPila); //muestro en combobox
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Código = Convert.ToInt32(txtCódigoPila.Text);
            nuevo.Nombre = txtNombrePila.Text;
            nuevo.Trámite = txtTrámitePila.Text;

            filaPersonas.Agregar(nuevo);

            filaPersonas.Recorrer();
            filaPersonas.Recorrer(dgvDatosPila);
            filaPersonas.Recorrer(lstDatosPila);

            txtCódigoPila.Clear();
            txtNombrePila.Clear();
            txtTrámitePila.Clear();
            txtCódigoPila.Enabled = true;
            txtNombrePila.Enabled = true;
            txtTrámitePila.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaPersonas.Primero != null)
            {
                lblCodigoEliminar.Text = filaPersonas.Primero.Código.ToString();
                lblNombreEliminar.Text = filaPersonas.Primero.Nombre;
                lblTramiteEliminar.Text = filaPersonas.Primero.Trámite;

                filaPersonas.Eliminar();

                filaPersonas.Recorrer();
                filaPersonas.Recorrer(dgvDatosPila);
                filaPersonas.Recorrer(lstDatosPila);
            }
            else
            {
                lblCodigoEliminar.Text = " ";
                lblNombreEliminar.Text = " ";
                lblTramiteEliminar.Text = " ";
            }

            txtCódigoPila.Clear();
            txtNombrePila.Clear();
            txtTrámitePila.Clear();
            txtCódigoPila.Enabled = true;
            txtNombrePila.Enabled = true;
            txtTrámitePila.Enabled = true;
        }
    }
}

