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
    public partial class frmBaseDatosMostrarTabla : Form
    {
        clsBaseDeDatos BD = new clsBaseDeDatos();
        public frmBaseDatosMostrarTabla()
        {
            InitializeComponent();
            clsTemas.AplicarTema(this);
        }
        
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            BD.Listar(cmbCargar.Text, dgv);

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBaseDatosMostrarTabla_Load(object sender, EventArgs e)
        {
            BD.Listar(dgv);
            cargarCmb();
            cmbCargar.SelectedIndex = 0;
        }
        private void cargarCmb()
        {
            string[] tablas = { "Autor", "Idioma", "Libro", "Pais" };
            cmbCargar.Items.Clear();
            foreach (string s in tablas)
            {
                cmbCargar.Items.Add(s);
            }
        }

    }
}
