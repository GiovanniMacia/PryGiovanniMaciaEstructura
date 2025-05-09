using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    internal class clsArchivo
    {
        public string NombreArchivo = "";
        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine("Hola");
            AD.Close();
        }

        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

        public void Recorrer(ListBox Lista)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            string Dato = "";
            Dato = AD.ReadLine();
            Lista.Items.Clear();
            while (Dato != null)
            {
                Lista.Items.Add(Dato);
                Dato = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView Grilla)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            string Dato = "";
            Dato = AD.ReadLine();
            Grilla.Rows.Clear();
            while (Dato != null)
            {
                Grilla.Rows.Add(Dato.Split(';'));
                Dato = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox Combo)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            string Dato = "";
            Dato = AD.ReadLine();
            Combo.Items.Clear();
            while (Dato != null)
            {
                Combo.Items.Add(Dato);
                Dato = AD.ReadLine();
            }
            AD.Close();
        }

    }
}

