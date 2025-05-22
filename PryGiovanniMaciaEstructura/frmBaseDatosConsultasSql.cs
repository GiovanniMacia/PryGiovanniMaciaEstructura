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
    public partial class frmBaseDatosConsultasSql : Form
    {
        clsBaseDeDatos BD = new clsBaseDeDatos();
        public frmBaseDatosConsultasSql()
        {
            InitializeComponent();
            clsTemas.AplicarTema(this);

        }

        private void frmBaseDatosConsultasSql_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            BD.Consultar(txtQuery.Text, dgvMostrarConsulta);
        }
    }
}
