using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }


        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Agregar()
        {
            try
            {
                StreamReader AD = new StreamReader("Cola.csv");
                String dato = "";
                dato = AD.ReadLine();
                dato = AD.ReadLine();
                dato = AD.ReadLine();
                dato = AD.ReadLine();
                while (dato != null)
                {
                    clsNodo Persona = new clsNodo();
                    String[] datos = dato.Split(';');
                    Persona.Código = Convert.ToInt32(datos[0]);
                    Persona.Nombre = datos[1];
                    Persona.Trámite = datos[2];

                    Agregar(Persona);
                    dato = AD.ReadLine();

                }
                AD.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Código, aux.Nombre, aux.Trámite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Código);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {

                AD.Write(aux.Código);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.Write(aux.Trámite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }

    }
}

