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
        public frmBaseDatosMostrarTabla()
        {
            InitializeComponent();
            clsTemas.AplicarTema(this);
        }
        
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBaseDatosMostrarTabla_Load(object sender, EventArgs e)
        {

        }
    }
}
