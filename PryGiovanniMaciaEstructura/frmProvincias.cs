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
    public partial class frmProvincias : Form
    {
        public frmProvincias()
        {
            InitializeComponent();
        }
        clsArchivo X = new clsArchivo();
        private void frmProvincias_Load(object sender, EventArgs e)
        {
            X.NombreArchivo = "Provincias.csv";
            if (File.Exists(X.NombreArchivo))
            {
                X.Recorrer(dgvGrilla);
            }
            else
            {
                MessageBox.Show("El archivo no existe. Crea un archivo primero.");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            String Datos = "";
            Datos = txtCodigo.Text + ";" + txtNombre.Text;
            X.Grabar(Datos);
            X.Recorrer(dgvGrilla);
            MessageBox.Show("Datos Grabado Exitosamente...", "Proceso Exitoso");
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtCodigo.Select();
        }
        private void ControlarTxt()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "")
            {
                btnGrabar.Enabled = true;

            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlarTxt();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ControlarTxt();
        }
    }
}
