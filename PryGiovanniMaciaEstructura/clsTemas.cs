using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    public class clsTemas
    {
        public enum TipoTema { Claro, Oscuro }


        public static TipoTema TemaActual = TipoTema.Claro;

        public static void AplicarTema(Form formulario)
        {
            if (TemaActual == TipoTema.Claro)
            {
                formulario.BackColor = Color.White;
                formulario.ForeColor = Color.Black;
                CambiarColores(formulario.Controls, Color.White, Color.Black);
            }
            else
            {
                Color oscuro = Color.FromArgb(45, 45, 48);
                formulario.BackColor = oscuro;
                formulario.ForeColor = Color.White;
                CambiarColores(formulario.Controls, oscuro, Color.White);
            }
        }

        private static void CambiarColores(Control.ControlCollection controles, Color back, Color fore)
        {
            foreach (Control ctrl in controles)
            {
                ctrl.BackColor = back;
                ctrl.ForeColor = fore;

                if (ctrl.HasChildren)
                {
                    CambiarColores(ctrl.Controls, back, fore);
                }
            }
        }
    }
}
