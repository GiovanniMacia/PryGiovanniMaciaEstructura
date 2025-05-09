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
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        private void frmCiudades_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Ciudades.csv";
            if (File.Exists(x.NombreArchivo))
            {
                x.Recorrer(lstCiudades);
            }
            else
            {
                MessageBox.Show("El archivo no existe. Crea un archivo primero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            lstCiudades.Items.Clear();

            x.Grabar(txtNombre.Text);
            x.Recorrer(lstCiudades);
            MessageBox.Show("Dato agregado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstCiudades.Items.Clear();

            if (File.Exists(x.NombreArchivo))
            {
                File.WriteAllText(x.NombreArchivo, string.Empty);
                MessageBox.Show("Todos los datos fueron eliminados permanentemente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El archivo no existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
